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
        public List<Account> presentList = new List<Account>();

        public TimeLine TimeLine { get; set; }
        public Account Account { get; set; }  
        public Camping Camping { get; set; }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int MaxVisitors { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }

        //To add a account
        //Material list and Reservationlist need to be added
        public Event(string Name, string Discription, string Location, int MaxVisitors, DateTime Date, Account Account) 
        {
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;
            //this.materialList = materialList;
            //this.ReservationList = ReservationList;      
        }

        //To get a account
        public Event(int ID, string Name, string Discription, string Location, int MaxVisitors, DateTime Date, Account Account, Camping Camping) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;
            //this.materialList = materialList;
            //this.ReservationList = ReservationList;
        }

        //To edit account
        public Event(int ID, string Name, string Discription, string Location, int Maxvisitors, DateTime Date)
        {
            this.ID = ID;
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = Maxvisitors;
            this.Date = Date;
        }

      
        public bool EditEvent(Event Event)
        {
            bool Check = DatabaseEditEvent.EditEvent(Event); 
            return Check;
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
