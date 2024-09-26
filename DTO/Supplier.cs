using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        private string companyName;
        private string phoneNumber;
        private string address;

        public Supplier() { }

        /*public Supplier(DataRow row)
        {
            this.companyName = row["CompanyName"].ToString();
            this.phoneNumber = row["Address"].ToString();
            this.address = row["Address"].ToString();
        }*/

        public string CompanyName { get => companyName; set => companyName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
    }
}
