namespace LynxieDatabaseProvider2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? NetworkId { get; set; }

        public virtual Network Network { get; set; }
    }
}
