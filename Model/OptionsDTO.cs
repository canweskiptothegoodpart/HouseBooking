﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OptionsDTO
    {
        public int Id { get; set; }
        public ApartmentDTO Apartment { get; set; }
        //public BuildingDTO Building { get; set; }//
        public string Discription { get; set; }
    }
}
