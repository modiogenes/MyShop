using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Produto")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Range(0, 1000)]
        [DisplayName("Preço")]
        public decimal Price { get; set; }

        [DisplayName("Categoria")]
        public string Category { get; set; }

        [DisplayName("Imagem")]
        public string Image { get; set; }

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
