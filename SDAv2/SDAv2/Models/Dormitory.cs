﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDAv2.Models
{
    public class Dormitory
    {
        public int DormitoryId { get; set; }
        public string Ulica { get; set; }
        public string NumerMieszkania { get; set; }
        public string Miejscowosc { get; set; }
        public string KodPocztowy { get; set; }
        public byte IloscPokoi { get; set; }
    }
}