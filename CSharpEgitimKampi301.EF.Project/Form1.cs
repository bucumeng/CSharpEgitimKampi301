using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EF.Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities(); //Nesne örneği türettik
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi.");

        }

        private void btnList_Click(object sender, EventArgs e)
        {
                var values = db.Guide.ToList();
                dataGridView1.DataSource = values;
            
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.Guide.Where(x =>x.GuideId==id).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
