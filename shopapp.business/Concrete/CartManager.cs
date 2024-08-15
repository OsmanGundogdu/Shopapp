using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetCartByUserId(userId);
            if (cart != null)
            {
                // eklenmek isteyen ürün sepette var mı? (güncelleme)
                var index = cart.CartItems.FindIndex(i => i.ProductId == productId);

                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem(){
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                } else {
                    cart.CartItems[index].Quantity += quantity;
                }

                _unitOfWork.Carts.Update(cart);
                _unitOfWork.Save();
                // eklenmek isteyen ürün sepette var ve yeni kayıt oluştur. (kayıt ekleme)
            }
        }

        public void ClearCart(int cartId)
        {
            _unitOfWork.Carts.ClearCart(cartId);
            _unitOfWork.Save();
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetCartByUserId(userId);
            if (cart != null)
            {
                _unitOfWork.Carts.DeleteFromCart(cart.Id, productId);
                _unitOfWork.Save();
            }
        }

        public Cart GetCartByUserId(string userId)
        {
            return _unitOfWork.Carts.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _unitOfWork.Carts.Create(new Cart(){UserId = userId});
            _unitOfWork.Save();

        }
    }
}