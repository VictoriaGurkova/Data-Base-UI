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
    public partial class BookInsert : Form
    {
        public BookInsert()
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

            string insert_sql = "Insert into Book(Author_ID, Category_ID, Title) values({0}, {1}, '{2}')";

            int Author_ID = Convert.ToInt32(txtAID.Text);
            int Category_ID = Convert.ToInt32(txtCID.Text);
            string Title = txtTitle.Text;

            string insert_book = string.Format(insert_sql, Author_ID, Category_ID, Title);

            SqlCommand cmd_insert = new SqlCommand(insert_book, conn);

            cmd_insert.ExecuteNonQuery();

            MessageBox.Show(string.Format("Запись {0} успешно вставлена!", Title), "Сообщение");
        }


    }
}
