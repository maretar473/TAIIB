using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    internal interface IProduct
    {
        IEnumerable<ProductResDTO> GetProducts(int page, int pageSize, string nameFilter, bool? isActiveFilter, string sortBy, bool isSortAscending);
        ProductResDTO AddProduct(ProductReqDTO productDTO);
        ProductResDTO UpdateProduct(int productId, ProductReqDTO productDTO);
        void DeleteProduct(int productId);
        void ActivateProduct(int productId);
    }
}
