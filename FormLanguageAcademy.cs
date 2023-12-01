using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanguageAcademy
{
    public partial class FormLanguageAcademy : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N42U8KH\SQLEXPRESS;Initial Catalog=LanguageAcademy;Integrated Security=True");
        public FormLanguageAcademy()
        {
            InitializeComponent();
        }

        public void btn_list_Click(object sender, EventArgs e)
        {
            Listed();
            DeleteBoxes();
            MessageBox.Show("Students listed!");
        }
        void Listed()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Students", connect);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataList.DataSource = dataTable;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand add = new SqlCommand("insert into Students (StudentName, StudentLastName, StudentGender, StudentBirthDate, StudentPhone, StudentEMail, StudentCountry) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connect);
            add.Parameters.AddWithValue("@p1", txt_name.Text);
            add.Parameters.AddWithValue("@p2", txt_lastName.Text);
            add.Parameters.AddWithValue("@p3", txt_gender.Text);
            add.Parameters.AddWithValue("@p4", txt_birthDate.Text);
            add.Parameters.AddWithValue("@p5", txt_phone.Text);
            add.Parameters.AddWithValue("@p6", txt_eMail.Text);
            add.Parameters.AddWithValue("@p7", txt_country.Text);
            add.Parameters.AddWithValue("@p8", txt_id.Text);

            if (txt_name.TextLength < 2 || txt_lastName.TextLength < 2)
            {
                MessageBox.Show("Username and surname must be greater than two characters!", "Information", MessageBoxButtons.OK);
            }
            if (txt_phone.TextLength < 10 || txt_phone.TextLength > 10)
            {
                MessageBox.Show("The phone number must consist of ten digits!", "Information", MessageBoxButtons.OK);
            }
            else if (txt_name.TextLength >= 2 && txt_lastName.TextLength >= 2 && txt_phone.TextLength == 10)
            {
                add.ExecuteNonQuery();
                DeleteBoxes();
                connect.Close();
                MessageBox.Show("Student Added!", "Information", MessageBoxButtons.OK);
                DeleteBoxes();
                Refresh();
                Listed();
            }
            connect.Close();
        }

        private void DeleteBoxes()
        {
            txt_name.Text = string.Empty;
            txt_lastName.Text = string.Empty;
            txt_gender.Text = string.Empty;
            txt_birthDate.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_eMail.Text = string.Empty;
            txt_country.Text = string.Empty;
        }

        private void dataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_lastName.Text = dataList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_gender.Text = dataList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_birthDate.Text = dataList.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_phone.Text = dataList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_eMail.Text = dataList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_country.Text = dataList.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand delete = new SqlCommand("Delete from Students where StudentId=@p1", connect);
            delete.Parameters.AddWithValue("@p1", txt_id.Text);
            delete.ExecuteNonQuery();
            DeleteBoxes();
            connect.Close();
            MessageBox.Show("Student Deleted!", "Information", MessageBoxButtons.OK);
            Refresh();
            Listed();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand update = new SqlCommand("Update Students set StudentName=@p1, StudentLastName=@p2, StudentGender=@p3, StudentBirthDate=@p4, StudentPhone=@p5, StudentEMail=@p6, StudentCountry=@p7 where StudentId=@p8", connect);
            update.Parameters.AddWithValue("@p1", txt_name.Text);
            update.Parameters.AddWithValue("@p2", txt_lastName.Text);
            update.Parameters.AddWithValue("@p3", txt_gender.Text);
            update.Parameters.AddWithValue("@p4", txt_birthDate.Text);
            update.Parameters.AddWithValue("@p5", txt_phone.Text);
            update.Parameters.AddWithValue("@p6", txt_eMail.Text);
            update.Parameters.AddWithValue("@p7", txt_country.Text);
            update.Parameters.AddWithValue("@p8", txt_id.Text);

            if (txt_name.TextLength < 2 || txt_lastName.TextLength < 2)
            {
                MessageBox.Show("Username and surname must be greater than two characters!", "Information", MessageBoxButtons.RetryCancel);
            }
            if (txt_phone.TextLength < 10 || txt_phone.TextLength > 10)
            {
                MessageBox.Show("The phone number must consist of ten digits!", "Information", MessageBoxButtons.RetryCancel);
            }
            else if (txt_name.TextLength >= 2 && txt_lastName.TextLength >= 2 && txt_phone.TextLength == 10)
            {
                update.ExecuteNonQuery();
                DeleteBoxes();
                connect.Close();
                MessageBox.Show("Student Updated!", "Information", MessageBoxButtons.OK);
                Refresh();
                Listed();
            }
            connect.Close();

        }

        private void FormLanguageAcademy_Load(object sender, EventArgs e)
        {
            Refresh();
            txt_birthDate.Text = null;
        }

        private void Refresh()
        {
            connect.Open();
            SqlCommand studentId = new SqlCommand("Select Count(StudentId) from Students", connect);
            var studentNum = studentId.ExecuteScalar();
            lbl_num.Text = studentNum.ToString();
            connect.Close();
        }
    }
}
