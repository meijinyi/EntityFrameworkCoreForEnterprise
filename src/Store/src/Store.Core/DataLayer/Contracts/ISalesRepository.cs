using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.DataLayer.DataContracts;
using Store.Core.EntityLayer.Dbo;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Contracts
{
    public interface ISalesRepository : IRepository
    {
        IQueryable<Customer> GetCustomers();

        Task<Customer> GetCustomerAsync(Customer entity);

        Task<Int32> AddCustomerAsync(Customer entity);

        Task<Int32> UpdateCustomerAsync(Customer changes);

        Task<Int32> DeleteCustomerAsync(Customer entity);

        IQueryable<OrderInfo> GetOrders(Int16? currencyID = null, Int32? customerID = null, Int32? employeeID = null, Int16? orderStatusID = null, Guid? paymentMethodID = null, Int32? shipperID = null);

        Task<Order> GetOrderAsync(Order entity);

        Task<Int32> AddOrderAsync(Order entity);

        Task<Int32> UpdateOrderAsync(Order changes);

        Task<Int32> DeleteOrderAsync(Order entity);

        Task<OrderDetail> GetOrderDetailAsync(OrderDetail entity);

        Task<Int32> AddOrderDetailAsync(OrderDetail entity);

        Task<Int32> UpdateOrderDetailAsync(OrderDetail changes);

        Task<Int32> DeleteOrderDetailAsync(OrderDetail entity);

        IQueryable<Shipper> GetShippers();

        Task<Shipper> GetShipperAsync(Shipper entity);

        Task<Int32> AddShipperAsync(Shipper entity);

        Task<Int32> UpdateShipperAsync(Shipper changes);

        Task<Int32> DeleteShipperAsync(Shipper entity);

        IQueryable<OrderStatus> GetOrderStatus();

        Task<OrderStatus> GetOrderStatusAsync(OrderStatus entity);

        Task<Int32> AddOrderStatusAsync(OrderStatus entity);

        Task<Int32> UpdateOrderStatusAsync(OrderStatus changes);

        Task<Int32> RemoveOrderStatusAsync(OrderStatus entity);

        IQueryable<Currency> GetCurrencies();

        IQueryable<PaymentMethod> GetPaymentMethods();
    }
}
