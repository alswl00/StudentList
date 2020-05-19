using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string major;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "ham", major = "정보컴퓨터" });
            list.Add(new Teacher() { name = "park", major = "수학" });
            list.Add(new Teacher() { name = "min", major = "정보컴퓨터" });
            list.Add(new Teacher() { name = "lee", major = "정보컴퓨터" });
            list.Add(new Teacher() { name = "kim", major = "가정" });
            list.Add(new Teacher() { name = "jang", major = "디지인" });

            for(int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].major == "정보컴퓨터")
                {
                    list.RemoveAt(i);
                }
                //Console.WriteLine(item.name + " : " + item.major);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.major);
            }
        }
    }
}
