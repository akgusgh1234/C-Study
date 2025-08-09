using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height {  get; set; }
    }
    internal class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Profile[] artProfile =
           {
                new Profile(){Name="최표선",Height=176},
                new Profile(){Name="권태허",Height=213},
                new Profile(){Name="김규도",Height=168},
                new Profile(){Name="김종규",Height=389}
            };

            var heightStat = from profile in artProfile
                             group profile by profile.Height < 180 into g
                             select new
                             {
                                 Group = g.Key == true ? "180미만" : "180이상",
                                 Count=g.Count(),
                                 Max=g.Max(profile=>profile.Height),
                                 Min=g.Min(profile=>profile.Height),
                                 Average=g.Average(profile=>profile.Height)
                             };
            foreach(var stat in heightStat)
            {
                Console.Write("{0} - Count:{1}, Max:{2},", stat.Group, stat.Count, stat.Max);
                Console.WriteLine("Min:{0}, Average:{1}",stat.Min,stat.Average);
            }
        }
    }
}
*/