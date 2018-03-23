using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Core
{
    public class Vehicle
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        [Required]
        [MaxLength(40)]
        public string Brand
        {
            get;
            set;
        }

        [Required]
        [MaxLength(50)]
        public string Model
        {
            get;
            set;
        }

        [Required]
        [MaxLength(30)]
        public string Color
        {
            get;
            set;
        }

        [Required]
        public int Year
        {
            get;
            set;
        }

        [Required]
        public decimal Price
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        [Required]
        public bool Isnew
        {
            get;
            set;
        }

        [Required]
        public DateTime DateCreated
        {
            get;
            set;
        }

        public DateTime DateUpdated
        {
            get;
            set;
        }
    }
}
