using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShimDemoDataAccessLayer
{
    public class DataLoader
    {
        public DemoData LoadDemoData(DataContext dataContext)
        {
            return new DemoData();
        }
    }
}
