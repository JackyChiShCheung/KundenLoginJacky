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
        }
    }
}
