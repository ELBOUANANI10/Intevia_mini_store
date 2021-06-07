using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intelvia_store.Models
{
    public class Categorie
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CoverPhotoPath { get; set; }
        public ICollection<produit> Product { get; set; }
    }
}