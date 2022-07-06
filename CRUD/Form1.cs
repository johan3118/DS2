using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diabloide
{
    public partial class Form1 : Form
    {
        List<Personas> Personas = new List<Personas>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void Save()
        {
            var persona = new Personas
            {
                Name = txtName.Text,
                PrimerApellido = txtLastname.Text,
                SegundoApellido = txtLastname2.Text,
                Ocupacion = txtOcupacion.Text,
                Nacionalidad = txtNacionalidad.Text,
                Edad = (DateTime.Now.Year - dtFecha.Value.Year).ToString(),
                Sangre = txtSangre.Text,
                sexo = cbMale.Checked ? "M" : "F",
                DOB = dtFecha.Value
            };

            Personas.Add(persona);

            MessageBox.Show("Se agrego correctamente");

            Emptydatos();

            Getpersonas();
        }

        private void Getpersonas()
        {
            dgPersonas.DataSource = null;
            dgPersonas.DataSource = Personas;

        }

        private void Emptydatos()
        {
            foreach (Control c in gbDatos.Controls)
            {
                if (c is TextBox) {
                    c.Text = String.Empty;
                }
            }
        }

    }
    public class Personas
    {
        public string Name {get; set; }
        public string PrimerApellido { get; set; } 
        public string SegundoApellido { get; set; } 
        public string Ocupacion { get; set; } 
        public string Nacionalidad { get; set; } 
        public string Sangre { get; set; }
        public string Edad { get; set; }
        public DateTime DOB { get; set; }
        public string sexo { get; set; }


    }


}
