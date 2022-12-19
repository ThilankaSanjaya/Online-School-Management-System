using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_School_Management_System.Views.Admin
{
    public partial class Departmets : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            showDepartment();
        }

        private void showDepartment()
        {
            string Query = "select*from DepartmenTbl";
            DepartmentGrid.DataSource = con.GetData(Query);
            DepartmentGrid.DataBind();
        }

        protected void Depsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepName.Value == "" || txtRemarks.Value == "")
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    string DepName = txtDepName.Value;
                    string DepRemark = txtRemarks.Value;
                    string Query = "insert into DepartmenTbl values('{0}','{1}')";
                    Query = string.Format(Query, DepName, DepRemark);
                    con.SetData(Query);
                    showDepartment();
                    ClearAll();
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        int key = 0;
        protected void DepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDepName.Value = DepartmentGrid.SelectedRow.Cells[2].Text;
            txtRemarks.Value = DepartmentGrid.SelectedRow.Cells[3].Text;

            if (txtDepName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DepartmentGrid.SelectedRow.Cells[1].Text);
            }
        }


        protected void DepEdit_Click(object sender, EventArgs e)
            {
                try
                {
                    if (txtDepName.Value == "" || txtRemarks.Value == "")
                    {
                        // ErrMsg.InnerText ="Missing Details!!!";
                    }
                    else
                    {
                        string DepName = txtDepName.Value;
                        string DepRemark = txtRemarks.Value;
                        string Query = "UPDATE DepartmenTbl set DepName ='{0}', DepRemark ='{1}'";
                        Query = string.Format(Query, DepName, DepRemark);
                        con.SetData(Query);
                        showDepartment();
                        ClearAll();
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepName.Value == "" || txtRemarks.Value == "")
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    string DepName = txtDepName.Value;
                    string DepRemark = txtRemarks.Value;
                    string Query = "DELETE from DepartmenTbl where Depid ={0}";
                    Query = string.Format(Query, DepartmentGrid.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showDepartment();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void ClearAll()
        {
            txtDepName.Value = "";
            txtRemarks.Value = "";
        }

    }
}