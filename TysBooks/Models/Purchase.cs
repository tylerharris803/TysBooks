using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TysBooks.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int DonationId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line.")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter the city name.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state name.")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter the country.")]
        public string Country { get; set; }

        public bool Annonymous { get; set; }


    }
}
