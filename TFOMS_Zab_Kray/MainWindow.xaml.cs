using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using TFOMS_Zab_Kray.Classes;
using TFOMS_Zab_Kray.Classes.Context;

namespace TFOMS_Zab_Kray
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (TFOMSContext con = new TFOMSContext())
            {
                var cabinets = con.Cabinets.Include(c => c.Department).Where(c=> c.Value==1).ToList();
            }
        }
    }
}
