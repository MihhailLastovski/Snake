using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Params
    {
        private string resourcesFoler;
        public Params()
        {
            resourcesFoler = Directory.GetCurrentDirectory().ToString();
        }
        public string GetResourceFolder()
        {
            return resourcesFoler;
        }
    }
}