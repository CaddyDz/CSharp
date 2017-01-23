using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask.FrontEnd.Languages.HTML
{
    class TemplateGenerator
    {
        public string Doctype()
        {
            return "<!DOCTYPE html>";
        }
        public string head()
        {
            return "<head></head>";
        }
    }
}
