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
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        public ServiceList()
        {
            InitializeComponent();
            LVCelebration.ItemsSource = Const.BD.Service.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            Service Delete = Const.BD.Service.FirstOrDefault(y => y.ID == ind);
            Const.BD.Service.Remove(Delete);
            Const.BD.SaveChanges();
            Const.frame.Navigate(new ServiceList());
            MessageBox.Show("Запись удалена", "", MessageBoxButton.OK);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            Service Update = Const.BD.Service.FirstOrDefault(y => y.ID == ind);
            Const.frame.Navigate(new ChangeAdd(Update));
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            Service Update = Const.BD.Service.FirstOrDefault(y => y.ID == ind);
            Const.frame.Navigate(new Record(Update));
        }

        private void Ladd_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Const.frame.Navigate(new ChangeAdd());
        }
       
    }
}
