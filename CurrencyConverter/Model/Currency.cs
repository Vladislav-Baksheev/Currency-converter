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
        public string SourceName { get; set; }

        /// <summary>
        /// Целевое название валюты.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Исходная сумма.
        /// </summary>
        public double SourceValue { get; set; }

        /// <summary>
        /// Итоговая сумма.
        /// </summary>
        public double FinalValue { get; set; }

        public Currency() 
        {
            
        }

        public Currency(string sourceName, string targetName, double sourceValue, double finalValue)
        {
            SourceName = sourceName;
            TargetName = targetName;
            SourceValue = sourceValue;
            FinalValue = finalValue;
        }
    }
}
