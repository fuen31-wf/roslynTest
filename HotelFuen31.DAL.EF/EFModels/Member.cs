namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
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
        [Column(Order = 4)]
        public bool IsConfirmed { get; set; }

        [StringLength(64)]
        public string ConfirmCode { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        [StringLength(50)]
        public string IdentityNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDay { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Gender { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(16)]
        public string Phone { get; set; }

        [StringLength(1024)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Ban { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelId { get; set; }
    }
}
