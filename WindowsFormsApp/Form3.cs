using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form3()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
        private void ClearFeilds()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtCity.Clear();
            txtSal.Clear();
        }

        private DataSet GetAllEmployees()
        {
            string qry = "select * from employee";
            da = new SqlDataAdapter(qry, con);
            // add PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // scb will track the DataSet & generate the qry --> assign to DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is the name given to the table which is in the DataSet
            // if not given then it will take default name is [0]
            //da.Fill(ds);
            da.Fill(ds, "emp");
            return ds;

        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                // create new row to add record
                DataRow row = ds.Tables["emp"].NewRow();
                row["name"] = txtEmpName.Text;
                row["city"] = txtCity.Text;
                row["salary"] = txtSal.Text;
                //attach row to the emp table
                ds.Tables["emp"].Rows.Add(row);
                int result = da.Update(ds.Tables["emp"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    txtEmpName.Text = row["name"].ToString();
                    txtCity.Text = row["city"].ToString();
                    txtSal.Text = row["salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds= GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    row["name"] = txtEmpName.Text;
                    row["city"] = txtCity.Text;
                    row["salary"] = txtSal.Text;

                    int result = da.Update(ds.Tables["emp"]);
                    if (result >=1) {
                        MessageBox.Show("record updated");
                        ClearFeilds();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if(row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["emp"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("record deleted");
                        ClearFeilds();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }catch( Exception ex)
            {
                MessageBox.Show (ex.Message );
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            ds=GetAllEmployees();
            dataGridView1.DataSource = ds.Tables["emp"];
        }
    }
}
