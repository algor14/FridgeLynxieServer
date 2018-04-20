namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodItem")]
    public partial class FoodItem
    {
        public FoodItem()
        {
            FoodItemFoodTag = new List<FoodItemFoodTag>();
        }

        [Key]
        public int FoodItemId { get; set; }

        public int? FoodItemSecondaryId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchasedDate { get; set; }

        public int? ApproximateStorageTime { get; set; }

        public int? UnitId { get; set; }

        public float? Amount { get; set; }

        public int? IsFavorite { get; set; }

        public int? FoodStateId { get; set; }

        public int? NetworkId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual FoodUnit FoodUnit { get; set; }

        public virtual FoodState FoodState { get; set; }

        public virtual Network Network { get; set; }

        public virtual ICollection<FoodItemFoodTag> FoodItemFoodTag { get; set; }
    }
}
