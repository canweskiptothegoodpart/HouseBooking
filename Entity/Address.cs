﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class Address
	{
		public int Id { get; set; }
		public string Country { get; set; }
		public string City{ get; set; }
		public string District { get; set; }
		public string Street { get; set; }
        public Building Building { get; set; }
        public string? House { get; set; }
	}
}
