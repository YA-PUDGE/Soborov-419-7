using appollosxsxsxolsxlosl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appollosxsxsxolsxlosl
{
    public partial class Form2 : Form
    {
        DataLayer dataLayer = new DataLayer();
        private DataTable currentDataTable; // Для хранения текущей таблицы данных
        string currentTableName;
        int n;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Загружаем данные для таблицы "Teams" по умолчанию
            LoadTable("Applications");
        }

        // Метод для загрузки данных в DataGridView
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

        // Кнопки для выбора таблицы
        private void BtnTablePlayers_Click(object sender, EventArgs e)
        {

        }
        private void BtnTableTeams_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTableTournaments_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTableMResults_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTableGAreas_Click(object sender, EventArgs e)
        {
            

        }
        private void BtnTableCoaches_Click(object sender, EventArgs e)
        {
            


        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
                p.PlayerName AS 'Игрок',
                t.TeamName AS 'Команда',
                t.Region AS 'Регион' -- Добавлен оператор SELECT
            FROM 
                Players p
            JOIN
                Teams t ON t.TeamID = p.TeamID;
            ";



            dataGridView2.DataSource = FillDatas(query);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (n == 1)
            {
                try
                {
                    string cName = textBox1.Text;
                    string Spec = textBox2.Text;
                    string Exp = textBox3.Text;

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Coaches (CoachName, Speciality, Experience) VALUES ('{cName}', '{Spec}', {Exp})";
                    FillDatas(query);
                    LoadTable("Coaches");
                }
                catch
                {
                }
            }

            if (n == 2)
            {
                try
                {
                    string aName = textBox1.Text;
                    string Loc = textBox2.Text;
                    string Cap = textBox3.Text;

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Gaming_Areas (AreaName, Location, Capacity) VALUES ('{aName}', '{Loc}', '{Cap}')";
                    FillDatas(query);
                    LoadTable("Gaming_Areas");
                }
                catch
                {
                }
            }

            if (n == 3)
            {
                try
                {
                    string tourId = textBox1.Text;
                    string team1Id = textBox2.Text;
                    string team2Id = textBox3.Text;
                    string wID = textBox4.Text;
                    string mDate = textBox5.Text;
                    string Sc = textBox6.Text;

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Match_Results (TournamentID, Team1ID, Team2ID, WinnerID, MatchDate, Score) VALUES ('{tourId}', '{team1Id}', '{team2Id}', '{wID}', {mDate}, '{Sc})";
                    FillDatas(query);
                    LoadTable("Match_Results");
                }
                catch
                {
                }
            }

            if (n == 4)
            {
                try
                {
                    string pName = textBox1.Text;
                    string nick = textBox2.Text;
                    string role = textBox3.Text;
                    string age = textBox4.Text;
                    string tID = textBox5.Text;

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Players (PlayerName, Nickname, Role, Age, TeamID) VALUES ('{pName}', '{nick}', '{role}', '{age}','{tID}')";
                    FillDatas(query);
                    LoadTable("Players");
                }
                catch
                {
                }
            }

            if (n == 5)
            {
                try
                {
                    string tName = textBox1.Text;
                    string tLog = textBox2.Text;
                    string reg = textBox3.Text;
                    DateTime foundedDate;
                    bool success = DateTime.TryParse(textBox4.Text, out foundedDate);

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Teams (TeamName, TeamLogo, Region, FoundedDate) VALUES ('{tName}', '{tLog}', {reg}, '{foundedDate:yyyy-MM-dd}')";

                    FillDatas(query);
                    LoadTable("Teams");
                }
                catch
                {
                }
            }

            if (n == 6)
            {
                try
                {
                    string tourName = textBox1.Text;
                    string game = textBox2.Text;
                    string sDate = textBox3.Text;
                    string eDate = textBox4.Text;
                    string pPool = textBox5.Text;
                    string Loc = textBox6.Text;

                    // Формируем SQL-запрос с использованием параметров
                    string query = $"INSERT INTO Tournaments (TournamentName, Game, StartDate, EndDate, PrizePool, Location) VALUES ('{tourName}', '{game}', {sDate}, {eDate}' , '{pPool}' , '{Loc}')";
                    FillDatas(query);
                    LoadTable("Tournaments");
                }
                catch
                {

                }
            }

        }

        private void BtnTableTeams_Click_1(object sender, EventArgs e)
        {
            LoadTable("Applications");



            label1.Text = "Название команды";
            label2.Text = "Лого команды";
            label3.Text = "Регион";
            label4.Text = "Дата основания";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;


            label5.Visible = false;
            label6.Visible = false;

            n = 5;
        }

        private void BtnTablePlayers_Click_1(object sender, EventArgs e)
        {
            LoadTable("Comments");


            label1.Text = "Имя игрока";
            label2.Text = "Никнэйм";
            label3.Text = "Роль";
            label4.Text = "Возраст";
            label5.Text = "Id команды";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            label6.Visible = false;

            currentTableName = "Players";

            n = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (n == 1)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  Coaches where CoachId =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Coaches");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }

            if (n == 2)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  where AreaID =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Gaming_Areas");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }

            if (n == 3)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  where MatchID =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Match_Results");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }

            if (n == 4)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  where PlayerID =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Players");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }

            if (n == 5)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  where TeamID =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Teams");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }

            if (n == 6)
            {
                string IDforDrop = textBox7.Text;
                // Формируем SQL-запрос с использованием параметров
                string query = $"Delete  from  where TournamentID =  '{IDforDrop}'";
                FillDatas(query);
                LoadTable("Tournaments");
            }
            else
            {
                MessageBox.Show("Кликните на кнопку нужной таблицы");
            }
        }

        private void BtnTableTournaments_Click_1(object sender, EventArgs e)
        {
            LoadTable("Curators");



            label1.Text = "Название турнира";
            label2.Text = "Игра";
            label3.Text = "Дата начала турнира";
            label4.Text = "Дата окончания турнира";
            label5.Text = "Призовой фонд";
            label6.Text = "Место проведения";

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            n = 6;
        }

        private void BtnTableMResults_Click_1(object sender, EventArgs e)
        {
            LoadTable("Exhibitions");



            label1.Text = "Id турнира";
            label2.Text = "Id первой команды";
            label3.Text = "Id второй команды";
            label4.Text = "Id победителя";
            label5.Text = "Дата матча";
            label6.Text = "Счет";

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            currentTableName = "Match_Results";
            n = 3;
        }

        private void BtnTableGAreas_Click_1(object sender, EventArgs e)
        {
            LoadTable("Participants");
            n = 2;

            label1.Text = "Имя арены";
            label2.Text = "Локация";
            label3.Text = "Вместимость";
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            currentTableName = "Gaming_Areas";
        }

        
    }


    // Кнопка "Сохранить изменения"




}

