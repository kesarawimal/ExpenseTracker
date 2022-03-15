using ExpenseTracker.DataObjects;
using ExpenseTracker.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class UserProfile
    {
        ExpenseTrackerData dbData = new ExpenseTrackerData();
        private static Boolean hasAuthenticated = false;
        private static int userId = 1;

        public UserProfile()
        {
            ExpenseTrackerData.UserRow row = this.dbData.User.NewUserRow();
            row.username = "kesara";
            row.email = "kesara@devrolabs.com";
            row.password = SecurePasswordHasher.Hash("password");
            this.dbData.User.AddUserRow(row);
        }

        public Boolean HasAuthenticated() {
            return hasAuthenticated;
        }

        public int getUserId()
        {
            return userId;
        }

        public Boolean LoginUser(UserData userData)
        {
            DataRow[] results;
            results = this.dbData.User.Select("username = '" + userData.username + "'");

            if (results.Length > 0)
            {
                if (SecurePasswordHasher.Verify(userData.password, results[0]["password"].ToString())) {
                    hasAuthenticated = true;
                    userId = Int32.Parse(results[0]["id"].ToString());
                    return true;
                }  else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }

        public Boolean RegisterUser(UserData userData)
        {
            ExpenseTrackerData.UserRow row = this.dbData.User.NewUserRow();
            row.username = userData.username;
            row.email = userData.email;
            row.password = SecurePasswordHasher.Hash(userData.password);
            this.dbData.User.AddUserRow(row);

            hasAuthenticated = true;
            userId = row.id;
            return true;
        }
    }
}