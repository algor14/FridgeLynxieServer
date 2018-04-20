namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodUnit")]
    public partial class FoodUnit
    {
        public FoodUnit()
        {
            FoodItem = new List<FoodItem>();
        }

        [Key]
        public int FoodUnitId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(25)]
        public string ShortenedName { get; set; }

        public virtual ICollection<FoodItem> FoodItem { get; set; }
    }
}
