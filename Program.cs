using System;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.IO;
using System.Collections;
 

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var language = new CultureInfo("de");

            CultureInfo.CurrentCulture = language;
            CultureInfo.CurrentUICulture = language;

            var assembly = typeof(Program).GetTypeInfo().Assembly;
            ResourceManager MyResM = new ResourceManager("NetcoreRes.Strings",assembly);
            Console.WriteLine(MyResM.GetString("key1"));
            
            var language1 = new CultureInfo("fr");

            CultureInfo.CurrentCulture = language1;
            CultureInfo.CurrentUICulture = language1;

            Console.WriteLine(MyResM.GetString("key1"));
        }
    }
}

