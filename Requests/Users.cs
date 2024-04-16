using Microsoft.EntityFrameworkCore;
using BleebosBistro.Models;
using System.Data.Common;
using BleebosBistro;

namespace BleebosBistro.Requests
{
        public class Users
        {
            public static void Map(WebApplication app)
            {
            app.MapGet("/checkuser/{uid}", (BleebosBistroDbContext db, string uid) =>
            {
                var authUser = db.Users.Where(u => u.Uid == uid).FirstOrDefault();
                if (authUser == null)
                {
                    return Results.StatusCode(204);
                }
                return Results.Ok(authUser);
            });
            app.MapGet("/users", (BleebosBistroDbContext db) =>
            {
                return db.Users.ToList();
            });

            app.MapGet("/users/{uid}", (BleebosBistroDbContext db, string uid) =>
            {
                var authenticatedUser = db.Users.Where(u => u.Uid == uid).ToList();
                if (authenticatedUser == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(authenticatedUser);
            });

            app.MapPost("/users", (BleebosBistroDbContext db, User userInfo) =>
            {
                db.Users.Add(userInfo);
                db.SaveChanges();
                return Results.Created($"/users/{userInfo.Id}", userInfo);
            });

        }
        }
    };
