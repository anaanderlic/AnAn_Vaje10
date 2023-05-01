using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Nobel
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> prevod = new Dictionary<string, string>()
            {
                {"Chemistry", "Kemija"},
                {"Peace", "Mir"},
                {"Medicine", "Medicina"},
                {"Literature", "Literatura"},
                {"Physics", "Fizika" },
                {"Economics", "Ekonomija"}
            };

        private String povezovalniNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";

        public Form1()
        {

            InitializeComponent();
        }

        private async void prikaziKlik(object sender, EventArgs e)
        {
            poljeRezultati.Text = "";

            if ((vnosLeto.Text == "") || (vnosPodrocja.CheckedItems.Count == 0))
            {
                MessageBox.Show("Vnesite vse podatke!", "Napaka");
                return;
            }

            NpgsqlConnection povezava = new NpgsqlConnection(povezovalniNiz);
            String sqlUkaz = "Select * FROM Nobel";
            NpgsqlCommand ukaz = new NpgsqlCommand(sqlUkaz, povezava);

            await Task.Delay(5000);

            povezava.Open();
            NpgsqlDataReader izvedba = ukaz.ExecuteReader();

            while (izvedba.Read())
            {
                string področje = izvedba["subject"].ToString();
                int leto = izvedba.GetInt32(0);
                string dobitnik = izvedba.GetString(2);
                string podr = področje;

                if (prevod.ContainsKey(področje) && (leto == int.Parse(vnosLeto.Text)) && (vnosPodrocja.CheckedItems.Contains(prevod[področje])))
                {
                    podr = prevod[področje]; 
                    poljeRezultati.AppendText(String.Format("Leta {0} je nagrado za področje {1} dobil {2}.", leto, podr, dobitnik));
                    poljeRezultati.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
