using System;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class PaymentForm :IAggregateRoot
    {
        public string PaymentFormID{get; set;}
        public string FormName{get; set;}
        
    }
}