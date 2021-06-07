using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intelvia_store.Models
{
    public class photo
    {
        public int PhotoID { get; set; }
        public string PhotoPath { get; set; }
        [ForeignKey("produit")]
        public int OfTheProductID { get; set; }
    }
}