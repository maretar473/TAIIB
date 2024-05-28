using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    public interface IProduct
    {
        ProductDTO GetProduct(int id);
        ProductDTO GetProduct(int page, int pageSize);
        ProductDTO GetProduct(string name, bool? isActive);
        ProductDTO GetProduct(string sortBy);
        ProductDTO AddProduct(ProductDTO productDTO);
        ProductDTO UpdateProduct(int productId, ProductDTO productDTO);
        void DeleteProduct(int productId);
        void ActivateProduct(int productId);
    }
}
