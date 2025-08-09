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
        public int Height { get; set; }
    }
    internal class GroupBy
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

            var listProfile = from profile in artProfile
                              orderby profile.Height
                              group profile by profile.Height < 180 into g
                              select new { GroupKey = g.Key, Profile = g };
            foreach(var Group in listProfile)
            {
                Console.WriteLine($" - 180미만? {Group.GroupKey}");
                foreach(var Profile in Group.Profile) { Console.Write(Profile.Name); Console.WriteLine(Profile.Height); }
            }
        }
    }
}
*/