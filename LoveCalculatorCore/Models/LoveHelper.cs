using LoveCalculatorCore.Interfaces;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveCalculatorCore.Models
{
    public class LoveHelper : ILoveHelper
    {
        public int CalculateLove(string boy, string girl)
        {
            const string love = "love";
            int loopCount = 0;
            //resultList = new List<List<int>>();
            string final = String.Join(String.Empty, boy.Trim(' ').ToLower(), love, girl.Trim(' ').ToLower());
            final = final.Replace(" ", string.Empty);
            int[] calArray = { };
            List<int> cal = new List<int>();
            foreach (var c in new HashSet<char>(final))
            {
                int count = final.Count(f => (f == c));
                cal.Add(count);
            }
            loopCount = (cal.Count % 2 == 0) ? (cal.Count) / 2 : ((cal.Count) / 2) + 1;
            for (int i = 0; i < loopCount; i++)
            {
                var newarr = Repeater(cal);
                //resultList.Add(newarr);
                if (newarr.Count == 2)
                {
                    string lastStr = (newarr[0].ToString() + newarr[1].ToString());
                    int test = int.Parse(lastStr);
                    if (test <= 120)
                    {
                        return test;
                    }
                    else if (test > 120 && lastStr.Length == 3)
                    {
                        var list = IntToArray(test);
                        var val = (list[0] + list[2]);

                        var returnValue =  int.Parse(val.ToString() +list[1].ToString());
                        return returnValue;
                    }
                    else
                    {
                        int result = newarr[0] + newarr[1];
                        return result;
                    }
                }
                else if (newarr.Count == 1)
                {
                    return newarr[0];
                }
                cal = newarr;
            }
            return 0;
        }

        public List<int> IntToArray(int num)
        {
            int digit = 0;
            List<int> list = new List<int>();
            while (num!=0)
            {
                digit = num % 10;
                list.Add(digit);
                num /= 10;
            }
            return list;
        }

        

        public List<int> Repeater(List<int> loveArray)
        {
            List<int> newLove = new List<int>();
            int sum = 0;
            while (loveArray.Count > 0)
            {
                if (loveArray.Count == 1)
                {
                    newLove.Add(loveArray[0]);
                    loveArray.RemoveAt(0);
                }
                else
                {
                    sum += loveArray.First() + loveArray.Last();
                    newLove.Add(sum);
                    sum = 0;
                    loveArray.RemoveAt(0);
                    loveArray.RemoveAt(loveArray.Count - 1);
                }
            }

            return newLove;
        }
    }

}
