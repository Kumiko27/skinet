using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdWithItems : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdWithItems(string paymentIntentId) 
        : base( o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}