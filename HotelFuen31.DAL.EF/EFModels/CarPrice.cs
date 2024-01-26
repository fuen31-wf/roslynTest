namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarPrice
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LowDistance { get; set; }

        [Required]
        [StringLength(50)]
        public string HighDistance { get; set; }

        public decimal Price { get; set; }
    }
}
