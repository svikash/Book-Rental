using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuirkyBookRental.Models
{
    public class Book
    {

        [Required]
        public int Id { get; set; }

        [Requried]
        public string ISBN { get; set; }

        [Requried]
        public string Author { get; set; }

        [Requried]
        public string Title { get; set; }

        [Requried]
        public string Description { get; set; }

        [Requried]
        [DataType(DataType.ImageUrl)]
        public String ImageUrl { get; set; }

        [Requried]
        [Range(0,1000)]
        public int Availability { get; set; }



        [Requried]
        [DataType(DataType.Currency)]
        public double price { get; set; }

        
        [DisplayFormat(DataFormatString ="{0: MMM dd yyyy}")]
        public DateTime? DateAdded { get; set; }

        [Requried]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime PublicationDate { get; set; }

        [Requried]
        public int GenreId { get; set; }

        
        public Genre Genre { get; set; }
    }
}