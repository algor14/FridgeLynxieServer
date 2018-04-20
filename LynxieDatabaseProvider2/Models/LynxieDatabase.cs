namespace LynxieDatabaseProvider2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LynxieDatabase : DbContext
    {
        public LynxieDatabase()
            : base("name=LynxieDatabase")
        {
        }

        public virtual DbSet<FoodItem> FoodItem { get; set; }
        public virtual DbSet<FoodItemFoodTag> FoodItemFoodTag { get; set; }
        public virtual DbSet<FoodState> FoodState { get; set; }
        public virtual DbSet<FoodTag> FoodTag { get; set; }
        public virtual DbSet<FoodUnit> FoodUnit { get; set; }
        public virtual DbSet<Network> Network { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FoodState>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodTag>()
                .Property(e => e.TagName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodUnit>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodUnit>()
                .Property(e => e.ShortenedName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodUnit>()
                .HasMany(e => e.FoodItem)
                .WithOptional(e => e.FoodUnit)
                .HasForeignKey(e => e.UnitId);

            modelBuilder.Entity<Network>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Network>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
