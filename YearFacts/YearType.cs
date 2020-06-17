using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearFacts.Years;

namespace YearFacts
{
   public static class YearType
    {
        public static IYear ChooseYear(YearEnum year)
        {
            switch (year)
            {
                case YearEnum.Year1918_1919:
                    return new Year1918_1919();
                case YearEnum.Year1968_1970:
                    return new Year1968_1970();
                case YearEnum.Year2002_2003:
                    return new Year2002_2003();
                case YearEnum.Year2005_2014:
                    return new Year2005_2014();
                case YearEnum.Year2009_2010:
                    return new Year2009_2010();
                case YearEnum.Year2012_2015:
                    return new Year2012_2015();
                case YearEnum.Year2019_2020:
                    return new Year2019_2020();
                default:
                    return null;
            }
        }
    }
}
