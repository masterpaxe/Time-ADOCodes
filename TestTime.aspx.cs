using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace TestTime
{
    public partial class TestTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    string CS = ConfigurationManager.ConnectionStrings["DotunCon"].ConnectionString;
            //    using (SqlConnection con = new SqlConnection(CS))
            //    {
            //        SqlCommand cmd = new SqlCommand("SELECT * FROM product where ProductName like @ProductName", con);
            //        cmd.Parameters.AddWithValue("@ProductName",txtSearch.Text + "%");
            //        con.Open();
            //        SqlDataReader rdr = cmd.ExecuteReader();
            //        GridView1.DataSource = rdr;
            //        GridView1.DataBind();


            //    }
            //}


                if (!IsPostBack)
                {
                    if (DateTime.Now.Hour < 12)
                    {
                        lblTimeOfDay.Text = "Good Morning";
                    }
                    else if (DateTime.Now.Hour < 16)
                    {
                        lblTimeOfDay.Text = "Good Afternoon";
                    }
                    else 
                    {
                        lblTimeOfDay.Text = "Good Evening";
                    }

                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleButton.Checked)
            {
                lblGender.Text = "I am a Male";
            }
            else if (FemaleButton.Checked)
            {
                lblGender.Text = "I am a Female";
            }
            else
            {
                lblGender.Text = "I am unknown";
            }
        }

        protected void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male button selected");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GetProduct_Click(object sender, EventArgs e)
        {
            //string CS = ConfigurationManager.ConnectionStrings["DotunCon"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM product where ProductName like @ProductName", con);
            //    cmd.Parameters.AddWithValue("@ProductName", txtSearch.Text + "%");
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    GridView1.DataSource = rdr;
            //    GridView1.DataBind();


            //}
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ////I Implemented autopostback search
            //string CS = ConfigurationManager.ConnectionStrings["DotunCon"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM product where ProductName like @ProductName", con);
            //    cmd.Parameters.AddWithValue("@ProductName", txtSearch.Text + "%");
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    GridView1.DataSource = rdr;
            //    GridView1.DataBind();


            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //I Implemented autopostback search
            string CS = ConfigurationManager.ConnectionStrings["DotunCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@EmployeeId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);


                con.Open();
                cmd.ExecuteNonQuery();

                string EmpId = outputParameter.Value.ToString();

                lblMessage.Text = "Employee Id = " + EmpId;


            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
            txtSalary.Text = "";
            ddlGender.SelectedValue = "--Select Gender--";
            lblMessage.Text = "";
        }
    }
}