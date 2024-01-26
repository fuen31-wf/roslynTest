namespace HotelFuen31.DAL.EF.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HallLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HallLog()
        {
            HallMenuSchedules = new HashSet<HallMenuSchedule>();
        }

        public int Id { get; set; }

        public int HallItemId { get; set; }

        public int UserId { get; set; }

        public int? Guests { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool BookingStatus { get; set; }

        public bool? HallStatus { get; set; }

        public virtual HallItem HallItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallMenuSchedule> HallMenuSchedules { get; set; }
    }
}
