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
using System.Collections.ObjectModel;


namespace ProyectoSemestralED
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Elementos> element = new ObservableCollection<Elementos>();
        public MainWindow()
        {
            InitializeComponent();

            element.Add(new Elementos("La gran masacre", 1998, "Terror", "3", "Josh Smith", "5 estudiantes, un destino.", "2"));
            element.Add(new Elementos("Al pan pan y alvino vino...", 2006, "Comedia", "15", "Apakh Sultanu", "Adivina adivinador, de que se trata el título de hoy?.", "1"));
            element.Add(new Elementos("La llama en llamas", 2017, "Acción", "7", "Pedrito Alfonsito Rodriguez", "¿Qué pasará con la llama en llamas que llama a su llama?.", "5"));
            element.Add(new Elementos("Pepito clavo un calvito", 1967, "Fantasía", "2", "Millie Sugar", "Pepito, el niño que clava clavitos.", "3"));

            listaViewMain.ItemsSource = element;

            btnEditar.Visibility = Visibility.Hidden;
            btnActualizar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            rdbtnPelicula.Visibility = Visibility.Hidden;
            rdbtnSerie.Visibility = Visibility.Hidden;
            lblTipo.Visibility = Visibility.Hidden;
            lblRellenarCampos.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            estrellaUno.Visibility = Visibility.Hidden;
            estrellaDos.Visibility = Visibility.Hidden;
            estrellaTres.Visibility = Visibility.Hidden;
            estrellaCuatro.Visibility = Visibility.Hidden;
            estrellaCinco1.Visibility = Visibility.Hidden;

        }

        private void btnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {
            btnLetras1.Visibility = Visibility.Hidden;
            btnLetras2.Visibility = Visibility.Hidden;
            btnNumeros1.Visibility = Visibility.Hidden;
            btnNumeros2.Visibility = Visibility.Hidden;
            lblOrdenar.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Visible;
            rdbtnPelicula.Visibility = Visibility.Visible;
            rdbtnSerie.Visibility = Visibility.Visible;
            lblTipo.Visibility = Visibility.Visible;
            estrellaUno.Visibility = Visibility.Hidden;
            estrellaDos.Visibility = Visibility.Hidden;
            estrellaTres.Visibility = Visibility.Hidden;
            estrellaCuatro.Visibility = Visibility.Hidden;
            estrellaCinco1.Visibility = Visibility.Hidden;

        }

        private void listaViewMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaViewMain.SelectedIndex != -1)
            {
                btnCancelar.Visibility = Visibility.Visible;
                grdContenido.Children.Clear();
                grdContenido.Children.Add(new Editar());
                ((Editar)(grdContenido.Children[0])).txtTituloED.Text = element[listaViewMain.SelectedIndex].Titulo;
                ((Editar)(grdContenido.Children[0])).txtGeneroED.Text = element[listaViewMain.SelectedIndex].Genero;
                ((Editar)(grdContenido.Children[0])).txtDirectorED.Text = element[listaViewMain.SelectedIndex].Productor;
                ((Editar)(grdContenido.Children[0])).txtSinopsisED.Text = element[listaViewMain.SelectedIndex].Sinopsis;
                ((Editar)(grdContenido.Children[0])).txtAñoED.Text = element[listaViewMain.SelectedIndex].Año.ToString();
                ((Editar)(grdContenido.Children[0])).txtTemporadasED.Text = element[listaViewMain.SelectedIndex].Temporadas;
                ((Editar)(grdContenido.Children[0])).txtRantingED.Text = element[listaViewMain.SelectedIndex].Ranting;

                btnEditar.Visibility = Visibility.Visible;
                btnLetras1.Visibility = Visibility.Hidden;
                btnLetras2.Visibility = Visibility.Hidden;
                btnNumeros1.Visibility = Visibility.Hidden;
                btnNumeros2.Visibility = Visibility.Hidden;
                lblOrdenar.Visibility = Visibility.Hidden;
                btnGuardar2.Visibility = Visibility.Hidden;
                btnEliminar.Visibility = Visibility.Visible;

                if (((Editar)(grdContenido.Children[0])).txtRantingED.Text == "1")
                {
                    estrellaUno.Visibility = Visibility.Visible;
                    estrellaDos.Visibility = Visibility.Hidden;
                    estrellaTres.Visibility = Visibility.Hidden;
                    estrellaCuatro.Visibility = Visibility.Hidden;
                    estrellaCinco1.Visibility = Visibility.Hidden;
                }
                if (((Editar)(grdContenido.Children[0])).txtRantingED.Text == "2")
                {
                    estrellaUno.Visibility = Visibility.Hidden;
                    estrellaDos.Visibility = Visibility.Visible;
                    estrellaTres.Visibility = Visibility.Hidden;
                    estrellaCuatro.Visibility = Visibility.Hidden;
                    estrellaCinco1.Visibility = Visibility.Hidden;
                }
                if (((Editar)(grdContenido.Children[0])).txtRantingED.Text == "3")
                {
                    estrellaUno.Visibility = Visibility.Hidden;
                    estrellaDos.Visibility = Visibility.Hidden;
                    estrellaTres.Visibility = Visibility.Visible;
                    estrellaCuatro.Visibility = Visibility.Hidden;
                    estrellaCinco1.Visibility = Visibility.Hidden;
                }
                if (((Editar)(grdContenido.Children[0])).txtRantingED.Text == "4")
                {
                    estrellaUno.Visibility = Visibility.Hidden;
                    estrellaDos.Visibility = Visibility.Hidden;
                    estrellaTres.Visibility = Visibility.Hidden;
                    estrellaCuatro.Visibility = Visibility.Visible;
                    estrellaCinco1.Visibility = Visibility.Hidden;
                }
                if (((Editar)(grdContenido.Children[0])).txtRantingED.Text == "5")
                {
                    estrellaUno.Visibility = Visibility.Hidden;
                    estrellaDos.Visibility = Visibility.Hidden;
                    estrellaTres.Visibility = Visibility.Hidden;
                    estrellaCuatro.Visibility = Visibility.Hidden;
                    estrellaCinco1.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnNumeros1_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = element.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < element.Count; i++)
                {
                    if (gap + i < element.Count && element[i].Año > element[gap + i].Año)
                    {
                        var temp = element[i];
                        element[i] = element[gap + i];
                        element[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void btnNumeros2_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = element.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < element.Count; i++)
                {
                    if (gap + i < element.Count && element[i].Año < element[gap + i].Año)
                    {

                        var temp = element[i];
                        element[i] = element[gap + i];
                        element[gap + i] = temp;
                    }
                }
                gap--;
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Clear();
            btnLetras1.Visibility = Visibility.Hidden;
            btnLetras2.Visibility = Visibility.Hidden;
            btnNumeros1.Visibility = Visibility.Hidden;
            btnNumeros2.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            estrellaUno.Visibility = Visibility.Hidden;
            estrellaDos.Visibility = Visibility.Hidden;
            estrellaTres.Visibility = Visibility.Hidden;
            estrellaCuatro.Visibility = Visibility.Hidden;
            estrellaCinco1.Visibility = Visibility.Hidden;

        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Clear();
            grdContenido.Children.Add(new Editar());

            ((Editar)(grdContenido.Children[0])).txtTituloED.Text = element[listaViewMain.SelectedIndex].Titulo;
            ((Editar)(grdContenido.Children[0])).txtGeneroED.Text = element[listaViewMain.SelectedIndex].Genero;
            ((Editar)(grdContenido.Children[0])).txtDirectorED.Text = element[listaViewMain.SelectedIndex].Productor;
            ((Editar)(grdContenido.Children[0])).txtSinopsisED.Text = element[listaViewMain.SelectedIndex].Sinopsis;
            ((Editar)(grdContenido.Children[0])).txtAñoED.Text = element[listaViewMain.SelectedIndex].Año.ToString();
            ((Editar)(grdContenido.Children[0])).txtTemporadasED.Text = element[listaViewMain.SelectedIndex].Temporadas;
            ((Editar)(grdContenido.Children[0])).txtRantingED.Text = element[listaViewMain.SelectedIndex].Ranting;

            ((Editar)(grdContenido.Children[0])).txtTituloED.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).cbGenero.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).txtDirectorED.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).txtSinopsisED.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).txtAñoED.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).txtTemporadasED.IsEnabled = true;
            ((Editar)(grdContenido.Children[0])).cbRantingED.IsEnabled = true;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar2.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Visible;

        }
        

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (((Editar)(grdContenido.Children[0])).txtTituloED.Text == string.Empty || ((Editar)(grdContenido.Children[0])).txtAñoED.Text == string.Empty || ((Editar)(grdContenido.Children[0])).txtSinopsisED.Text == string.Empty || ((Editar)(grdContenido.Children[0])).txtDirectorED.Text == string.Empty || ((Editar)(grdContenido.Children[0])).cbGenero.Text == string.Empty || ((Editar)(grdContenido.Children[0])).cbRantingED.Text == string.Empty)
            {
                lblRellenarCampos.Visibility = Visibility.Visible;
            }
            else
            {

                grdContenido.Children.Add(new Editar());
                var ei = ((Editar)(grdContenido.Children[0]));
                var e2 = element[listaViewMain.SelectedIndex];
                var año2 = e2.Año.ToString();
                var año3 = Convert.ToInt32(((Editar)(grdContenido.Children[0])).txtAñoED.Text);

                e2.Año = año3;

                e2.Titulo = ei.txtTituloED.Text;
                e2.Sinopsis = ei.txtSinopsisED.Text;
                e2.Temporadas = ei.txtTemporadasED.Text;
                e2.Productor = ei.txtDirectorED.Text;
                e2.Genero = ei.cbGenero.Text;
                e2.Ranting = ei.cbRantingED.Text;

                lblRellenarCampos.Visibility = Visibility.Hidden;
                listaViewMain.Items.Refresh();
                grdContenido.Children.Clear();
            }


            btnLetras1.Visibility = Visibility.Hidden;
            btnLetras2.Visibility = Visibility.Hidden;
            btnNumeros1.Visibility = Visibility.Hidden;
            btnNumeros2.Visibility = Visibility.Hidden;
            lblOrdenar.Visibility = Visibility.Hidden;
            estrellaUno.Visibility = Visibility.Hidden;
            estrellaDos.Visibility = Visibility.Hidden;
            estrellaTres.Visibility = Visibility.Hidden;
            estrellaCuatro.Visibility = Visibility.Hidden;
            estrellaCinco1.Visibility = Visibility.Hidden;

        }


        private void btnLetras1_Click(object sender, RoutedEventArgs e)
        {
            bool swap;
            do
            {
                swap = false;
                for (int index = 0; index < (element.Count - 1); index++)
                {
                    if (string.Compare(element[index].Titulo, element[index + 1].Titulo) > 0)
                    {
                        var temp = element[index];
                        element[index] = element[index + 1];
                        element[index + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);
        }



        private void btnLetras2_Click(object sender, RoutedEventArgs e)
        {
            bool swap;
            do
            {
                swap = false;
                for (int index = 0; index < (element.Count - 1); index++)
                {
                    if (string.Compare(element[index].Titulo, element[index + 1].Titulo) < 0)
                    {
                        var temp = element[index];
                        element[index] = element[index + 1];
                        element[index + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);
        }

        
        private void rdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Clear();
            grdContenido.Children.Add(new AgregarNuevoElemento());
            ((AgregarNuevoElemento)(grdContenido.Children[0])).cbTemporadas.Visibility = Visibility.Hidden;
            ((AgregarNuevoElemento)(grdContenido.Children[0])).lblTemporadas.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Hidden;
        }

        private void rdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Clear();
            grdContenido.Children.Add(new AgregarNuevoElemento());
            ((AgregarNuevoElemento)(grdContenido.Children[0])).cbTemporadas.Visibility = Visibility.Visible;
            ((AgregarNuevoElemento)(grdContenido.Children[0])).lblTemporadas.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
            btnGuardar2.Visibility = Visibility.Hidden;
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (listaViewMain.SelectedIndex != -1)
            {
                element.RemoveAt(listaViewMain.SelectedIndex);
                estrellaUno.Visibility = Visibility.Hidden;
                estrellaDos.Visibility = Visibility.Hidden;
                estrellaTres.Visibility = Visibility.Hidden;
                estrellaCuatro.Visibility = Visibility.Hidden;
                estrellaCinco1.Visibility = Visibility.Hidden;
                btnEditar.Visibility = Visibility.Hidden;
                grdContenido.Children.Clear();
            }
        }


        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (((AgregarNuevoElemento)(grdContenido.Children[0])).txtTitulo.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtAño.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtDescripcion.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtProductor.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).cbGenero.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).cbRanting.Text == string.Empty)
            {
                lblRellenarCampos.Visibility = Visibility.Visible;
            }

            else
            {
                int año3 = Convert.ToInt32(((AgregarNuevoElemento)(grdContenido.Children[0])).txtAño.Text);

                element.Add(new Elementos(((AgregarNuevoElemento)(grdContenido.Children[0])).txtTitulo.Text, año3, ((AgregarNuevoElemento)(grdContenido.Children[0])).cbGenero.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).cbTemporadas.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).txtProductor.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).txtDescripcion.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).cbRanting.Text));
                lblRellenarCampos.Visibility = Visibility.Visible;
                listaViewMain.Items.Refresh();
            }
        }

        private void btnGuardar2_Click(object sender, RoutedEventArgs e)
        {
            if (((AgregarNuevoElemento)(grdContenido.Children[0])).txtTitulo.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtAño.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtDescripcion.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).txtProductor.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).cbGenero.Text == string.Empty || ((AgregarNuevoElemento)(grdContenido.Children[0])).cbRanting.Text == string.Empty)
            {
                lblRellenarCampos.Visibility = Visibility.Visible;
            }
            else
            {
                var pruebaaño = ((AgregarNuevoElemento)(grdContenido.Children[0])).txtAño.Text;
                int añofine = int.Parse(pruebaaño);
                string temporadass = "No posible";

                element.Add(new Elementos(((AgregarNuevoElemento)(grdContenido.Children[0])).txtTitulo.Text, añofine, ((AgregarNuevoElemento)(grdContenido.Children[0])).cbGenero.Text, temporadass, ((AgregarNuevoElemento)(grdContenido.Children[0])).txtProductor.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).txtDescripcion.Text, ((AgregarNuevoElemento)(grdContenido.Children[0])).cbRanting.Text));

                listaViewMain.Items.Refresh();
                lblRellenarCampos.Visibility = Visibility.Hidden;
            }
        }
    }


}
