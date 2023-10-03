using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    internal class Auto
    {
        RatingEngine engine=new RatingEngine();
        public void showAuto(Policy policy, decimal Rating) {
            Print.TextoPolicy("Auto");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    Rating = 1000m;
                }
                Rating = 900m;
            }
        }
    }
}
