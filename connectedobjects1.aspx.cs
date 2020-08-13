using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace sqlwebapp
{
    public partial class connectedobjects1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M2P443U;Initial Catalog=dotnet;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public void ShowGrid()
        {
            conn.Open();
            cmd = new SqlCommand("select * from employeetable", conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsalary", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("UpdateEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsalary", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from employeetable where empid="+txtEmpId.Text+"",conn);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }
    }
}