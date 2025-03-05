using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class OrderExtensions
    {
        public static IQueryable<OrderDto> ProjectToDto(this IQueryable<Order> query)
        {
            return query.Select(order => new OrderDto
            {
                Id = order.Id,
                BuyerEmail = order.BuyerEmail,
                Orderdate = order.Orderdate,
                ShippingAddress = order.ShippingAddress,
                PaymentSummary = order.PaymentSummary,
                DeliveryFee = order.DeliveryFee,
                Subtotal = order.Subtotal,
                OrderStatus = order.OrderStatus.ToString(),
                Total = order.GetTotal(),
                OrderItems = order.OrderItems.Select(items => new OrderItemDto
                {
                    ProductId = items.ItemOrdered.ProductId,
                    Name = items.ItemOrdered.Name,
                    PictureUrl = items.ItemOrdered.PictureUrl,
                    Price = items.Price,
                    Quantity = items.Quantity
                }).ToList()
            }).AsNoTracking();
        }
        public static OrderDto ToDto(this Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                BuyerEmail = order.BuyerEmail,
                Orderdate = order.Orderdate,
                ShippingAddress = order.ShippingAddress,
                PaymentSummary = order.PaymentSummary,
                DeliveryFee = order.DeliveryFee,
                Subtotal = order.Subtotal,
                OrderStatus = order.OrderStatus.ToString(),
                Total = order.GetTotal(),
                OrderItems = order.OrderItems.Select(items => new OrderItemDto
                {
                    ProductId = items.ItemOrdered.ProductId,
                    Name = items.ItemOrdered.Name,
                    PictureUrl = items.ItemOrdered.PictureUrl,
                    Price = items.Price,
                    Quantity = items.Quantity
                }).ToList()
            };
        }
    }
}