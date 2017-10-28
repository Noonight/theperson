using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson.common.debug {
    static class Log {
        public static void d(string message) {
            Console.WriteLine("DEBUG: {0}", message);
        }
    }
}
