using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TripLog1.Models
{
    public class Trip
    {
        [Key]
        public int TripID { get; set; }

        [Required(ErrorMessage = "Please enter a Destination.")]
        public string Destination { get; set; }

        public string Accommodations { get; set; }


        [Required(ErrorMessage = "Please enter a trip start date.")]
        //[DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }


        [Required(ErrorMessage = "Please enter a trip End date.")]
        //[DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }


        public string Phone { get; set; }

        public string Email { get; set; }

        public string Things { get; set; }

        public string Things1 { get; set; }

        public string Things2 { get; set; }



       

    }
}
