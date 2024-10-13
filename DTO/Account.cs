using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private string accountType;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private DateTime workBegin;

        public Account(string username, string displayname, string accountType, string password = null)
        {
            this.username = username;
            this.password = password;
            this.displayname = displayname;
            this.accountType = accountType;
        }

        public Account(DataRow row)
        {
            username = row["Username"].ToString();
            password = row["Password"].ToString();
            displayname = row["DisplayName"].ToString();
            accountType = row["AccountType"].ToString();
            dateOfBirth = (DateTime)row["DateOfBirth"];
            phoneNumber = row["PhoneNumber"].ToString();
            workBegin = (DateTime)row["WorkBegin"];

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime WorkBegin { get => workBegin; set => workBegin = value; }
    }
}
