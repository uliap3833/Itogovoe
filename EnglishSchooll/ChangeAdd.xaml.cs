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

namespace EnglishSchooll
{
    /// <summary>
    /// Логика взаимодействия для ChangeAdd.xaml
    /// </summary>
    public partial class ChangeAdd : Page
    {
            Service RecordObj = new Service();
            bool Save;
            public ChangeAdd()
            {
                InitializeComponent();
                Save = true;
                Discount.Text = "0";
            }

            public ChangeAdd(Service Update)
            {
                InitializeComponent();
                RecordObj = Update;
                Save = false;

                Title.Text = Update.Title;
                Cost.Text = Update.Cost.ToString();
                Discount.Text = Convert.ToInt32(Update.Discount * 100).ToString();
                DurationInMinute.Text = Convert.ToInt32(Update.DurationInSeconds / 60).ToString();
                if(Update.MainImagePath != null)
                ImagePath.Text = Update.MainImagePath.Substring(13);
        }

            private void Breg_Click(object sender, RoutedEventArgs e)
            {
                RecordObj.Title = Title.Text;
                RecordObj.Cost =  Convert.ToDecimal(Cost.Text);
                RecordObj.Discount = Convert.ToDouble(Discount.Text) / 100;
                RecordObj.DurationInSeconds = Convert.ToInt32(DurationInMinute.Text) * 60;
                RecordObj.MainImagePath = @"Услуги школы\" + ImagePath.Text;
                if (Save)
                {
                    Const.BD.Service.Add(RecordObj);
                }
                Const.BD.SaveChanges();
                MessageBox.Show("Данные записаны", "", MessageBoxButton.OK);
                Title.Text = "";
                Cost.Text = "";
                Discount.Text = "";
                DurationInMinute.Text = "";
                ImagePath.Text = "" ;
            }

            private void Lback_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
            {
                Const.frame.Navigate(new ServiceList());
            }
        }
}
