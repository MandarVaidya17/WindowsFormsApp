using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            con=new SqlConnection(constr);
        }

        private void ClearFeilds()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtCity.Clear();
            txtSal.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into employee values(@name,@city,@salary)";
                cmd=new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name",txtEmpName.Text);
                cmd.Parameters.AddWithValue("@city",txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSal.Text);
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record INserted");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFeilds();
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update employee set name=@name,city=@city,salary=@salary where id=@id";
                cmd=new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSal.Text);
                cmd.Parameters.AddWithValue("@id",txtEmpId.Text);

                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result >= 1)
                {
                    MessageBox.Show("Record updated");
                    ClearFeilds();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from employee where id=@id";
                cmd=new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id",txtEmpId.Text);
                con.Open() ;    

                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtEmpName.Text = dr["name"].ToString();
                        txtCity.Text = dr["city"].ToString();
                        txtSal.Text = dr["salary"].ToString() ;
                    }
                }else
                {
                    MessageBox.Show("Record not found");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from employee where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                con.Open();

                int result=cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearFeilds();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from employee";
                cmd=new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
