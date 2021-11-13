using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string primerTxt = txtPrincipal.Text;
            string secondTxt = txtSecundario.Text;

            // Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");
            //Match match = regex.Match(primerTxt);

            //@"^(.{0,7}|[^0-9]*|[^A-Z])$"
            //Regex regex = new Regex("@^((?=.*/d)(?=.*[A - Z])(?=.*/W).{ 8,8}))$");
            Regex regex = new Regex(@"^[0-9a-zA-Z´=%\@#$&()=¿?\\\/<>´¨¡!*.;_+:-]+$");
            if (regex.IsMatch(primerTxt) && primerTxt == secondTxt) { MessageBox.Show("Correcto Contraseña Valida"); }
            else { MessageBox.Show("hola tu contraseña es no valida"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
