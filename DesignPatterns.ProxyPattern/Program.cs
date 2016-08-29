using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class SubjectAccessor
    {
        public interface ISubject
        {
            string Request();   
        }

        private class Subject
        {
            public string Request()
            {
                return "Subject Request : Choose Left Door";
            }
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
