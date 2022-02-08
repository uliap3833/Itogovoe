using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace EnglishSchooll
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Record : Page
    {
        Record RecordObj;
        Service service;
        public Record(Service service)
        {
            InitializeComponent();
            this.service = service;
            Title.Text = service.Title;
            DurationInMinute.Text = "Длительность: " + (service.DurationInSeconds / 60).ToString() + " минут";
            CBuser.ItemsSource = Const.BD.Client.ToList();
            CBuser.SelectedValuePath = "ID";
            CBuser.DisplayMemberPath = "FIO";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var ogr = new Regex(@"[0-9][0-9]:[0-9][0-9]");
                textBox.Text = new string
                    (
                            textBox
                            .Text
                            .Where
                            (ch =>
                            ch == ':'
                            || (ch >= '0' && ch <= '9')
                            )
                            .ToArray()
                    );
                if (ogr.Equals(textBox.Text))
                {
                    textBox.BorderBrush = Brushes.Green;
                }
                else
                {
                    textBox.BorderBrush = Brushes.Red;
                }
            }
        }

        private void Breg_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Lback_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Const.frame.Navigate(new ServiceList());
        }
    }
}
