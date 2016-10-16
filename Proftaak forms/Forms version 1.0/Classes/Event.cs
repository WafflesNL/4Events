using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Event
    {
        public List<Reservation> ReservationList = new List<Reservation>();
        public List<Material> materialList = new List<Material>();
        public TimeLine TimeLine { get; set; }
        public Account Account { get; set; }  
        public Camping Camping { get; set; }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int MaxVisitors { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }

        //Material list and time line and Reservationlist need to be added
        public Event(string Name, string Discription, string Location, int MaxVisitors, DateTime Date, Account Account) //moet materialList bij en tijdlijn
        {
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;         
        }

        public Event(int ID, string Name, string Discription, string Location, int MaxVisitors, DateTime Date, Account Account, Camping Camping) //, List<Material> materialList
        {
            this.ID = ID;
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;           
           //this.materialList = materialList;
        }

        public void EditEvent()
        {
            
        }

        public bool CreateEvent(Event Event)
        {
            bool Check = DatabaseCreateEvent.CreateEvent(Event);

            return Check;
        }

        public bool CheckDateOutOfRange()
        {
            DateTime Date = DateTime.Now.AddDays(14);
            if (Date < this.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetCamping()
        {
            Camping Camping = DatabaseCreateEvent.GetCamping(this.Location);         
            if (Camping != null)
            {
                this.Camping = Camping;
                return true;
            }
            else
            {
                return false;
            }         
        }

        public bool CreateTimeLine()
        {
            TimeLine Timeline = new TimeLine();
            bool Check = DatabaseCreateTimeline.CreateTimeline();
            return Check;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
