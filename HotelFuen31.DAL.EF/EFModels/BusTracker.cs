namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusTracker
    {
        public int Id { get; set; }

        public int BusId { get; set; }

        public int Latitude { get; set; }

        public int Longtitude { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdate { get; set; }
    }
}
