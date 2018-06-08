using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutA
{
    class Generic<T>
    {
        private T width;
        private T length;

        public T Width
        {
            get { return width; }
            set { width = value; }
        }

        public T Length
        {
            get { return length; }
            set { length = value; }
        }

        public Generic(T w, T l)
        {
            width = w;
            length = l;
        }

        public string GetArea()
        {
            double dblWidth = Convert.ToDouble(Width);
            double dblLength = Convert.ToDouble(Length);

            return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
        }
    }
}
