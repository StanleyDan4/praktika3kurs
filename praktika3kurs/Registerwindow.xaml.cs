using praktika3kurs.Models;
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

namespace praktika3kurs
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly RealEstateContext _context;

        public RegisterWindow(RealEstateContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ShowAgentsButton_Click(object sender, RoutedEventArgs e)
        {
            var agentsWindow = new AgentsWindow(_context);
            agentsWindow.Show();
        }

        private void ShowApartmentsButton_Click(object sender, RoutedEventArgs e)
        {
            var apartmentsWindow = new ApartmentsWindow(_context);
            apartmentsWindow.Show();
        }

        private void ShowDemandsButton_Click(object sender, RoutedEventArgs e)
        {
            var demandsWindow = new DemandsWindow(_context);
            demandsWindow.Show();
        }

        private void ShowSuppliesButton_Click(object sender, RoutedEventArgs e)
        {
            var suppliesWindow = new SuppliesWindow(_context);
            suppliesWindow.Show();
        }
    }

        
    
}

