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
using System.Data.SqlClient;
using Oasis.Core;
using Oasis.Core.Models;

namespace Oasis.Design
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // InitialPerson();
        }
        private void InitialPerson()
        {
            using (Context context = new Context())
            {
                Admin admin = new Admin("admin", "root");
                User user1 = new User("s1mple", "qwerty123", "Oleksandr", "Kostyliev");

                context.People.Add(admin);
                context.People.Add(user1);
                context.SaveChanges();

                MessageBox.Show("Saved");
            }
        }
    }
}
