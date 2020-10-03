using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuator
{
    public partial class FormCalculator : Form
    {

        

        public FormCalculator()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBoxNilaia.Text);
            var b = Convert.ToInt32(textBoxNilaib.Text);

            listHasil.Items.Add(string.Format("hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            listHasil.Items.Add(string.Format("hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            listHasil.Items.Add(string.Format("hasil perkalian: {0} X {1} = {2}", a, b, Perkalian(a, b)));
            listHasil.Items.Add(string.Format("hasil pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }
  
    }
}
