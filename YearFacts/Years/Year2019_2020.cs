using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts.Years
{
    public class Year2019_2020 : Year, IYear
    {
        public Year2019_2020()
        {
            this.horribleTruths = new List<string>()
            {
                "COVID - 19. Коронавирусът COVID-19 засяга различни хора по различен начин. Повечето заразени хора развиват леко до умерено заболяване и се възстановят без хоспитализация.",
                "Вирусът, който причинява COVID-19, се предава основно чрез капчици, образувани при кашляне, кихане или издишване на заразен човек. Тъй като тези капчици са твърде тежки, те не се задържат във въздуха и бързо попадат върху подове или повърхности.",
                "Можете да се заразите чрез вдишване на вируса, ако сте в непосредствена близост до заразен с COVID-19, или чрез докосване на замърсена повърхност и след това на очите, носа или устата.",
                "Към момента световната статистика сочи: 8,058,976 заразени, починали: 437,427, оздравели: 3,895,700. Като тези данни непрекъснато се променят."
            };
        }
        public string Description
        {
            get
            {
                return "2016 was not considered a good year. The election was weird, etc. etc.";
            }
        }

        public List<string> HorribleFacts
        {
            get
            {
                return this.horribleTruths;
            }

            set
            {
                this.horribleTruths = value;
            }
        }

        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }

        public IIterator CreateIterator()
        {
            return new Year2019_2020Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "2019_2020";
        }
    }
}
