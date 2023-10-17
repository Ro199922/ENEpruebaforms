using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ENE.model
{
    public class Employee
    {
        public String Name { get; set; }
        public String UserEmail { get; set; }
        public String Password { get; set; }
        public String Permissions { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public string RUT { get; set; }
        public int HourValue { get; set; }
        public int ExtraValue { get; set; }
        public int GrossSalary { get; set; }
        public int NetSalary { get; set; }
        public int DiscountAFP { get; set; }
        public int DiscountHealth { get; set; }

        public string AFPName { get; set; }
        public string HealthName { get; set; }

        public virtual AFP AFP { get; set; }

        public virtual Health Health { get; set; }

        public Employee(string name, string userEmail, string password, string permissions, string address, 
            string phone,string rut, int hourValue, int extraValue, int grossSalary, int netSalary, 
            int discountAFP, int discountHealth, string afpName, string healthName)
        {
            Name = name;
            UserEmail = userEmail;
            Password = password;
            Permissions = permissions;
            Address = address;
            Phone = phone;
            RUT = rut;
            HourValue = hourValue;
            ExtraValue = extraValue;
            GrossSalary = grossSalary;
            NetSalary = netSalary;
            DiscountAFP = discountAFP;
            DiscountHealth = discountHealth;
            AFPName = afpName;
            HealthName = healthName;
        }
    }
}
