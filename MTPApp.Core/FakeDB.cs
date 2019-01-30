using System;
using System.Collections.Generic;
using System.Text;

namespace MTPApp.Core
{
    public static class FakeDB
    {
        public static int Id = 1;
        public static readonly List<Customer> Customers = new List<Customer>();
    }
}
