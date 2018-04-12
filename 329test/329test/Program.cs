using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _329test
{
    class Program
    {
        static void Main(string[] args)
        {
            //all resourse
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] bt = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            //count
            double boy = 0;
            double girl = 0;

            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "男")
                {
                    boy++;
                }
                if (gender[i] == "女")
                {
                    girl++;
                }
            }

            double classgender = gender.Length;
            double boysrate = (boy / classgender) * 100;
            double girlssrate = (girl / classgender) * 100;


            double bloodA = 0;
            double bloodB = 0;
            double bloodO = 0;
            double ELSE = 0;

            for (int i = 0; i < bt.Length; i++)
            {
                if (bt[i] == "A")
                {
                    bloodA++;
                }
                if (bt[i] == "B")
                {
                    bloodB++;
                }
                if (bt[i] == "O")
                {
                    bloodO++;
                }
                else
                {
                    ELSE++;
                }

            }

            double countBoy = 0;
            double boyTotalHeight = 0;


            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "男")
                {
                    if (height[i] < 200 && height[i] > 130)
                    {
                        boyTotalHeight += height[i];
                        countBoy += 1;
                    }

                }
            }

            double girlTotalHeight = 0;


            double countGirl = 0;
            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "女")
                {
                    if (height[i] < 200 && height[i] > 130)
                    {
                        girlTotalHeight += height[i];
                        countGirl += 1;
                    }

                }
            }



            double total = bt.Length;
            double chanceA = 100 * (bloodA / total);
            double chanceB = 100 * (bloodB / total);
            double chanceO = 100 * (bloodO / total);

            double name2 = 0;
            string name3 = " ";

            for (int i = 0; i < bt.Length; i++)
            {
                if (bt[i] == "O")
                {
                    if (zodiac[i] == "天蠍")
                    {
                        name2 += 1;
                        name3 += name[i] + " ";
                    }
                }
            }

            double highest = -999;
            double shortest = 999;

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > highest && height[i] < 200 && height[i] > 100)
                {
                    highest = height[i];
                }
                if (height[i] < shortest && height[i] < 200 && height[i] > 100)
                {
                    shortest = height[i];
                }
            }

            // show resualt
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;


            Console.WriteLine("  "+"1.男生人數百分比為" + boysrate + "%");


            // to show girlsrate
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("2.女生人數百分比為" + girlssrate + "%");

            // show the average
            for (int i = 0; i < 100 / 2; i++)
            {
                if (i < boysrate / 2)//to make picture shoreter
                    Console.BackgroundColor = ConsoleColor.Yellow;
                else
                    Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");//to show the pirture
            }

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            //
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;

            //
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("3.A型人數為:" + bloodA + "占:" + chanceA + "%");
            //
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  B型人數為:" + bloodB + "占:" + chanceB + "%");
            //
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  O型人數為:" + bloodO + "占:" + chanceO + "%");
            //
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" ");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  其他血型人數為:" + ELSE + "占:" + (100 - (chanceA + chanceB + chanceO)));
            // show average
            for (int i = 0; i < 100/4 ; i++)
            {
                if (i < chanceA/4 )//to make picture shoreter
                    Console.BackgroundColor = ConsoleColor.Blue;

                else
                    Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write(" ");//to show the pirture
            }
            for (int i = 0; i < 100 / 4; i++)
            {
                if (i < chanceO / 4)//to make picture shoreter
                    Console.BackgroundColor = ConsoleColor.Green;

                else
                    Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(" ");//to show the pirture
            }
            // make a blank
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;

            //
            Console.WriteLine("4.男生身高平均為:" + boyTotalHeight / countBoy);
            Console.WriteLine("5.女生身高平均為:" + girlTotalHeight / countGirl);
            Console.WriteLine("6.全部身高平均為:" + (boyTotalHeight + girlTotalHeight) / (countBoy + countGirl));
            Console.WriteLine("7.天蠍座O型的人為: " + name3);

            // make a blank
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            //
            Console.WriteLine("身高最矮為:" + shortest);
            Console.WriteLine("身高最高為:" + highest);
            Console.ReadLine();

        }
    }
}
        
    

