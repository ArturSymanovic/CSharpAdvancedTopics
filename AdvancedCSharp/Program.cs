using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime? date1 = null;
            //Nullable<DateTime> date = null;

            //Console.WriteLine("GetValueOrDefault() : " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue : " + date.HasValue);
            ////Error when null
            //Console.WriteLine("Value" + date.Value);            

            DateTime? date = new DateTime(2014, 1, 1);

            //Error
            //DateTime date2 = date;
            DateTime date2 = date.GetValueOrDefault();

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());

            //-----------------------------------------------------

            DateTime? dat = null;
            DateTime dat2;

            if (dat != null)
                dat2 = date.GetValueOrDefault();
            else
                dat2 = DateTime.Today;

            //Null coalescing operator(same as above code)
            dat2 = dat ?? DateTime.Today;
            dat2 = (dat != null) ? dat.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(dat2);

        }
    }
}
