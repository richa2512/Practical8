using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ((Site1)Master).BtnSearch.Click += new EventHandler(btnSearch_Click);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void GetData()
        {
            string source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\cecomp1\Documents\emp.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string select ="select * from tblStudent";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            grdEmp.DataSource = reader;
            grdEmp.DataBind();
            conn.Close();

        }

    }
}