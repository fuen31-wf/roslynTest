namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarCartItem
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        [Required]
        [StringLength(50)]
        public string PickUpLongtitude { get; set; }

        [Required]
        [StringLength(50)]
        public string PickUpLatitude { get; set; }

        [Required]
        [StringLength(50)]
        public string DestinationLatitude { get; set; }

        [Required]
        [StringLength(50)]
        public string DestinationLongtitude { get; set; }

        public decimal SubTotal { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ActualStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ActualEndTime { get; set; }
    }
}
