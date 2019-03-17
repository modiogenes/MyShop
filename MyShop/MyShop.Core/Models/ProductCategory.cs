using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory
    {
        public string Id { get; set; }

        [DisplayName("Categoria")]
        public string Category { get; set; }

        public ProductCategory() {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
