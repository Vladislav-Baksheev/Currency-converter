using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Currency
    {
        /// <summary>
        /// Исходное название валюты.
        /// </summary>
        public string Name { get; set; }

        public Currency() 
        {
            
        }

        public Currency(string sourceName)
        {
            Name = sourceName;
        }
    }
}
