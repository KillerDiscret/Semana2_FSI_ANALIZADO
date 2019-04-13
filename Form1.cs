using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //se puede crear un objeto pero apuntando a la nada null 
        // y luego inicializarlo dentro de una funcion
        CEmpleado objempleado = null;


        public Form1()
        {
            InitializeComponent();
            //llamamos a las funciones que declaramos abajo para poder
            //inicializarlas cuando se cargue el formulario
            llenarcombocategorias();
            configurarlistaempleados();

        }
        //llenaremos las categorias por código dentro del combo box
        void llenarcombocategorias()
        {
            //el id o name del comboBox es comboBoxLista
            //Items.Add sirbe para agregar elementos en el comboBox
            comboBoxLista.Items.Add("A");
            comboBoxLista.Items.Add("B");
            comboBoxLista.Items.Add("C");
            comboBoxLista.Items.Add("D");
        }
        void configurarlistaempleados()
        {
            //se configurara la forma en que se presentara los datos
            //en el listView con id listViewLista
            //solo mostrara las cuadriculas con sus subtitulos 
            listViewLista.View = View.Details;
            listViewLista.GridLines = true;
            listViewLista.Columns.Add("Empleado", 120);
            listViewLista.Columns.Add("Categoria", 80);
            listViewLista.Columns.Add("Minutos tardanzas", 120);
            listViewLista.Columns.Add("Llamadas atencion", 120);
            listViewLista.Columns.Add("Pago", 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objempleado = new CEmpleado();
            //al crear el set y get dentro de la funcion Nombres 
            //de variable nombre, solo hay que llamarlo sin () y 
            // se podrá utilizar su set y get automaticamente
            objempleado.Nombres = textBoxNombre.Text;
            //el comboBoxLista es desplegable
            //no se le agrega la propiedad Convert. porque lo 
            //que lo almacena es un string
            objempleado.Categoria = comboBoxLista.Text;
            objempleado.Tardanza = Convert.ToInt32(textBoxTardanza.Text);
            objempleado.Atencion = Convert.ToInt32(textBoxAtencion.Text);
            //se crear los item para agregar en la lista
            ListViewItem fila = new ListViewItem(objempleado.Nombres);
            fila.SubItems.Add(objempleado.Categoria);
            //Ponemos To String para mostrar ese valor en el formulario
            fila.SubItems.Add(objempleado.Tardanza.ToString());
            fila.SubItems.Add(objempleado.Atencion.ToString());
            fila.SubItems.Add(objempleado.Calcular_pago().ToString());
            //se agrega esos items al listViewLista con Items.Add(fila)
            listViewLista.Items.Add(fila);
            //Items.Count.ToString() sirve para contar los elementos de listview
            labelEmpleados.Text = listViewLista.Items.Count.ToString();

        }
    }
}
