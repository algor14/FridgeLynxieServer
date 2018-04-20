namespace LynxieDatabaseProvider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Network")]
    public partial class Network
    {
        public Network()
        {
            FoodItem = new List<FoodItem>();
            User = new List<User>();
        }

        [Key]
        public int NetworkId { get; set; }

        public int? CreatorUserId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public virtual ICollection<FoodItem> FoodItem { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
