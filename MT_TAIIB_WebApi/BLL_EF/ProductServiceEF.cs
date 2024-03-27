using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.DTO;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using MT_TAIIB_WebApi.Model;

namespace BLL_EF
{
    public class ProductServiceEF : IProduct
    {
        private WebshopContext _context = new WebshopContext();
        
        public void ActivateProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if(product == null)
            {
                throw new ArgumentException("Niez znaleziono produktu");
            }
            if(product.IsActive)
            {
                throw new ArgumentException("Produkt jest juz aktywny");
            }
            product.IsActive= true;
            _context.SaveChanges();
        }
        
        public ProductResDTO AddProduct(ProductReqDTO productDTO)
        {
            if (productDTO.Price <= 0)
            {
                throw new ArgumentException("Cena musi byc wieksza od 0");
            }

            var product = new Product
            {
                Name = productDTO.Name,
                Price = productDTO.Price,
                Image = productDTO.Image,
                IsActive = true
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return new ProductResDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Image = product.Image,
                IsActive = product.IsActive
            };
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products
                .Include(p => p.OrderPosition)
                .Include(p => p.BasketPositions)
                .FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                throw new ArgumentException("Nie znaleziono produktu");
            }

            if (product.OrderPosition.Any() || product.BasketPositions.Any())
            {
                if (product.OrderPosition.Any())
                {
                    product.IsActive = false;
                }
                else
                {
                    throw new InvalidOperationException("Nie mozna usunac produktu bez przydzielonego miejsca");
                }
            }
            else
            {
                _context.Products.Remove(product);
            }

            _context.SaveChanges();
        }

        public IEnumerable<ProductResDTO> GetProducts(int page, int pageSize, string nameFilter, bool? isActiveFilter, string sortBy, bool isSortAscending)
        {
            throw new NotImplementedException();
        }

        public ProductResDTO UpdateProduct(int productId, ProductReqDTO productDTO)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
            {
                throw new ArgumentException("Nie znaleziono produktu");
            }

            if (productDTO.Price <= 0)
            {
                throw new ArgumentException("Cena musi byc wieksza od 0");
            }

            product.Name = productDTO.Name;
            product.Price = productDTO.Price;
            product.Image = productDTO.Image;

            _context.SaveChanges();

            return new ProductResDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Image = product.Image,
                IsActive = product.IsActive
            };
        }
    }
}