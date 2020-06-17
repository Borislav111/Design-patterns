using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts.Years
{
    public class Year2005_2014 : Year, IYear
    {
        public Year2005_2014()
        {
            this.horribleTruths = new List<string>()
            {
                "Птичи грип или H5N1 (2005-2014). Това е остро инфекциозно вирусно заболяване на птиците, характеризиращо се с увреждане на храносмилателната система, дишането и с много висока смъртност. Основните разпространители на птичия грип са мигриращите диви птици, предимно патици.",
                "До август 2005 г. във Виетнам, Тайланд, Камбоджа, Индонезия са регистрирани 112 случая на зараза с птичи грип, от които 64 смъртни случая, като предаването е от птици на хора, не е установено предаване на вируса от човек на човек. В опит да спрат разпространението на вируса милиони домашни птици са унищожени или ваксинирани.",
                "Според СЗО от февруари 2003 г. до февруари 2008 г. от 361 потвърдени случая на инфекция на хора с вируса на птичия грип 227 са били фатални. Последният фатален край на човек, заразен от птичи грип, е регистрирана през 2014 г. в Канада."
            };
        }
        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }
        public IIterator CreateIterator()
        {
            return new Year2005_2014Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "2005_2014";
        }
    }
}
