namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodItemFoodTag")]
    public partial class FoodItemFoodTag
    {
        public int Id { get; set; }

        public int? FoodTagId { get; set; }

        public int? FoodItemId { get; set; }

        public virtual FoodItem FoodItem { get; set; }

        public virtual FoodTag FoodTag { get; set; }
    }
}
