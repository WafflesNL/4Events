using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database;

namespace Forms_version_1._0.Classes
{
    /// <summary>
    /// Reservation class.
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// The list of accounts contained in the reservation.
        /// </summary>
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
        }

        public Reservation(int ID, Event Event, Payment Payment, Place Place, List<Account> accounts)
        {
            this.ID = ID;
            this.Payment = Payment;
            this.Place = Place;
            this.Event = Event;
            this.Accounts = accounts;
        }

        public Reservation(int ID, Payment Payment, Place Place)
        {
            this.ID = ID;
            this.Payment = Payment;
            this.Place = Place;
        }

        public Reservation()
        {
            Accounts = new List<Account>();
            this.ID = DatabaseGetHighestID.GetHighestID("Reservering");

            Payment = new Payment(0, false);
        }

        /// <summary>
        /// Adds the reservation to the database.
        /// </summary>
        /// <returns>If the reservation was succesful returns a true</returns>
        public bool AddReservation()
        {
            Reservation Reservation = new Reservation(ID, Event, Payment, Place, Accounts);
            if (DatabaseCreateReservation.CreateReservation(Reservation))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Checks if the reservation is trying to add more visitors than is allowed.
        /// </summary>
        /// <returns>Returns true if the accounts in the reservation will add up higher than is allowed in event.</returns>
        public bool MoreThanMaxVisitors()
        {
            if (Event.MaxVisitors > DatabaseGetAccountReservering.GetReservationAmountReservation(this))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Account> GetAccountsFunction(Function function)
        {
            List<Account> accountList = DatabaseGetAccounts.GetAccountsFunction(function);
            return accountList;
        }

        public override string ToString()
        {
            return ID + "\t " + Event.Name + "\t " + this.Accounts.Count;
        }
    }
}
