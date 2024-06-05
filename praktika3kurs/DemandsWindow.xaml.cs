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
    /// Логика взаимодействия для DemandsWindow.xaml
    /// </summary>
    public partial class DemandsWindow : Window
    {
        private readonly RealEstateContext _context;

        public DemandsWindow(RealEstateContext context)
        {
            InitializeComponent();
            _context = context;
            LoadDemands();
        }

        private void LoadDemands()
        {
            List<Demand> demands = _context.Demands.ToList();
            DemandsDataGrid.ItemsSource = demands;
        }
    }
}
