namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusRoute
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StarterStop { get; set; }

        [Required]
        [StringLength(50)]
        public string StarterLongtitude { get; set; }

        [Required]
        [StringLength(50)]
        public string StarterLatitude { get; set; }

        [Required]
        [StringLength(50)]
        public string DestinationStop { get; set; }

        [Required]
        [StringLength(50)]
        public string DestinationLongtitude { get; set; }

        [Required]
        [StringLength(50)]
        public string DestinationLatitude { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DepartureTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ArrivalTime { get; set; }
    }
}
