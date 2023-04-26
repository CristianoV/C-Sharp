using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PerdingPayment
            };

            Console.WriteLine(order);
        }
    }
}