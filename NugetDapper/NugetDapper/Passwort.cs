using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOne.Security.Cryptography.BCrypt;

namespace NugetDapper
{
    class Passwort
    {
        private string password;
        private string salt;
        private string hashedPassword;
        public Passwort(string password)
        {
            this.password = password;
        }

        public string GibhashedPassword()
        {
            salt = BCryptHelper.GenerateSalt();
            hashedPassword = BCryptHelper.HashPassword(password, salt);
            return hashedPassword;

        }
        public string GibSalt()
        {
            return salt;
        }

        public bool Gibvalidation()
        {
            bool valid = BCryptHelper.CheckPassword(password, hashedPassword);
            return valid;
        }

        public void GenerateSaltBenchmarks()
        {
            for (int i = 10; i < 22; i++)
            {
                string salt = BCryptHelper.GenerateSalt(i);
                string hashedPassword = BCryptHelper.HashPassword(password, salt);
                Console.WriteLine(hashedPassword);
            }

        }


    }

}
