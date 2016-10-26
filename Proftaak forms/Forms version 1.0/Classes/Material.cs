using Forms_version_1._0.Classes.Database.MaterialManagement;
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

        
        public Material(int ID, string Type, double Price, int? EventID, int? AccountID)
        {
            this.ID = ID;
            this.Type = Type;
            this.Price = Price;
            this.EventID = EventID;
            this.AccountID = AccountID;
        }

        public void Rent(List<Material> list, int AccountID)
        {
            // add code to add selected items to accountid via form -> material -> database query
            DatabaseUpdateMaterial.UpdateAccount(list, AccountID);
        }

        public double TotalPrice(List<Material> list)
        {
            double totalprice = 0;

            foreach (Material items in list)
            {
                totalprice += items.Price;
            }

            return totalprice;
        }
        public List<Material> GetMaterialAvailableList()
        {
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialAvailable();
            return MaterialList;
        }

        public List<Material> GetMaterialForEvent(int eventid)
        {   
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialforEventNoAccount(eventid);
            return MaterialList;
        }

        public List<Account> GetAccounts(int eventid)
        {
            List<Account> AccountList = DatabaseGetAccounts.GetAccountsEventID(eventid);
            return AccountList;
        }

        public override string ToString()
        {
            return Type +  ", €" + Price;
        }

    }
}
