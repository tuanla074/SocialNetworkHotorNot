using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotRater
{
    class Generator
    {
        public static void GetPeople()
        {
            var allItems = GetPeopleItems();
            allItems.ForEach(p => DataAccess.Insert(p));
            allItems = GetAdditional();
            allItems.ForEach(p => DataAccess.Insert(p));
        }

        private static List<People> GetPeopleItems()
        {
            var items = new List<People>(){
        new People() { Name = "Lee Luda", Thumbnail = "Assets/1.jpg", evolution1="Assets/58.jpg", evolution2="Assets/43.jpg", Score = 0, TotalTime = 0, Rating=0 },
        new People() { Name = "Cheng Xiao", Thumbnail = "Assets/2.jpg", evolution1="Assets/59.jpg",evolution2="Assets/60.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "SeolA", Thumbnail = "Assets/3.jpg",evolution1="Assets/61.jpg", evolution2="Assets/62.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Bona", Thumbnail = "Assets/4.jpg",evolution1="Assets/63.jpg",evolution2="Assets/64.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Mina Myoui", Thumbnail = "Assets/5.jpg",evolution1="Assets/65.jpg",evolution2="Assets/66.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Im Nayeon", Thumbnail = "Assets/6.jpg",evolution1="Assets/67.jpg",evolution2="Assets/68.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Nancy", Thumbnail = "Assets/7.jpg", evolution1="Assets/69.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Nayun", Thumbnail = "Assets/8.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Jane", Thumbnail = "Assets/9.jpg",evolution1="Assets/70.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Irene", Thumbnail = "Assets/10.jpg",evolution1="Assets/71.jpg",evolution2="Assets/72.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Seulgi", Thumbnail = "Assets/11.jpg",evolution1="Assets/73.jpg",evolution2="Assets/74.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Tyuzu", Thumbnail = "Assets/12.jpg",evolution1="Assets/75.jpg",evolution2="Assets/76.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Sana", Thumbnail = "Assets/13.jpg",evolution1="Assets/77.jpg",evolution2="Assets/78.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Eunwoo", Thumbnail = "Assets/14.jpg",evolution1="Assets/79.jpg",evolution2="Assets/80.jpg", Score = 0, TotalTime = 0, Rating = 0 }
        };
            return items;
        }

        private static List<People> GetAdditional()
        {
            var items = new List<People>(){
        new People() { Name = "Joy", Thumbnail = "Assets/15.jpg",evolution1="Assets/81.jpg", Score = 0, TotalTime = 0, Rating=0 },
        new People() { Name = "Yeri", Thumbnail = "Assets/16.jpg", evolution1="Assets/82.jpg",Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Wendy", Thumbnail = "Assets/17.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Kim Jisoo", Thumbnail = "Assets/18.jpg",evolution1="Assets/83.jpg",evolution2="Assets/84.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Jennie Kim", Thumbnail = "Assets/19.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Rose", Thumbnail = "Assets/20.jpg",evolution1="Assets/85.jpg",evolution2="Assets/86.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Lisa", Thumbnail = "Assets/21.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Dahuyn", Thumbnail = "Assets/22.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Chaeyoung", Thumbnail = "Assets/23.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Jeongyeon", Thumbnail = "Assets/24.jpg",evolution1="Assets/87.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Jihyo", Thumbnail = "Assets/25.jpg",evolution1="Assets/88.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Momo", Thumbnail = "Assets/26.jpg",evolution1="Assets/89.jpg",evolution2="Assets/90.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Daisy Yoo", Thumbnail = "Assets/27.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Lee Ahin", Thumbnail = "Assets/28.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Kim Taeha", Thumbnail = "Assets/29.jpg", Score = 0, TotalTime = 0, Rating=0 },
        new People() { Name = "YeanWoo", Thumbnail = "Assets/30.jpg",evolution1="Assets/91.jpg",evolution2="Assets/92.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "JooE", Thumbnail = "Assets/31.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Lee Hyebin", Thumbnail = "Assets/32.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "EXY", Thumbnail = "Assets/33.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yoo Yeon-jung", Thumbnail = "Assets/34.jpg", evolution1="Assets/93.jpg",evolution2="Assets/94.jpg",Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Dayoung", Thumbnail = "Assets/35.jpg",evolution1="Assets/95.jpg",evolution2="Assets/96.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Xuan Yi", Thumbnail = "Assets/36.jpg",evolution1="Assets/97.jpg", evolution2="Assets/98.jpg",Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yeoreum", Thumbnail = "Assets/37.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yang Soobin", Thumbnail = "Assets/38.jpg",evolution1="Assets/99.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Mei Qi", Thumbnail = "Assets/39.jpg",evolution1="Assets/100.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Eunseo", Thumbnail = "Assets/40.jpg",evolution1="Assets/101.jpg", evolution2="Assets/102.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Dawon", Thumbnail = "Assets/41.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Lim Na-young", Thumbnail = "Assets/42.jpg",evolution1="Assets/103.jpg", evolution2="Assets/104.jpg",Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yuju", Thumbnail = "Assets/52.jpg", Score = 0, TotalTime = 0, Rating=0 },
        new People() { Name = "Eunha", Thumbnail = "Assets/53.jpg",evolution1="Assets/105.jpg", evolution2="Assets/106.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "SinB", Thumbnail = "Assets/54.jpg",evolution1="Assets/107.jpg", evolution2="Assets/108.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yerin", Thumbnail = "Assets/55.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Sowon", Thumbnail = "Assets/56.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "UmJi", Thumbnail = "Assets/57.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Park Si-yeon", Thumbnail = "Assets/44.jpg", Score = 0, TotalTime = 0, Rating=0 },
        new People() { Name = "Rena", Thumbnail = "Assets/45.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Kyla Massie", Thumbnail = "Assets/46.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Yehana", Thumbnail = "Assets/47.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Bae Seong-yeon", Thumbnail = "Assets/48.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Kim Minkyeong", Thumbnail = "Assets/49.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "Kyulkyung", Thumbnail = "Assets/50.jpg", Score = 0, TotalTime = 0, Rating = 0 },
        new People() { Name = "YUHA", Thumbnail = "Assets/51.jpg", Score = 0, TotalTime = 0, Rating = 0 }
        };
            return items;
        }
    }
}
