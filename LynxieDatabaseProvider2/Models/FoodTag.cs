namespace LynxieDatabaseProvider2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodTag")]
    public partial class FoodTag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodTag()
        {
            FoodItemFoodTag = new HashSet<FoodItemFoodTag>();
        }

        [Key]
        public int FoodTagId { get; set; }

        [StringLength(255)]
        public string TagName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodItemFoodTag> FoodItemFoodTag { get; set; }
    }
}
