using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace DeloZBazo
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ocenaPridobljeno = double.Parse(ocena.Text);

            DataSet ds = new DataSet();
            string povNiz = @"Data Source=C:\Users\Payana\Desktop\Faks\PRO3 - vaje\AnAn_Vaje10\filmi.sqlite;";

            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT naslov as NASLOV, leto as LETO, ocena as OCENA FROM filmi WHERE ocena >=" + ocenaPridobljeno, povezava);
            dataAdapter.Fill(ds);
            DataTable tabela = ds.Tables[0];

            prikazPodatkov.DataSource = ds.Tables[0];
        }

        private void potrdi_Click(object sender, EventArgs e)
        {    
            string id = idFilma.Text;
            double nova = double.Parse(novaOcena.Text);

            DataSet ds = new DataSet();
            string povNiz = @"Data Source=C:\Users\Payana\Desktop\Faks\PRO3 - vaje\AnAn_Vaje10\filmi.sqlite;Version=3";
            SQLiteConnection povezava = new SQLiteConnection(povNiz);

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id, naslov, ocena FROM filmi WHERE id =" + id, povezava);
            dataAdapter.Fill(ds);

            SQLiteCommand cmd = new SQLiteCommand("UPDATE filmi SET ocena = " + nova + " WHERE id = " + id, povezava);

            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = builder.GetUpdateCommand(true);

            dataAdapter.UpdateCommand = cmd;
            dataAdapter.AcceptChangesDuringUpdate = true;
            dataAdapter.Update(ds);

            prikazPodatkov2.DataSource = ds.Tables[0];
        }
    }
}
