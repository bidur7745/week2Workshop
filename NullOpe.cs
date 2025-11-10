using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    internal class NullOpe
    {
        string username = null;
        public string checknull() {
            return username == null ? "user name is null" : username;

        }
        public string checknullUsingCoalescingOperator()
        {
            return username ?? "GuestUser";
        }

        public void assignDefaultUsername()
        {
            username ??= "DefaultUser";
            Console.WriteLine(username);
        }
    }
}
