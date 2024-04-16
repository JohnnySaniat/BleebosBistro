using System.Collections.Generic;
namespace BleebosBistro.Models;
public class User
{
    public int Id { get; set; }
    public string Uid { get; set; }
    public int Username { get; set; }
    public string IsColleague { get; set; }

    public string Image { get; set; }
}
