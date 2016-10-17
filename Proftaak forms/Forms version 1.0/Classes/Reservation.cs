﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Reservation
    {
        public List<Account> Accounts = new List<Account>();

        public int ID { get; set; }                       
        public Payment Payment { get; set; }
        public Place Place { get; set; }

        public Reservation(int ID, Payment Payment, Place Place)
        {
            this.ID = ID;
            this.Payment = Payment;
            this.Place = Place;
        }
    }
}
