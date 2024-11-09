using appollosxsxsxolsxlosl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appollosxsxsxolsxlosl
{
    public partial class Form3 : Form
    {

        DataLayer dataLayer = new DataLayer();
        private DataTable currentDataTable;
        string currentTableName;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LoadTable(string tableName)
        {
            dataGridView1.DataSource = FillDatas($"SELECT * FROM {tableName}");
            currentDataTable = (DataTable)dataGridView1.DataSource; // Сохраняем текущую таблицу
            currentTableName = currentDataTable.TableName;
        }

        public DataTable FillDatas(string query)
        {
            DataTable dataTable = new DataTable();
            using (var command = new SqlCommand(query, dataLayer.GetConnection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }




        private void BtnTablePlayers_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnTableMResults_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnTableTournaments_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnTableTeams_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnTableGAreas_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnTableCoaches_Click(object sender, EventArgs e)
        {
            
        }





        //////////////////
        private void BtnTableTeams_Click(object sender, EventArgs e)
        {
            LoadTable("Applications");
        }

        private void BtnTablePlayers_Click(object sender, EventArgs e)
        {
            LoadTable("Comments");
        }

        private void BtnTableTournaments_Click(object sender, EventArgs e)
        {
            LoadTable("Curators");
        }

        private void BtnTableMResults_Click(object sender, EventArgs e)
        {
            LoadTable("Exhibitions");
        }

        private void BtnTableGAreas_Click_1(object sender, EventArgs e)
        {
            LoadTable("Participants");
        }

        
    }
}
