using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts.Years
{
    public class Year2002_2003 : Year, IYear
    {
        public Year2002_2003()
        {
            this.horribleTruths = new List<string>()
            {
                "SARS (2002-2003). Това е тежък, много остър респираторен синдром или атипична пневмония, причинена от един от 7-те коронавируси, които се предават между хората.",
                "Първите случаи на заболяването са открити в китайската провинция Гуандун. В рамките на 2 месеца инфекцията се разпространи в съседните Хонконг и Виетнам, а в края на февруари 2003 г. и в други страни и континенти.",
                "По данни на СЗО около 9% от пациентите с потвърдена диагноза умират. Смъртността е била много по-висока при пациенти на възраст над 50 години, като достига до 50% от заболелите. В периода от ноември 2002 г. до юли 2003 г. са регистрирани общо 8096 случая в 29 държави, а общо 774 души са починали."
            };
        }
        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }
        public IIterator CreateIterator()
        {
            return new Year2002_2003Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "2002_2003";
        }
    }
}
