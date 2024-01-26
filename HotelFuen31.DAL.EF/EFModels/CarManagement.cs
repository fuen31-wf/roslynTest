namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarManagement
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Goal { get; set; }

        [Required]
        [StringLength(50)]
        public string CarModel { get; set; }

        [Required]
        [StringLength(50)]
        public string CarIdentity { get; set; }

        [StringLength(10)]
        public string PhotoPath { get; set; }
    }
}
