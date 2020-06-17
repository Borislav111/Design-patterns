﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts.Years
{
    public class Year2012_2015 : Year, IYear
    {
        public Year2012_2015()
        {
            this.horribleTruths = new List<string>()
            {
                "MERS (2012-2015). Най-близкият роднина на съвременния коронавирус е MERS или близкоизточен респираторен синдром.", "Това е възпалително заболяване на дихателната система, причинено от вирус от рода Betacoronavirus от подсемейство Coronavirinae, през 2013 г. официално е наречен „коронавирус на дихателния синдром на Близкия изток.",
                "Всъщност MERS е от същото семейство като коронавируса, който причини епидемията сега.",
                "Първите случаи на новия вирус MERS са регистрирани в Саудитска Арабия в началото на есента на 2012 г., а до юни 2013 г. приблизително половината са били фатални. ",
                "До лятото на 2015 г. са регистрирани случаи в 23 страни, включително Саудитска Арабия, Йемен, Обединените арабски емирства, Франция, Германия, Италия, Гърция, Тунис, Египет, Малайзия, Тайланд, Южна Корея и други.",
                "Първите симптоми на тази вирусна инфекция са следните: треска, кашлица, задух. С развитието на болестта тя се превръща във форма на тежка вирусна пневмония, в някои случаи придружена от бъбречна недостатъчност."
            };
        }
        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }
        public IIterator CreateIterator()
        {
            return new Year2012_2015Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "2012_2015";
        }
    }
}
