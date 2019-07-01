using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessForm.Model
{
    public partial class Packet
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Service
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class User
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
    public partial class Role
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Customer
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
    public partial class OrderDetail
    {
        public override string ToString()
        {
            return OrderId.ToString();
        }
    }
    public partial class Order
    {
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
