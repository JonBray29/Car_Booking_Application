﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RustyRepairs.App_Code
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool DepositStatus { get; set; }
    }
}
