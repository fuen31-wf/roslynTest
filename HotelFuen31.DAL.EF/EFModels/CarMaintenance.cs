namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarMaintenance")]
    public partial class CarMaintenance
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ActualStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ActualEndTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Action { get; set; }

        public decimal Expense { get; set; }

        public int EmpId { get; set; }
    }
}
