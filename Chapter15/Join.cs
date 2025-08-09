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
    class Product
    {
        public string Title {  get; set; }
        public string Star {  get; set; }
    }
    internal class Join
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
            Product[] artProduct =
           {
                new Product(){Star="최표선",Title="성냥팔이소녀의재림"},
                new Product(){Star="권태허",Title="걸캅스"},
                new Product(){Star="김종규",Title="해피투게더"},
                new Product(){Star="최표선",Title="클레멘타인"}
            };
            var listProfile =
                from profile in artProfile
                join product in artProduct on profile.Name equals product.Star
                select new
                {
                    Name=profile.Name,
                    Work=product.Title,
                    Height=profile.Height,
                };
            Console.WriteLine("--- 내부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm",profile.Name,profile.Work,profile.Height);
            }

            listProfile = from profile in artProfile
                          join product in artProduct on profile.Name equals product.Star into ps
                          from product in ps.DefaultIfEmpty(new Product() { Title = "그런거없음" })
                          select new
                          {
                              Name = profile.Name,
                              Work = product.Title,
                              Height = profile.Height,
                          };
            Console.WriteLine();
            Console.WriteLine("--- 외부 조인 결과 ---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}", profile.Name, profile.Work, profile.Height);
            }

        }
    }
}
*/