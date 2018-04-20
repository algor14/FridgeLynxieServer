namespace LynxieDatabaseProvider2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodUnit")]
    public partial class FoodUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodUnit()
        {
            FoodItem = new HashSet<FoodItem>();
        }

        [Key]
        public int FoodUnitId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(25)]
        public string ShortenedName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodItem> FoodItem { get; set; }
    }
}
