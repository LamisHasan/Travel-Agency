//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelAgency.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int ID { get; set; }
        public int Seat_Number { get; set; }
        public int Trip_ID { get; set; }
        public int Customer_ID { get; set; }
        public string Type { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
