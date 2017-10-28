using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ThePerson.db;

namespace ThePerson {
    public partial class CreatePerson : Form {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=raspisanie;";
        static string query = "SELECT * FROM users";

        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader reader;

        DBManager db;

        public CreatePerson() {
            /*databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;*/
            db = new DBManager();

            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e) {

            var array = db.getPersons();
            
            for (int i = 0; i < array.Le) {

            }
            /*try {

                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();


                if (reader.HasRows) {
                    int i = 0;
                    while (reader.Read()) {

                        //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        //Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };

                        ListViewItem item = new ListViewItem(row[0]);
                        item.SubItems.Add(row[1]);
                        item.SubItems.Add(row[2]);

                        listView.Items.Add(item); 
                    }
                }
                else {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Console.ReadLine();*/
        }

        private void updateBtn_Click(object sender, EventArgs e) {

        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            listView.SelectedItems[0].Remove();
        }
    }
}
