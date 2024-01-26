namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HallMenuSchedule
    {
        public int Id { get; set; }

        public int HallLogsId { get; set; }

        public int OrderMenuId { get; set; }

        public int MenuItemId { get; set; }

        public int DisplayOrder { get; set; }

        public int Quantity { get; set; }

        public virtual HallLog HallLog { get; set; }

        public virtual HallMenuOrder HallMenuOrder { get; set; }

        public virtual HallMenu HallMenu { get; set; }
    }
}
