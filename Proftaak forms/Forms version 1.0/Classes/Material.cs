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

        public void Rent()
        {
            // add code to add selected items to accountid via form -> material -> database query
        }

        public List<Material> GetMaterialAvailableList()
        {
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialAvailable();
            return MaterialList;
        }

        public List<Material> GetMaterialForEvent(int eventid)
        {   
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialforEvent(eventid);
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
