using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Material
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }     
        public int? EventID { get; set; }
        public int? AccountID { get; set; }

        /// <summary>
        /// Used to change account in the database
        /// </summary>
        /// <param name="ID">Identidication for a Material</param>
        /// <param name="Type">Type of the object<param>
        /// <param name="Price">Price of the object</param>
        /// <param name="EventID">Event where the item is currently at</param>
        /// <param name="AccountID">Account currently in possession of the object<param> 
        public Material(int ID, string Type, double Price, int? EventID, int? AccountID)
        {
            this.ID = ID;
            this.Type = Type;
            this.Price = Price;
            this.EventID = EventID;
            this.AccountID = AccountID;
        }

        /// <summary>
        /// Adds all material to an account.
        /// </summary>
        /// <param name="list">All material to be rented</param>
        /// <param name="AccountID">The account that the material will be added to.</param>
        public void Rent(List<Material> list, int AccountID)
        {
            // add code to add selected items to accountid via form -> material -> database query
            DatabaseUpdateMaterial.UpdateAccount(list, AccountID);
        }

        /// <summary>
        /// Removes material from an account
        /// </summary>
        /// <param name="list">The material to be removed.</param>
        /// <param name="AccountID">The account that the material will be removed from.</param>
        public void Return(List<Material> list, int AccountID)
        {
            DatabaseUpdateMaterial.UpdateAccount(list, null);
        }

        /// <summary>
        /// Calculates the total price from all material.
        /// </summary>
        /// <param name="list">The items to be calculated.</param>
        /// <returns>Returns the price of all material in the list</returns>
        public double TotalPrice(List<Material> list)
        {
            double totalprice = 0;

            foreach (Material items in list)
            {
                totalprice += items.Price;
            }

            return totalprice;
        }

        /// <summary>
        /// Get all material that is available.
        /// </summary>
        /// <returns>Returns a list with material.</returns>
        public List<Material> GetMaterialAvailableList()
        {
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialAvailable();
            return MaterialList;
        }

        /// <summary>
        /// Get all material that is currently rented to an account.
        /// </summary>
        /// <param name="eventid"></param>
        /// <param name="accountid"></param>
        /// <returns>Returns a list of material</returns>
        public List<Material> GetMaterialForAccount(int eventid, int accountid)
        {
            List<Material> Materiallist = DatabaseGetMaterial.GetMaterialforAccountonEvent(eventid, accountid);
            return Materiallist;
        }

        /// <summary>
        /// Gets the account that has the specified RFID tag
        /// </summary>
        /// <param name="RFIDtag"></param>
        /// <returns>Returns a single account</returns>
        public Account GetAccountRFID(string RFIDtag)
        {
            Account account = DatabaseGetAccounts.GetAccountFromRFID(RFIDtag);
            return account;
        }
      
        public override string ToString()
        {
            return Type +  ", €" + Price;
        }

    }
}
