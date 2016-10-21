using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database;

namespace Forms_version_1._0.Classes
{
    public class Reservation
    {
        public List<Account> Accounts { get; set; }
        public int ID { get; set; }
        public Event Event { get; set; }
        public Payment Payment { get; set; }
        public Place Place { get; set; }

        public Reservation(int ID, Event Event, Payment Payment, Place Place)
        {
            this.ID = ID;
            this.Payment = Payment;
            this.Place = Place;
            this.Event = Event;

            Accounts = new List<Account>();
        }

        public Reservation(int ID, Payment Payment, Place Place)
        {
            this.ID = ID;
            this.Payment = Payment;
            this.Place = Place;

            Accounts = new List<Account>();
        }

        public bool AddReservation()
        {
            Reservation Reservation = new Reservation(ID, Event, Payment, Place);
            if (DatabaseCreateReservation.CreateReservation(Reservation))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
