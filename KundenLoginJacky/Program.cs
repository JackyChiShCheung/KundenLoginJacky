using System;

namespace KundenLoginJacky
{
    class Kunde
    {
        private String username;
        private String password;
        private String email;

        public Kunde()
        {

        }
        public Kunde(String userName, String passWord, String email)
        {
            this.username = userName;
            this.password = passWord;
            this.email = email;
        }

        public String Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value ; }
        }

        public override string ToString()
        {
            return "Username : " + username + " Password : "+ password + " Email : " + email;
        }
    }
}
