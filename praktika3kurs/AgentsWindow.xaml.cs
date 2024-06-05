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
    /// Логика взаимодействия для AgentsWindow.xaml
    /// </summary>
    public partial class AgentsWindow : Window
    {
        private readonly RealEstateContext _context;

        public AgentsWindow(RealEstateContext context)
        {
            InitializeComponent();
            _context = context;
            LoadAgents();
        }

        private void LoadAgents()
        {
            List<Agent> agents = _context.Agents.ToList();
            AgentsDataGrid.ItemsSource = agents;
        }
    }
}
