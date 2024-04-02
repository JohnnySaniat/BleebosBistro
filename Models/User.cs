using System.Collections.Generic;
namespace BleebosBistro.Models;
public class User
{
    public string Uid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool AuthenticationStatus { get; set; }
}
