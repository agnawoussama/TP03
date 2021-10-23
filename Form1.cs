using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TP03
{
    public partial class Form1 : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {            
            try
            {
                string requette = @"INSERT INTO ville VALUES (@nom, @pays)";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                cmd.Parameters.AddWithValue("@pays", txtbx_pays.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Reussi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
                liste_Villes();
            }                           
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = @"UPDATE ville SET Nom_Ville = @nom, Pays = @pays WHERE Id_Ville = @id";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@id", txtbx_id.Text);
                cmd.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                cmd.Parameters.AddWithValue("@pays", txtbx_pays.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification Reussi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
                liste_Villes();
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = @"DELETE from ville WHERE Id_Ville = @id";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@id", txtbx_id.Text);
                cmd.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                cmd.Parameters.AddWithValue("@pays", txtbx_pays.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppression Reussi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
                liste_Villes();
            }
        }

        private void btnVid_Click(object sender, EventArgs e)
        {
            txtbx_id.Text = "";
            txtbx_nom.Text = "";
            txtbx_pays.Text = "";
            //dataGridView1.DataSource = null;

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voules sss","Quitter",MessageBoxButtons.YesNo)==DialogResult.Yes )
            {
                Close();
            }
        }

        private void liste_Villes()
        {
            try
            {
                string requette = @"SELECT * FROM ville";
                con.Open();
                cmd = new SqlCommand(requette, con);
                dr = cmd.ExecuteReader();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            liste_Villes();
        }

        private void btn_rech_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = @"SELECT * FROM ville WHERE Id_Ville = @id OR Nom_Ville LIKE @nom";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@id", txtbx_id.Text);
                cmd.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                dr = cmd.ExecuteReader();
                
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_rechSlct_Click(object sender, EventArgs e)
        {
            liste_Villes();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtbx_id.Text
                    || dataGridView1.Rows[i].Cells[1].Value.ToString() == txtbx_nom.Text)
                {
                    dataGridView1.Rows[i].Selected = true;
                }
            }
        }
    }
}
