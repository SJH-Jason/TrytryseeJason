namespace Trytrysee.EDModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductMainCategory
    {
        [Key]
        [StringLength(50)]
        public string CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
