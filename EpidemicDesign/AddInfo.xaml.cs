using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YearFacts;
using YearFacts.Years;

namespace EpidemicDesign
{
    public partial class AddInfo : Window
    {
        private IYear selectYear;

        private Year1918_1919 year18_19;

        private Year1968_1970 year68_70;

        private Year2002_2003 year02_03;

        private Year2005_2014 year05_14;

        private Year2009_2010 year09_10;

        private Year2012_2015 year12_15;

        private Year2019_2020 year19_20;

        public AddInfo(IYear year)
        {
            this.selectYear = year;

            if (year is Year1918_1919)
            {
                this.year18_19 = this.selectYear as Year1918_1919;
            }
            else if (year is Year1968_1970)
            {
                this.year68_70 = this.selectYear as Year1968_1970;
            }
            else if (year is Year2002_2003)
            {
                this.year02_03 = this.selectYear as Year2002_2003;
            }
            else if (year is Year2005_2014)
            {
                this.year05_14 = this.selectYear as Year2005_2014;
            }
            else if (year is Year2009_2010)
            {
                this.year09_10 = this.selectYear as Year2009_2010;
            }
            else if (year is Year2012_2015)
            {
                this.year12_15 = this.selectYear as Year2012_2015;
            }
            else if (year is Year2019_2020)
            {
                this.year19_20 = this.selectYear as Year2019_2020;
            }


            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string fact = this.addInfoTextBox.Text;

            if (this.selectYear is Year1918_1919)
            {
                this.year18_19.Add(fact);
            }
            else if (this.selectYear is Year1968_1970)
            {
                this.year68_70.Add(fact);
            }
            else if (this.selectYear is Year2002_2003)
            {
                this.year02_03.Add(fact);
            }
            else if (this.selectYear is Year2005_2014)
            {
                this.year05_14.Add(fact);
            }
            else if (this.selectYear is Year2009_2010)
            {
                this.year09_10.Add(fact);
            }
            else if (this.selectYear is Year2012_2015)
            {
                this.year12_15.Add(fact);
            }
            else if (this.selectYear is Year2019_2020)
            {
                this.year19_20.Add(fact);
            }
            else
            {
                MessageBox.Show("Not valid");
            }

            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.yearLabel.Content = this.selectYear.ToString();
        }
    }
}
