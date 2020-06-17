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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YearFacts;
using YearFacts.Years;
using YearIterator;

namespace EpidemicDesign
{
    public partial class MainWindow : Window
    {
        private IYear year2019_2020;

        private IYear selectedYear;

        private IIterator yi;

        private IIterator selectedIterator;
        public MainWindow()
        {
            InitializeComponent();
            this.year2019_2020 = new Year2019_2020();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.yi = this.year2019_2020.CreateIterator();
            this.fact2019_2020.Text = "Първи за COVID-19 съобщава китайския лекар Ли Уенлианг, още през декември 2019г. Властите го обвиняват в разпространяване на фалшиви новини, но месец по-късно епидемията се разраства с пълна сила. Сравнете COVID-19 с факти от разпространението на други подобни силно заразни заболявания.";
            this.badFactYear.Text = "Избери година и сравни дали тази година е била по-лоша от сегашните събития, свързани с COVID-19.";

            this.yearComboBox.ItemsSource = Enum.GetValues(typeof(YearEnum));
            this.yearComboBox.SelectedItem = YearEnum.Year1968_1970;
        }

        private void getFactsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.badFactYear.Text = this.selectedIterator.Next();
                this.fact2019_2020.Text = this.yi.Next();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.yi.IsDone())
                {
                    this.fact2019_2020.Text = "Край на фактите до момента.";
                    this.next2019_2020button.IsEnabled = false;
                }
                if (this.selectedIterator.IsDone())
                {
                    this.badFactYear.Text = "Край на фактите до момента.";
                    this.nextFactButton.IsEnabled = false;
                }
            }
        }

        private void yearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // Get the selected year.
                YearEnum yearEnum = (YearEnum)this.yearComboBox.SelectedItem;
                this.selectedYear = YearType.ChooseYear(yearEnum);
                this.selectedIterator = this.selectedYear.CreateIterator();
                this.labelYear.Content = this.selectedYear.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remove2019_2020fact_Click(object sender, RoutedEventArgs e)
        {
            var instance = RemoveMessage.Instance;

            MessageBox.Show(instance.DisplayInstance());
        }

        private void reset2019_2020button_Click(object sender, RoutedEventArgs e)
        {
            this.yi.First();
            this.fact2019_2020.Text = this.yi.CurrentItem();

            if (!this.next2019_2020button.IsEnabled)
            {
                this.next2019_2020button.IsEnabled = true;
            }
        }

        private void resetFactButton_Click(object sender, RoutedEventArgs e)
        {
            this.selectedIterator.First();
            this.badFactYear.Text = this.selectedIterator.CurrentItem();

            if (!this.nextFactButton.IsEnabled)
            {
                this.nextFactButton.IsEnabled = true;
            }
        }

        private void nextFactButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.badFactYear.Text = this.selectedIterator.Next();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.selectedIterator.IsDone())
                {
                    this.badFactYear.Text = "Край на фактите до момента.";
                    this.nextFactButton.IsEnabled = false;
                }
                else
                {
                    this.badFactYear.Text = "Uh oh. Unexpected error.";
                }
            }
        }

        private void next2019_2020button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.fact2019_2020.Text = this.yi.Next();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.yi.IsDone())
                {
                    this.fact2019_2020.Text = "Край на фактите до момента.";
                    this.next2019_2020button.IsEnabled = false;
                }
            }
        }

        private void addInfo_Click(object sender, RoutedEventArgs e)
        {
            AddInfo window = new AddInfo(this.selectedYear);

            window.ShowDialog();
        }
    }
}
