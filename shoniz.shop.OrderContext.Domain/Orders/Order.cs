using shoniz.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace shoniz.shop.OrderContext.Domain.Orders
{
    public class Order : EntityBase, IAggregateRoot<Order>
    {
        public Order(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public decimal Tax { get; set; }

        public decimal ShippingCost { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> Cart { get; set; }

        public void AddOrderItem(Guid productId, int quantity, decimal price)
        {
            Cart.Add(new OrderItem
            {
                ProductId = productId,
                Quantity = quantity,
                Price = price
            });
            CaculateAmount();
        }

        private void CaculateAmount()
        {
            var subtotal = Cart.Sum(item => item.Price * item.Quantity);
            ShippingCost = subtotal < 100000 ? 0 : 10000;
            Tax = (ShippingCost * subtotal) * (decimal)0.13;
            TotalAmount = subtotal + Tax + ShippingCost;
        }

        public IEnumerable<Expression<Func<Order, object>>> GetAggregateExpressions()
        {
            yield return o => o.Cart;
        }
    }
}
