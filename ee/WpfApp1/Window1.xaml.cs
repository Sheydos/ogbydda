using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
//using System.Windows.;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }

        public bool Visible { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (TradeEntities1 users = new TradeEntities1())

            {
                var query = users.User;
                foreach (var item in query)
                {
                    if (item.UserLogin == TextBox1.Text)
                    {

                        if (item.UserPassword == TextBox2.Text)
                        {
                            MainWindow Login = new MainWindow();
                            this.Visible = false;
                            Login.Show();
                            this.Close();
                        }
                        else { MessageBox.Show("Пароль не верный");
                            
                        }
                    

                    }
                    


                }



            }

        }





    }
    
}
