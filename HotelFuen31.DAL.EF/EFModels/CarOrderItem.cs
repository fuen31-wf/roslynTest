namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarOrderItem
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int PickUpLongtitude { get; set; }

        public int PickUpLatitude { get; set; }

        public int DestinationLatitude { get; set; }

        public int DestinationLongtitude { get; set; }

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
