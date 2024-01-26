namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LeaveDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(8)]
        public string BloodType { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(16)]
        public string IdentityNumber { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "datetime2")]
        public DateTime Birthday { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Gender { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(16)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1024)]
        public string Address { get; set; }
    }
}
