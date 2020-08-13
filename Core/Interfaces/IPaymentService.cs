using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.OrderAggregate;

namespace Core.Interfaces
{
    public interface IPaymentService
    {
         Task<CustomerBasket> CreatorOrUpdatePaymentIntent(string basketId);
         Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);

         Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);

    }
}