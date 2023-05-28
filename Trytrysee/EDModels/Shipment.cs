namespace Trytrysee.EDModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shipment
    {
        public int ShipmentID { get; set; }

        public int? OrderID { get; set; }

        public int? SellerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShipmentDate { get; set; }

        public virtual Order Order { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
