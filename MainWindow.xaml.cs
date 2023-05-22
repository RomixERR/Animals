using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Animls
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Debug.WriteLine("=============             ===================                        ====================              ================");

            InitializeComponent();
            iAnimalCreator af = new MammalCreator();
            var cat = af.Create("Котяра");
            Debug.WriteLine(cat);

            iAnimalCreatorT aa = new Creator();
            var frog = aa.Create<Amphibian>("Лямгущьк");
            Debug.WriteLine(frog);




        }
    }
}
