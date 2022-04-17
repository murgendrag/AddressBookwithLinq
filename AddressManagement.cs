using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookWithLINQ
{
    public class AddressManagement
    {
        public void RetrieveByCity(List<AddressReview> review)
        {
            var RecordData = review.GroupBy(x => x.City).Select(x => new { City ="Mumbai", Count = x.Count() });

            foreach (var list in RecordData)
            {
                Console.WriteLine(list.City + "----- " + list.Count);
            }
        }
        public void RetrieveByState(List<AddressReview> review)
        {
            var RecordData = review.GroupBy(x => x.State).Select(x => new { State = "Karnataka", Count = x.Count() });

            foreach (var list in RecordData)
            {
                Console.WriteLine(list.State + "----- " + list.Count);
            }
        }
    }
}
