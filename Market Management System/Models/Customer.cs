using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem.Models
{
    public class Customer : Person
    {   
        public static string Role { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Passsword { get; set; }
        public int AccountStatus { get; set; }
    }
}
