using EasyCaptcha.Wpf;
using Microsoft.SqlServer.Server;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool Visible { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, MyCaptcha);
        }

        private void Button_Click(object sender, RoutedEventArgs e, Captcha captcha)
        {
            
            captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
            var answer = MyCaptcha.CaptchaText;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (MyCaptcha.CaptchaText == textbox.Text)
            {
                MessageBox.Show("Верно");
            }
            else MessageBox.Show("Неверно");
        }

        
    }


}
