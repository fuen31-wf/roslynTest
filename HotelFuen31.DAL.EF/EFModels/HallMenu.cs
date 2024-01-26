namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HallMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HallMenu()
        {
            HallMenuOrders = new HashSet<HallMenuOrder>();
            HallMenuSchedules = new HashSet<HallMenuSchedule>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DishName { get; set; }

        [Required]
        [StringLength(256)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallMenuOrder> HallMenuOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallMenuSchedule> HallMenuSchedules { get; set; }
    }
}
