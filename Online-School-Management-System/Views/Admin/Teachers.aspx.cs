using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_School_Management_System.Views.Admin
{
    public partial class Teachers : System.Web.UI.Page
    {
        Models.Functions con;

        public object ErrMsg { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            showTeachers();
        }

        private void showTeachers()
        {
            string Query = "select*from TeachTbl";
            TeachersGrid.DataSource = con.GetData(Query);
            TeachersGrid.DataBind();
        }

        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTeacherName.Value == "" || txtTeacherEmail.Value == ""  || txtTeacherDOB.Value=="" || txtTeacherSalary.Value == "" || txtPassword.Value == "")
                {
                   // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    string Name = txtTeacherName.Value;
                    string Email = txtTeacherEmail.Value;
                    string DOB = txtTeacherDOB.Value;
                    string salary = txtTeacherSalary.Value;
                    string password = txtPassword.Value;
                    string Query = "insert into TeachTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name, Email, DOB, salary, password);
                    con.SetData(Query);
                    showTeachers();
                    ClearAll();
                }

            }
            catch(Exception ex)
            {
                throw;
            }

            

        }

        int key = 0;
        protected void TeachersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTeacherName.Value = TeachersGrid.SelectedRow.Cells[2].Text;
            txtTeacherEmail.Value = TeachersGrid.SelectedRow.Cells[3].Text;
            //txtTeacherDOB.Value = TeachersGrid.SelectedRow.Cells[4].Text;
            txtTeacherSalary.Value = TeachersGrid.SelectedRow.Cells[5].Text;
            txtPassword.Value = TeachersGrid.SelectedRow.Cells[6].Text;

            if(txtTeacherName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TeachersGrid.SelectedRow.Cells[1].Text);
            }
        }


        protected void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTeacherName.Value == "" || txtTeacherEmail.Value == ""  || txtTeacherSalary.Value == "" || txtPassword.Value == "")
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    string Name = txtTeacherName.Value;
                    string Email = txtTeacherEmail.Value;
                    string DOB = txtTeacherDOB.Value;
                    string salary = txtTeacherSalary.Value;
                    string password = txtPassword.Value;
                    string Query = "UPDATE TeachTbl set TName ='{0}', TEmail ='{1}',TDOB = '{2}', TSalary ='{3}', TPass = '{4}'";
                    Query = string.Format(Query, Name, Email, DOB, salary, password);
                    con.SetData(Query);
                    showTeachers();
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
                if (txtTeacherName.Value == "" || txtTeacherEmail.Value == ""  || txtTeacherSalary.Value == "" || txtPassword.Value == "")
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    string Name = txtTeacherName.Value;
                    string Email = txtTeacherEmail.Value;
                    string DOB = txtTeacherDOB.Value;
                    string salary = txtTeacherSalary.Value;
                    string password = txtPassword.Value;
                    string Query = "DELETE from TeachTbl where Tid ={0}";
                    Query = string.Format(Query, TeachersGrid.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showTeachers();
                }

            }
            catch (Exception ex)
            {
                throw;
            }



        }


        protected void  ClearAll()
        {
            txtTeacherName.Value = "";
            txtTeacherEmail.Value = "";
            txtTeacherDOB.Value = "";
            txtTeacherSalary.Value = "";
            txtPassword.Value = "";
        }
    }
}