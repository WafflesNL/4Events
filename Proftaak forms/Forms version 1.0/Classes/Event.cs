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
        public List<Material> MaterialList = new List<Material>();

        public TimeLine TimeLine { get; set; }
        public Account Account { get; set; }  
        public Camping Camping { get; set; }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int MaxVisitors { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        /// <summary>
        /// Used to add a Event to the database
        /// </summary>
        /// <param name="Name">The name of the event as string<param>
        /// <param name="Description">The description of the event as string</param>
        /// <param name="Location">The location an event takes place as string</param> 
        /// <param name="Maxvisitors">The maximum amount of visitors as int<param>
        /// <param name="Date">The date an event takes place as DateTime</param>
        /// <param name="Account">The account that made the event as Account object</param> 
        /// <param name="MaterialList">A list of material that belongs to this event as List<Material></param> 
        public Event(string Name, string Description, string Location, int MaxVisitors, DateTime Date, Account Account, List<Material> MaterialList) 
        {
            this.Name = Name;
            this.Description = Description;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;
            this.MaterialList = MaterialList;                       
        }


        /// <summary>
        /// Used to get a Event to the database
        /// </summary>
        /// <param name="ID">The ID of an event as int<param>
        /// <param name="Name">The name of the event as string<param>
        /// <param name="Description">The description of the event as string</param>
        /// <param name="Location">The location an event takes place as string</param> 
        /// <param name="Maxvisitors">The maximum amount of visitors as int<param>
        /// <param name="Date">The date an event takes place as DateTime</param>
        /// <param name="Account">The account that made the event as Account object</param> 
        /// <param name="Timelime">The timeline of an event as TimeLine object</param> 
        /// <param name="Camping">The camping that belongs to the event as Camping object</param> 
        public Event(int ID, string Name, string Description, string Location, int MaxVisitors, DateTime Date, Account Account, Camping Camping, TimeLine Timeline)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.Location = Location;
            this.MaxVisitors = MaxVisitors;
            this.Date = Date;
            this.Account = Account;
            this.Camping = Camping;                 
            this.TimeLine = Timeline;    
        }

        /// <summary>
        /// Used to edit a Event to the database
        /// </summary>
        /// <param name="ID">The ID of an event as int<param>
        /// <param name="Name">The name of the event as string<param>
        /// <param name="Description">The description of the event as string</param>
        /// <param name="Location">The location an event takes place as string</param> 
        /// <param name="Maxvisitors">The maximum amount of visitors as int<param>
        /// <param name="Date">The date an event takes place as DateTime</param>
        public Event(int ID, string Name, string Description, string Location, int Maxvisitors, DateTime Date)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.Location = Location;
            this.MaxVisitors = Maxvisitors;
            this.Date = Date;
        }

        /// <summary>
        /// Checks if the changes for Event are allowed in the database
        /// </summary>
        /// <param name="Event">The event to be checked as Event object.</param>
        /// <returns>Returns true if the event is allowed in the database false if it is not</returns>
        public bool EditEvent(Event Event)
        {
            bool Check = DatabaseEditEvent.EditEvent(Event); 
            return Check;
        }

        /// <summary>
        /// Creates a new event in the database.
        /// </summary>
        /// <param name="Event">The event to be created as Event object.</param>
        /// <returns>Return true if it was created false if it was not.</returns>
        public bool CreateEvent(Event Event)
        {
            bool Check = DatabaseCreateEvent.CreateEvent(Event);
            return Check;
        }

        /// <summary>
        /// Checks if the date for an newly created event is valid
        /// </summary>
        /// <returns>True if date is valid false if not</returns>
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

        /// <summary>
        /// Get the camping that belongs to an event 
        /// </summary>
        /// <returns>True if camping exist in databse false if not</returns>
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

        /// <summary>
        ///  Creates a new timeline for a Event
        /// </summary>
        /// <returns>True if time line exist false if ot</returns>
        public bool CreateTimeLine()
        {
            //TimeLine Timeline = new TimeLine();
            bool Check = DatabaseCreateTimeline.CreateTimeline();
            return Check;
        }

        /// <summary>
        /// Get a Guests list for a specific event (people who are present at an event)
        /// </summary>
        /// <returns>A list with all Accounts for a event<returns>
        public List<Account> GetGuestList()
        {
            List<Account> GuestList = DatabaseGetAccounts.GetAccountsEventID(ID);
            return GuestList;
        }

        /// <summary>
        /// Get a Materials list for a specific event
        /// </summary>
        /// <returns>A list with all Materials for a event that are still free to rent<returns>
        public List<Material> GetMaterialList()
        {
            List<Material> MaterialList = DatabaseGetMaterial.GetMaterialforEventNoAccount(ID);      
            return MaterialList;
        }

        /// <summary>
        /// Get a reservation list for a specific event
        /// </summary>
        /// <returns>A list with all reservations for a event<returns>
        public List<Reservation> GetReservationList()
        {
            List<Reservation> ReservationList = DatabaseGetReservations.GetReservation(ID);
            return ReservationList;        
        }

        /// <summary>
        /// Gets an account with a specific RFID tag.
        /// </summary>
        /// <param name="RFIDtag">The RFID tag from an RFID reader.</param>
        /// <returns>Returns a single account</returns>
        public Account Checkin_CheckAccount(string RFIDtag)
        {
            
            if (DatabaseGetAccounts.GetAccountRFID_Checkin(RFIDtag, ID) != null) //database
            {
                Account Account = DatabaseGetAccounts.GetAccountRFID_Checkin(RFIDtag, ID);
                return Account;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Updates an Account by adding an Event to it.
        /// </summary>
        /// <param name="Account">A single account.</param>
        /// <returns>Returns true or false.</returns>
        public bool Checkin_UpdateAccount(Account Account)
        {
            if (DatabaseEditAccount.UpdateEventID_checkin(Account, ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns an account if it is checked in to this event.
        /// </summary>
        /// <param name="RFIDtag">The RFID tag from an RFID reader.</param>
        /// <returns>Returns a single account.</returns>
        public Account Checkuit_CheckAccount(string RFIDtag)
        {
            if (DatabaseGetAccounts.GetAccountRFID_Checkuit(RFIDtag, ID) != null) //database
            {
                Account Account = DatabaseGetAccounts.GetAccountRFID_Checkuit(RFIDtag, ID);
                return Account;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Updates an account by removing this event from it.
        /// </summary>
        /// <param name="Account">A single account</param>
        /// <returns>Returns true or false</returns>
        public bool Checkuit_UpdateAccount(Account Account)
        {
            if (DatabaseEditAccount.UpdateEventID_checkuit(Account, ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Tostring methods for event
        /// </summary>
        /// <returns>Object event to a string</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
