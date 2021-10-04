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
    public partial class Register : System.Web.UI.Page
    {

        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Acer\Desktop\Third year\Second semester\Cmpg 223\second try\second try\App_Data\Credentials.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void btnRegFirst_Click(object sender, EventArgs e)
        {
            
            string title = textboxtitle.Items[lbTitle.SelectedIndex].ToString();
            string name = tbfirstname.Text;
            String surname = tbsurname.Text;
            String Phone =tbcellphone.Text;
            String eMail = tbemailaddress.Text;
            String password = tbpassword.Text;
            String confirm = tbconfirmPassword.Text;

            UserInfo userClass = new UserInfo();

            string securePassword = userClass.encrypt(password);




            if (password == confirm)
            {


                con.Open();
                comm = con.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select * from Credentials where Password= '" + securePassword + "'and Email= '" + eMail + "'";
                SqlDataAdapter sda = new SqlDataAdapter(comm.CommandText, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    messagebox.Show("Username or password already exists");
                }
                else
                {
                    comm.CommandText = "insert INTO Credentials values('" + eMail.ToString() + "','" + title + "','" + name + "','" + surname + "','" + Phone.ToString() + "','" + securePassword.ToString() + "')";
                    comm.ExecuteNonQuery();
                    con.Close();


                }

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
    }
}