using System.Collections.Generic;
namespace BleebosBistro.Models;
public class Order
{
    public int Id { get; set; }
    public bool IsClosed { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public decimal? Subtotal { get; set; }

    public string? PaymentType { get; set; }
    public decimal? Tip { get; set; }
    public decimal? Total { get; set; }
    public DateTime? Date { get; set; }

    public string Image { get; set; }

    public ICollection<Item> Items { get; set; }

    public decimal? CalculateSubtotal
    {
        get
        {
            if (Items != null && Items.Any())
            {
                decimal? subtotal = Items.Sum(item => item.Price);
                return subtotal;
            }
            else
            {
                return null;
            }
        }
    }

    public decimal? CalculateTotalRevenue
    {
        get
        {
            decimal? subtotal = CalculateSubtotal;
            if (subtotal.HasValue && Tip.HasValue)
            {
                return subtotal + Tip;
            }
            else if (subtotal.HasValue)
            {
                return subtotal;
            }
            else if (Tip.HasValue)
            {
                return Tip;
            }
            else
            {
                return null;
            }
        }
    }
}



