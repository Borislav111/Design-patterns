using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts.Years
{
    public class Year1918_1919 : Year, IYear
    {
        public Year1918_1919()
        {
            this.horribleTruths = new List<string>()
            {
                "Испански грип или H1N1. През 20-и век са регистрирани няколко грипни епидемии, с масови инфекции, предизвикали смъртта на много хора по света. Една от най-тежките епидемии испанският грип, известен повече като Испанката или H1N1",
                "През 1918-1919 г. за 18 месеца около 550 милиона души, или 29.5% от населението на света, са заразени с испански грип.",
                "Загиват около между 50 и 100 милиона души, или 2.7 - 5.3% от населението на света, през първите 25 седмици грипът убива 25 милиона души.",
                "Засега тази вирусна грипна епидемия е една от най-големите в човешката историята. В някои страни обществени места, като съдилища, училища, църкви, театри и кина са били затворени цяла година, на някои места е въведен и военен режим."
            };
        }
        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }
        public IIterator CreateIterator()
        {
            return new Year1918_1919Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "1918_1919";
        }
    }
}
