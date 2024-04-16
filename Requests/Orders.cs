using Microsoft.EntityFrameworkCore;
using BleebosBistro.Models;
using System.Data.Common;
using BleebosBistro;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BleebosBistro.Requests
{
    public class Orders
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/orders", (BleebosBistroDbContext db) =>
            {
                return db.Orders.Include(o => o.Items).ToList();
            });

            app.MapDelete("/orders/{id}", (int id, BleebosBistroDbContext db) =>
            {
                var order = db.Orders.Find(id);
                if (order == null)
                {
                    return Results.NotFound();
                }

                db.Orders.Remove(order);
                db.SaveChanges();

                return Results.NoContent();
            });

            app.MapPost("/orders/add-item", async (OrderItemDTO orderItemDto, BleebosBistroDbContext db) =>
            {
                var order = await db.Orders.FindAsync(orderItemDto.OrderId);
                if (order == null)
                {
                    return Results.NotFound();
                }

                var item = await db.Items.FindAsync(orderItemDto.ItemId);
                if (item == null)
                {
                    return Results.NotFound();
                }

                if (order.Items == null)
                {
                    order.Items = new List<Item>();
                }

                order.Items.Add(item);
                await db.SaveChangesAsync();

                return Results.Created($"/orders/{orderItemDto.OrderId}/items/{orderItemDto.ItemId}", item);
            });

            app.MapDelete("orders/{orderId}/items/{itemId}", (BleebosBistroDbContext db, int orderId, int itemId) =>
            {
                var order = db.Orders.Include(o => o.Items).FirstOrDefault(o => o.Id == orderId);

                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                var productToRemove = order.Items.FirstOrDefault(p => p.Id == itemId);

                if (productToRemove == null)
                {
                    return Results.NotFound("Product not found in cart.");
                }

                order.Items.Remove(productToRemove);

                db.SaveChanges();

                return Results.Ok("Item removed from the cart.");
            });

            app.MapPatch("/order/checkout/{id}", async (int id, string paymentType, decimal tip, BleebosBistroDbContext db) =>
            {
                var existingOrder = await db.Orders.FindAsync(id);
                if (existingOrder == null)
                {
                    return Results.NotFound("Order not found.");
                }

                existingOrder.PaymentType = paymentType;
                existingOrder.Tip = tip;

                existingOrder.IsClosed = true;
                existingOrder.Date = DateTime.Now;

                db.Entry(existingOrder).State = EntityState.Modified;
                await db.SaveChangesAsync();

                return Results.Ok("Order details updated successfully.");
            });

            app.MapPost("/orders", async (Order newOrder, BleebosBistroDbContext db) =>
            {
                if (newOrder.Image == null)
                {
                    newOrder.Image = "default_image_url";
                }

                db.Orders.Add(newOrder);
                await db.SaveChangesAsync();

                return Results.Created($"/orders/{newOrder.Id}", newOrder);
            });

            app.MapGet("/orders/{id}/items", (BleebosBistroDbContext db, int id) =>
            {
                var item = db.Orders.Include(p => p.Items).FirstOrDefault(p => p.Id == id);
                return item;
            });

            app.MapGet("/orders/{id}", (int id, BleebosBistroDbContext db) =>
            {
                var order = db.Orders.Find(id);
                if (order == null)
                {
                    return Results.NotFound();
                }

                return Results.Json(order);
            });


        }
    }
}


    