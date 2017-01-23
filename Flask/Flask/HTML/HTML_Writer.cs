using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Flask.FrontEnd.HTML
{
    class HTML_Writer
    {
        /// <summary>
        /// Create an empty HTML extension file
        /// </summary>
        /// <param Path="Objects"></param>
        public void Create(string Name)
        {
            string third = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            File.Create(third + "\\Objects\\" + Name + ".html");
        }

        public string HelloWorld()
        {
            string sample = "Hello, World!";
            return sample;
        }

        public string Template()
        {
            
            return "wiw";
        }
    }
}
