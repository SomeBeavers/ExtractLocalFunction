using System.Collections.Generic;
using System.Linq;

namespace Framework_Lib
{
    public class Class1
    {
        public int Test(List<int> list)
        {
            int t = 0;

            if (list.Contains(t))
            {
                return t;
            }

            list.Count(x =>
            {
                x.Equals(t);
                return false;
            });

            return 0;
        }
    }
}
