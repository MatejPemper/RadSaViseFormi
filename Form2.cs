using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSViseFormi
{
    public partial class FormUnosNovogStudenta : Form
    {
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void FormUnosNovogStudenta_Load(object sender, EventArgs e)
        {
         
    }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();

            student1.Ime = textBoxIme.Text;

            student1.Prezime = textBoxPrezime.Text;

            student1.BrojIndeksa = textBoxBrojIndeksa.Text;

            student1.Smjer = comboBoxSmjer.SelectedItem.ToString();

            student1.DatumRodjenja =
            dateTimePickerDatumRodjenja.Value;

            DialogResult = DialogResult.OK;

        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
    class Student
    {
        private string ime, prezime, smjer, brojIndeksa;
        private DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        
        public override string ToString()

        {

            return Ime + " " + Prezime + " " +
            BrojIndeksa + " " +
            DatumRodjenja.ToShortDateString() + " " + Smjer;

        }       
    }
}
