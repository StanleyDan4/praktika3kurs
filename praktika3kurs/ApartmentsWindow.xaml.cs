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
    /// Логика взаимодействия для ApartmentsWindow.xaml
    /// </summary>
    public partial class ApartmentsWindow : Window
    {
        private readonly RealEstateContext _context;

        public ApartmentsWindow(RealEstateContext context)
        {
            InitializeComponent();
            _context = context;
            LoadApartments();
        }

        private void LoadApartments()
        {
            List<Apartment> apartments = _context.Apartments.ToList();
            ApartmentsDataGrid.ItemsSource = apartments;
        }
    }
}
