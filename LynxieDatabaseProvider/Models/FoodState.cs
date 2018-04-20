namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodState")]
    public partial class FoodState
    {
        public FoodState()
        {
            FoodItem = new List<FoodItem>();
        }

        [Key]
        public int FoodStateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        public virtual ICollection<FoodItem> FoodItem { get; set; }
    }
}
