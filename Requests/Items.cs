using Microsoft.EntityFrameworkCore;
using BleebosBistro.Models;
using System.Data.Common;
using BleebosBistro;

namespace BleebosBistro.Requests
{
        public class Items
        {
            public static void Map(WebApplication app)
            {

            app.MapGet("/items", (BleebosBistroDbContext db) =>
            {
                return db.Items.ToList();
            });

            app.MapGet("items/search-items", (BleebosBistroDbContext db, string searchValue) =>
            {
                var searchResults = db.Items
                    .Where(item =>
                        item.Name.ToLower().Contains(searchValue.ToLower()) ||
                        item.Description.ToLower().Contains(searchValue.ToLower()) ||
                        item.ItemType.ToLower().Contains(searchValue.ToLower()) ||
                        item.Price.ToString().Contains(searchValue)
                    )
                    .ToList();

                return searchResults.Any() ? Results.Ok(searchResults) : Results.StatusCode(204);
            });

        }
        }
    }


