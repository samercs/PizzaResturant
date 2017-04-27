﻿using System;

namespace PizzaResturant.Model
{
    public class PaymentInfo
    {
        public int PaymentInfoId { get; set; }
        public string Name { get; set; }
        public string CreditCardNo { get; set; }
        public string CreditCardType { get; set; }
        public DateTime ExpireDate { get; set; }
        public string SecurityCode { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
