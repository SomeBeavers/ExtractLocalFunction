//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ResharperProb1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            const string existingEmailDetailIds = "1,2,3";

//            var existingEmailDetailIdsLong = new List<long>();

//            existingEmailDetailIdsLong = ExistingEmailDetailIdsLong(existingEmailDetailIds);

//            Console.WriteLine(existingEmailDetailIdsLong);
//        }

//        private static List<T> ExistingEmailDetailIdsLong(string existingEmailDetailIds)
//        {
//            List<T> existingEmailDetailIdsLong;                           //  SHOULD AUTO ADD = null or = new List..
//            if (!String.IsNullOrEmpty(existingEmailDetailIds))
//            {
//                existingEmailDetailIdsLong = existingEmailDetailIds.Replace("[", "").Replace("]", "").
//                    Split(',')
//                    .Where(rec => rec.Length > 0).
//                    Select(rec => Convert.ToInt32(rec)).
//                    Select(dummy => (long)dummy).ToList();
//            }
//            return existingEmailDetailIdsLong;
//        }
//    }
//}