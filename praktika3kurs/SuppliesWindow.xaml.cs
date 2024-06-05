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
using System.Windows.Shapes;

namespace praktika3kurs
{
    /// <summary>
    /// Логика взаимодействия для SuppliesWindow.xaml
    /// </summary>
    public partial class SuppliesWindow : Window
    {
        private readonly RealEstateContext _context;

        public SuppliesWindow(RealEstateContext context)
        {
            InitializeComponent();
            _context = context;
            LoadSupplies();
        }

        private void LoadSupplies()
        {
            List<Supply> supplies = _context.Supplies.ToList();
            SuppliesDataGrid.ItemsSource = supplies;
        }
    }
}
