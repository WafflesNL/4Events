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
        public int Price { get; set; }     
        public int? EventID { get; set; }
        public int? AccountID { get; set; }

        
        public Material(int ID, string Type, int Price, int? EventID, int? AccountID)
        {
            this.ID = ID;
            this.Type = Type;
            this.Price = Price;
            this.EventID = EventID;
            this.AccountID = AccountID;
        }

        public void GetAccount()
        {

        }

        public void Rent()
        {

        }

        public List<Material> GetMaterialAvailableList()
        {
            List<Material> MaterialList = new List<Material>();
            return MaterialList;
        }

    
    }
}
