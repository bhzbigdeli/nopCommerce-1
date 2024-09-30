using Nop.Core.Domain.Orders;
using Nop.Services.Caching;
using Nop.Services.Events;

namespace Nop.Services.Orders.Caching;

/// <summary>
/// Represents a order cache event consumer
/// </summary>
public partial class OrderCacheEventConsumer : CacheEventConsumer<Order>
{
    protected readonly OrderSettings _orderSettings;

    public OrderCacheEventConsumer(OrderSettings orderSettings)
    {
        _orderSettings = orderSettings;
    }
}