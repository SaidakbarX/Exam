using System.Xml.Linq;

namespace ExamFirstModul
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        //1-savol
        public static int TwoDigitsNumbers(List<int> numbers)
        {   var count = 0;
            foreach (var number in numbers)
            {
                if (10 < number && number > 99) count++;
            }
            return count;
        }
        //2-savol
        public static string RemoveLastTwo(string delete)
        {
         delete = delete.Substring(0,delete.Length-2);
            return delete;
        }
        // 3-savol
        public static bool AllElementsAreUppercase (List<string> elements)
        {
        for (var i = 0; i < elements.Count; i++)
            {
                if (i == char.ToLower())
                {

                }
            }
        }
        //4-misol
        public static bool StartEnd(string word)
        {
            if ((word.StartsWith== 'qovun')  &&  (word.EndsWith == 'qovun') )
            {
                return true;
            }
            return false;
        }


    }
}
