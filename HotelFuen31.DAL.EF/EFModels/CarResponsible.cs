namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarResponsible")]
    public partial class CarResponsible
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int EmpId { get; set; }
    }
}
