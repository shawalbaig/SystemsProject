using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace second_try
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Acer\Desktop\Third year\Second semester\Cmpg 223\second try\second try\App_Data\Credentials.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            UserInfo userClass = new UserInfo();
            String username = tbusername.Text;
            String password = tbpassword.Text;
            String encryptedPassword = userClass.encrypt(password);
            con.Open();
            comm = con.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from Credentials where Password= '" + encryptedPassword + "'and email= '" + username + "'";
            SqlDataAdapter sda = new SqlDataAdapter(comm.CommandText, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Response.Redirect("~/HomePage.aspx");
                con.Close();

            }
            else
            {


                Outputlbl.Text =  ("username or password incorrect");

            }
        }
    }
}