using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Cinema.Model;
using Cinema.View_Model;

namespace MyCinemaApp.View
{
    /// <summary>
    /// Логика взаимодействия для CafeView.xaml
    /// </summary>
    public partial class CafeView : Window
    {
        Cafe myCafe;
        public CafeView()
        {
            myCafe = new Cafe();
            
            InitializeComponent();
            MenuApp.ItemsSource = myCafe.myMeny;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
