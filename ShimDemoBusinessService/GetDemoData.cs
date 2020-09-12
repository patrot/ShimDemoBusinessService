using ShimDemoDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShimDemoBusinessService
{
    public class GetDemoData
    {
        DataContext dataContext = new DataContext();
        DataLoader dataLoader = new DataLoader();
        public DemoData Get()
        {
            return dataLoader.LoadDemoData(dataContext);
        }
    }
}
