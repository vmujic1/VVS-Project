﻿using System.ComponentModel.DataAnnotations;

namespace Ayana.Models
{
    public class DtoRequest
    {
        [Key]
        public int DtoRequestID { get; set; }
        public Subscription subscription { get; set; }
        public Payment payment { get; set; }

        public Customer customer{ get; set; }

        public Discount discount { get; set; }
    }
}