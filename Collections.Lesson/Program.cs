using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LIST
            List<string> list = new List<string>() { "Bruno", "Mario" };
            list.Add("");
            list.AddRange(new string[] { "bruno", "Mario" });
            list.Remove("bruno");
            list.RemoveAll(x =>
            {
                if (x.StartsWith("b"))
                    return true;
                else
                    return false;

            });
            list.RemoveAt(list.Count - 1);
            #endregion
            #region Dictionary

            Dictionary<int, string> dict = new Dictionary<int, string>()
            {

                {1,"MI,BO, VE" },

            };
            var italia = dict[1];

            if (dict.ContainsKey(1))
            {
                foreach (var item in italia) ;

            }
            string result;
            if (dict.TryGetValue(1, out result))
            {

            }

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key:{0}, Value:{1}",
                    dict.ElementAt(i).Key,
                    dict.ElementAt(i).Value);
            }
            dict.Remove(1);// _>

            dict.Clear();
            #endregion
        }
    }
}
