﻿using Forms_version_1._0.Classes;
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
        public static int? EventID { get; set; }

        /// <summary>
        /// Checks if an account exists in the database.
        /// </summary>
        /// <param name="Password">The password of an account</param>
        /// <param name="Username">The username of an account</param>
        /// <returns>Trie if an account exists false if not</returns>
        public static bool Login(string Password, string Username)
        {
            ID = DatabaseLogin.CheckUser(Password, Username);

            if (ID != 0 && GetUserName(ID) && GetPassword(ID) && GetName(ID) && GetFunction(ID) && GetEventID(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if an account exists in the database
        /// </summary>
        /// <param name="ID">The id of an account</param>
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
        /// <param name="ID">The id of an account</param>
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
        /// Get the function that belongs to the corresponding AccountID
        /// </summary>
        /// <param name="ID">The id of an Account</param>
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
        /// Gets the name that belongs to the corresponding AccountID
        /// </summary>
        /// <param name="ID">The id of an Account</param>
        /// <returns>True if the name exists false if not</returns>
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
        /// Gets the event ID that belongs to the corresponding AccountID
        /// </summary>
        /// <param name="ID">The id of an Account</param>
        /// <returns>True if EventID is bigger than 0 false if not</returns>
        private static bool GetEventID(int ID)
        {
            int? Check = DatabaseLogin.GetInt(ID, "EventID");
            if (Check == 0)
            {
                EventID = null;
                return true;
            }
            else if (Check > 0)
            {
                EventID = Check;
                return true;
            }
            else
            {
                return false;
            }      
        }


        /// <summary>
        /// Changes the string to the appropriate Enum.
        /// </summary>
        /// <param name="ParameterFunction">Valid parameters are Bezoeker, Beheerder, Accountbeheerder and Mederwerker</param>
        /// <returns>Returns a single enum Function.</returns>
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
        /// Changes the string to the appropriate Enum.
        /// </summary>
        /// <param name="ParameterCategorie">Valid parameters are Green, Luxe and Normaal</param>
        /// <returns>Returns a single enum Categorie.</returns>
        public static Categorie TranslateCategorie(string ParameterCategorie)
        {
            Categorie Categorie = Categorie.Normal;
            switch (ParameterCategorie)
            {
                case "Green":
                    Categorie = Categorie.Green;
                    break;
                case "Luxe":
                    Categorie = Categorie.Luxe;
                    break;
                case "Normaal":
                    Categorie = Categorie.Normal;
                    break;            
            }
            return Categorie;
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
