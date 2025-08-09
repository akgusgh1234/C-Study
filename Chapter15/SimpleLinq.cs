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
    internal class SimpleLinq
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
            var profiles = from profile in artProfile
                           where profile.Height < 180
                           orderby profile.Height
                           select new
                           {
                               Name=profile.Name,
                               IncHeight=profile.Height*0.393,
                           };
            foreach (var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.IncHeight}");
            }
        }
    }
}
*/