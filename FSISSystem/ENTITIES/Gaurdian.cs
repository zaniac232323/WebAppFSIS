﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FSISSystem.ENTITIES
{
    [Table("Gaurdian")]
    class Gaurdian
    {
        public int GaurdianID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}
