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
    using System.ComponentModel.DataAnnotations;

    public partial class Trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Type of the trip")]
        public string Type { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Trip Start Date")]
        [DataType(DataType.Date)]
        public System.DateTime Start_Date { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Trip End Date")]
        [DataType(DataType.Date)]
        public System.DateTime End_Date { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(10, 45, ErrorMessage = "Minimum number of seats is 10, maximum is 45")]
        [Display(Name = "Number of seats")]
        public int Number_Of_Seats { get; set; }


        [Required(ErrorMessage = "*")]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "First Language")]
        public string Langauge1 { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Second Language")]
        public string Langauge2 { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Third Language")]
        public string Language3 { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Ticket Base Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int Tour_Guide_ID { get; set; }
        public int Number_Of_Tickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual TourGuide TourGuide { get; set; }
    }
}
