using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubActionsTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            throw new Exception("nooo");
        }
    }
}
