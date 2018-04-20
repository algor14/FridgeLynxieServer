namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodTag")]
    public partial class FoodTag
    {
        public FoodTag()
        {
            FoodItemFoodTag = new List<FoodItemFoodTag>();
        }

        [Key]
        public int FoodTagId { get; set; }

        [StringLength(255)]
        public string TagName { get; set; }

        public virtual ICollection<FoodItemFoodTag> FoodItemFoodTag { get; set; }
    }
}
