using System.Collections.Generic;
namespace BleebosBistro.Models;
public class Order
{
    public string OrderId { get; set; }
    public bool IsOpen { get; set; }
    public string CustomerName { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }
    public bool IsOnline { get; set; }
    public string Uid { get; set; }
    public int Subtotal { get; set; }
    public int Tip { get; set; }
    public int Total { get; set; }
    public DateTime Date { get; set; }
}
