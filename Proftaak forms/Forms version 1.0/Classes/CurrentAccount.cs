using Forms_version_1._0.Classes;
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


        /// <summary>
        /// Checks if a account exist in the database 
        /// </summary>
        /// <returns>True if account exists false if not</returns>
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

        /// <summary>
        /// Checks if a account exist in the database 
        /// </summary>
        /// <returns>True if account exists false if not</returns>
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

        /// <summary>
        /// Gets the password that belongs to the corresponding AccountID
        /// </summary>
        /// <returns>True if password exists false if not</returns>
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

        /// <summary>
        /// Gets the function that belongs to the corresponding AccountID
        /// </summary>
        /// <returns>True if function exists false if not</returns>
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

        /// <summary>
        /// Translate the string Function to the Enum Function
        /// </summary>
        /// <returns>The function that corresponds with the parameter</returns>
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

        /// <summary>
        /// Gets the name that belongs to the corresponding AccountID
        /// </summary>
        /// <returns>True if name exists false if not</returns>
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

        /// <summary>
        /// Gets all events from the database
        /// </summary>
        /// <returns>A list with all events that are currently active</returns>
        public static List<Event> GetEvents()
        {
            List<Event> EventList = DatabaseGetEvents.GetEvents();
            return EventList;
        }

        /// <summary>
        /// Gets the password that belongs to the corresponding AccountID
        /// </summary>
        /// <returns>Void</returns>
        public static void UpdateAccount(Account account)
        {
            UserName = account.Username;
            Password = account.Password;
            Function = account.Function;
            Name = account.Name;
        }

        /// <summary>
        /// When user logs out resets the currentaccount data to default
        /// </summary>
        /// <returns>Void</returns>
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
