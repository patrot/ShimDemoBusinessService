using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShimDemoDataAccessLayer
{
    public class DataContext
    { 
        public DataContext()
        {
            UserName = "jim";
        }

        public string UserName { get; private set; }
    }
}
