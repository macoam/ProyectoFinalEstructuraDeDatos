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

namespace ProyectoSemestralED
{
    /// <summary>
    /// Lógica de interacción para Editar.xaml
    /// </summary>
    public partial class Editar : UserControl
    {
        public Editar()
        {
            InitializeComponent();

            txtTituloED.IsEnabled = false;
            txtDirectorED.IsEnabled = false;
            txtTemporadasED.IsEnabled = false;
            txtTituloED.IsEnabled = false;
            cbGenero.IsEnabled = false;
            txtSinopsisED.IsEnabled = false;
            txtAñoED.IsEnabled = false;
            cbRantingED.IsEnabled = false;
            txtGeneroED.IsEnabled = false;
            txtRantingED.IsEnabled = false;
        }
    }
}
