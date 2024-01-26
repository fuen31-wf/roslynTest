using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HotelFuen31.DAL.EF.EFModels
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<BusRoute> BusRoutes { get; set; }
        public virtual DbSet<BusTracker> BusTrackers { get; set; }
        public virtual DbSet<CarCartItem> CarCartItems { get; set; }
        public virtual DbSet<CarMaintenance> CarMaintenances { get; set; }
        public virtual DbSet<CarManagement> CarManagements { get; set; }
        public virtual DbSet<CarOrderItem> CarOrderItems { get; set; }
        public virtual DbSet<CarOrder> CarOrders { get; set; }
        public virtual DbSet<CarPrice> CarPrices { get; set; }
        public virtual DbSet<CarResponsible> CarResponsibles { get; set; }
        public virtual DbSet<HallItem> HallItems { get; set; }
        public virtual DbSet<HallLog> HallLogs { get; set; }
        public virtual DbSet<HallMenuOrder> HallMenuOrders { get; set; }
        public virtual DbSet<HallMenu> HallMenus { get; set; }
        public virtual DbSet<HallMenuSchedule> HallMenuSchedules { get; set; }
        public virtual DbSet<RestaurantCustomer> RestaurantCustomers { get; set; }
        public virtual DbSet<RestaurantPeriod> RestaurantPeriods { get; set; }
        public virtual DbSet<RestaurantReservation> RestaurantReservations { get; set; }
        public virtual DbSet<RestaurantSeat> RestaurantSeats { get; set; }
        public virtual DbSet<RestaurantStatus> RestaurantStatuses { get; set; }
        public virtual DbSet<RoomBooking> RoomBookings { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomStatusSetting> RoomStatusSettings { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<MemberLevel> MemberLevels { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<RoleAuthorization> RoleAuthorizations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarCartItem>()
                .Property(e => e.PickUpLongtitude)
                .IsUnicode(false);

            modelBuilder.Entity<CarCartItem>()
                .Property(e => e.PickUpLatitude)
                .IsUnicode(false);

            modelBuilder.Entity<CarCartItem>()
                .Property(e => e.DestinationLatitude)
                .IsUnicode(false);

            modelBuilder.Entity<CarCartItem>()
                .Property(e => e.DestinationLongtitude)
                .IsUnicode(false);

            modelBuilder.Entity<CarCartItem>()
                .Property(e => e.SubTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CarMaintenance>()
                .Property(e => e.Expense)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CarManagement>()
                .Property(e => e.PhotoPath)
                .IsFixedLength();

            modelBuilder.Entity<CarOrderItem>()
                .Property(e => e.SubTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CarOrder>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CarOrder>()
                .HasOptional(e => e.CarOrders1)
                .WithRequired(e => e.CarOrder1);

            modelBuilder.Entity<CarPrice>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HallItem>()
                .Property(e => e.Rent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HallItem>()
                .HasMany(e => e.HallLogs)
                .WithRequired(e => e.HallItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HallLog>()
                .HasMany(e => e.HallMenuSchedules)
                .WithRequired(e => e.HallLog)
                .HasForeignKey(e => e.HallLogsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HallMenuOrder>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HallMenuOrder>()
                .HasMany(e => e.HallMenuSchedules)
                .WithRequired(e => e.HallMenuOrder)
                .HasForeignKey(e => e.OrderMenuId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HallMenu>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HallMenu>()
                .HasMany(e => e.HallMenuOrders)
                .WithRequired(e => e.HallMenu)
                .HasForeignKey(e => e.MenuItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HallMenu>()
                .HasMany(e => e.HallMenuSchedules)
                .WithRequired(e => e.HallMenu)
                .HasForeignKey(e => e.MenuItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantCustomer>()
                .HasMany(e => e.RestaurantReservations)
                .WithRequired(e => e.RestaurantCustomer)
                .HasForeignKey(e => e.Customer_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantPeriod>()
                .HasMany(e => e.RestaurantReservations)
                .WithRequired(e => e.RestaurantPeriod)
                .HasForeignKey(e => e.Status_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantSeat>()
                .HasMany(e => e.RestaurantReservations)
                .WithRequired(e => e.RestaurantSeat)
                .HasForeignKey(e => e.Seat_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomBooking>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<RoomStatusSetting>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.BedType)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.BloodType)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IdentityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.IdentityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
