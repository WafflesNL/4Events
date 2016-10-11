using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class CurrentAccount
    {
        public static int ID { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static Function Function { get; set; }
        public static string Name { get; set; }
        //public static int EventID { get; set; }

        public static bool Login(string Password, string Username)
        {
            ID = DatabaseLogin.CheckUser(Password, Username);

            if (ID != 0 && GetUserName(ID) && GetPassword(ID) && GetName(ID) && GetFunction(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  
        private static bool GetUserName(int ID)
        {
            string Check = DatabaseLogin.GetString(ID, "Gebruikersnaam");
            if (Check != "")
            {
                UserName = Check;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private static bool GetPassword(int ID)
        {
            string Check = DatabaseLogin.GetString(ID, "Wachtwoord");
            if (Check != "")
            {
                Password = Check;
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool GetFunction(int ID)
        {
            string Check = DatabaseLogin.GetString(ID, "Functie");
            if (Check != "")
            {           
                Function = TranslateFunction(Check);
                return true;
            }
            else
            {
                return false;
            }
        }


        public static Function TranslateFunction(string ParameterFunction)
        {
            Function function = Function.Bezoeker;
            switch (ParameterFunction)
            {
                case "Bezoeker":
                    function = Function.Bezoeker;
                    break;
                case "Beheerder":
                    function = Function.Beheerder;
                    break;
                case "Accountbeheerder":
                    function = Function.Accountbeheerder;
                    break;
                case "Medewerker":
                    function = Function.Medewerker;
                    break;
            }
            return function;
        }

        private static bool GetName(int ID)
        {
            string Check = DatabaseLogin.GetString(ID, "Naam");
            if (Check != "")
            {
                Name = Check;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        private static bool GetEventID(int ID)
        {

        }
        */

        public static void RemovePropertys()
        {
            ID = 0;
            UserName = null;
            Password = null;
            Function = Function.Bezoeker;
            Name = null;
        }
    }
}
