using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intelvia_store.Models
{
    public class produit
    {
        public int ProductID { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double UnitPrice { get; set; }
        public ICollection<photo> Galery { get; set; }
        public int CreatedByUserID { get; set; }
        [ForeignKey("Category")]
        public int IncludeInCategoryID { get; set; }
    }
}