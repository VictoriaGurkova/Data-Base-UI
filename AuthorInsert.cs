using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDatabase
{
    public partial class AuthorInsert : Form
    {
        public AuthorInsert()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string str_connection = "Data Source=DESKTOP-3LUMPD0;Initial Catalog=Lib;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str_connection);
            conn.Open();

            string insert_sql = "Insert into Author(Full_Name, Pseudonym) values('{0}', '{1}')";

           
            string Full_Name = txtFN.Text;
            string Pseudonym = txtAP.Text;

            string insert_author = string.Format(insert_sql, Full_Name, Pseudonym);

            SqlCommand cmd_insert = new SqlCommand(insert_author, conn);

            cmd_insert.ExecuteNonQuery();

            MessageBox.Show(string.Format("Запись {0} успешно вставлена!", Full_Name), "Сообщение");
        }






     
    }
}
