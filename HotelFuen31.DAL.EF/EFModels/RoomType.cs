namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomTypeId { get; set; }

        [Required]
        [StringLength(10)]
        public string TypeName { get; set; }

        [Required]
        public string Description { get; set; }

        public int Capacity { get; set; }

        [Required]
        [StringLength(20)]
        public string BedType { get; set; }

        public int RoomCount { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageURL { get; set; }
    }
}
