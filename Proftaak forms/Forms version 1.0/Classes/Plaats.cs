﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Plaats
    {
        public Reservation Reservering { get; set; }
        public enum Categorie
        {
            Luxe,
            Normal,
            Green,
        }
    }
}