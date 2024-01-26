namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HallMenuOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HallMenuOrder()
        {
            HallMenuSchedules = new HashSet<HallMenuSchedule>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public int MenuItemId { get; set; }

        public decimal TotalPrice { get; set; }

        public int? TableCount { get; set; }

        public virtual HallMenu HallMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallMenuSchedule> HallMenuSchedules { get; set; }
    }
}
