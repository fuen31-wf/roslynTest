namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RestaurantReservation
    {
        public int Id { get; set; }

        public int Customer_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int Counts { get; set; }

        public int Period_id { get; set; }

        public int Status_Id { get; set; }

        public int Seat_Id { get; set; }

        public virtual RestaurantCustomer RestaurantCustomer { get; set; }

        public virtual RestaurantPeriod RestaurantPeriod { get; set; }

        public virtual RestaurantSeat RestaurantSeat { get; set; }
    }
}
