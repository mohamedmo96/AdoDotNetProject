using System.Data;
using System.Data.SqlClient;

namespace lap_AdoDotNetday1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionStr = "server=.\\SQLEXPRESS;Database=ITI;Trusted_Connection=true;TrustServerCertificate=true";
            connection = new SqlConnection(connectionStr);

        }

        private void Form1_load(object sender, EventArgs e)
        {
            GetAllCourse();
            GetTopic();


        }
        void GetAllCourse()
        {


            SqlCommand cmd = connection.CreateCommand();


            cmd.CommandText = "select[Crs_Id],[Crs_Name],[Crs_Duration],[Top_Id] from Course;";

            DataTable dt = new DataTable();
            try
            {
                connection.Open();


                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong");
            }
            finally
            {

                connection.Close();
            }
            // display data

            dgv_Course.DataSource = dt;
        }
        void ClearInputs()
        {
            txt_co.Text = "";
            num_du.Value = 0;

            cm_To.SelectedValue = 2;
        }
        void GetTopic()
        {
            //define command 
            SqlCommand cmd = new SqlCommand("select Top_Name,Top_Id from Topic", connection);

            // open connection
            connection.Open();
            // execute command
            SqlDataReader reader = cmd.ExecuteReader();

            // retrieve data
            DataTable dt = new DataTable();
            dt.Load(reader);

            // close connection
            connection.Close();

            // display data
            cm_To.DataSource = dt;

            cm_To.DisplayMember = "Top_Name";
            cm_To.ValueMember = "Top_Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            //define command
            SqlCommand cmd = new SqlCommand($"insert into Course([Crs_Name],[Crs_Duration],[Top_Id])  values('{txt_co.Text}',{num_du.Value},{cm_To.SelectedValue})", connection);
            int rowsEffected = 0;
            try
            {
                //open connection
                connection.Open();
                // execute command
                rowsEffected = cmd.ExecuteNonQuery();
                // retrieve data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course wasn't added");
            }
            finally
            {
                // close connection
                connection.Close();
            }

            // display data
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data added.");
                GetAllCourse();
            }
            ClearInputs();
        }

        int id;


        private void dgv_Course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_Course.Rows[e.RowIndex];

            id = (int)row.Cells[0].Value;
            txt_co.Text = row.Cells[1].Value.ToString();
            num_du.Value = (int)((row.Cells[2].Value == DBNull.Value) ? 0 : row.Cells[2].Value);

            cm_To.SelectedValue = (int)row.Cells[3].Value;

        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Course set [Crs_Name]=@Cnume,[Crs_Duration]=@Du,[Top_Id]=@toid where[Crs_Id] =@id", connection);
            cmd.Parameters.AddWithValue("Cnume", txt_co.Text);
            cmd.Parameters.AddWithValue("Du", num_du.Value);
            cmd.Parameters.AddWithValue("toid", cm_To.SelectedValue);
            cmd.Parameters.AddWithValue("id", id );

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Edit was done");
                GetAllCourse();
            }

            ClearInputs();
        }



        private void btn_del_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Course where Crs_Id=@id; ", connection);

            cmd.Parameters.AddWithValue("id", id);

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data deleted");
                GetAllCourse();
            }
            ClearInputs();
        }

    }
}
