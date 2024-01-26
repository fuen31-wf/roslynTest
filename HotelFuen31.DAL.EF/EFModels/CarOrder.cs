namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarOrder
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BookingTime { get; set; }

        public decimal Total { get; set; }

        public virtual CarOrder CarOrders1 { get; set; }

        public virtual CarOrder CarOrder1 { get; set; }
    }
}
