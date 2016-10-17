﻿using System;
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

        /// <summary>
        /// Used to add a account to the databse
        /// </summary>
        /// <param name="Name"><param>
        /// <param name="Discription"></param>
        /// <param name="Location"></param> 
        /// <param name="Maxvisitors"><param>
        /// <param name="Date"></param>
        /// <param name="Account"></param> 
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


        /// <summary>
        /// Used to get a account to the databse
        /// </summary>
        /// <param name="ID"><param>
        /// <param name="Name"><param>
        /// <param name="Discription"></param>
        /// <param name="Location"></param> 
        /// <param name="Maxvisitors"><param>
        /// <param name="Date"></param>
        /// <param name="Account"></param> 
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

        /// <summary>
        /// Used to edit a account to the databse
        /// </summary>
        /// <param name="ID"><param>
        /// <param name="Name"><param>
        /// <param name="Discription"></param>
        /// <param name="Location"></param> 
        /// <param name="Maxvisitors"><param>
        /// <param name="Date"></param>     
        public Event(int ID, string Name, string Discription, string Location, int Maxvisitors, DateTime Date)
        {
            this.ID = ID;
            this.Name = Name;
            this.Discription = Discription;
            this.Location = Location;
            this.MaxVisitors = Maxvisitors;
            this.Date = Date;
        }

        /// <summary>
        /// Check if changes for Event are allowed in the database
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public bool EditEvent(Event Event)
        {
            bool Check = DatabaseEditEvent.EditEvent(Event); 
            return Check;
        }

        /// <summary>
        /// Checks if the new event is allowed in the database
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
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
            TimeLine Timeline = new TimeLine();
            bool Check = DatabaseCreateTimeline.CreateTimeline();
            return Check;
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
