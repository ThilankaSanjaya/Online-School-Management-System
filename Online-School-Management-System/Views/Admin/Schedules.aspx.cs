using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_School_Management_System.Views.Admin
{

    public partial class Schedules : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            showScheduale();
            GetDepartment();
        }
        private void showScheduale()
        {
            string Query = "select Schid as Id ,Department as dep, Day,[8to9]as First,[9to10] as Second,[10to11] as third ,[11to12] as Fourth,[12to1] as Fifth from SchedulTbl";
            SchedualeGrid.DataSource = con.GetData(Query);
            SchedualeGrid.DataBind();
        }

        private void GetDepartment()
        {
            string Query = "select*from DepartmenTbl";
            DepCb.DataTextField = con.GetData(Query).Columns["DepName"].ToString();
            DepCb.DataValueField = con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = con.GetData(Query);
            DepCb.DataBind();

        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepCb.SelectedIndex == -1 || DqyCb.SelectedIndex == -1 || Sub1Cb.SelectedIndex == -1 || Sub2Cb.SelectedIndex == -1 || Sub3Cb.SelectedIndex == -1 || Sub4Cb.SelectedIndex == -1 || Sub5Cb.SelectedIndex == -1)
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    int Department = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Day = DqyCb.SelectedItem.ToString();
                    string Sub1 = Sub1Cb.SelectedItem.ToString();
                    string Sub2 = Sub2Cb.SelectedItem.ToString();
                    string Sub3 = Sub3Cb.SelectedItem.ToString();
                    string Sub4 = Sub4Cb.SelectedItem.ToString();
                    string Sub5 = Sub5Cb.SelectedItem.ToString();
                    string Query = "insert into SchedulTbl values({0},'{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = string.Format(Query, Department, Day, Sub1, Sub2, Sub3, Sub4, Sub5);
                    con.SetData(Query);
                    showScheduale();
                    ClearAll();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        int key = 0;
        protected void SchedualeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepCb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[2].Text;
            DqyCb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[3].Text;
            Sub1Cb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[4].Text;
            Sub2Cb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[5].Text;
            Sub3Cb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[6].Text;
            Sub4Cb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[7].Text;
            Sub5Cb.SelectedItem.Value = SchedualeGrid.SelectedRow.Cells[8].Text;

            if (DepCb.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SchedualeGrid.SelectedRow.Cells[1].Text);
            }
        }


        protected void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepCb.SelectedIndex == -1 || DqyCb.SelectedIndex == -1 || Sub1Cb.SelectedIndex == -1 || Sub2Cb.SelectedIndex == -1 || Sub3Cb.SelectedIndex == -1 || Sub4Cb.SelectedIndex == -1 || Sub5Cb.SelectedIndex == -1)
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    int Department = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Day = DqyCb.SelectedItem.ToString();
                    string Sub1 = Sub1Cb.SelectedItem.ToString();
                    string Sub2 = Sub2Cb.SelectedItem.ToString();
                    string Sub3 = Sub3Cb.SelectedItem.ToString();
                    string Sub4 = Sub4Cb.SelectedItem.ToString();
                    string Sub5 = Sub5Cb.SelectedItem.ToString();
                    string Query = "UPDATE SchedulTbl set Department ='{0}', Day ='{1}',8to9 = '{2}', 9to10 ='{3}', 10to11 = '{4}', 11to12 ='{5}', 12to1 = '{6}', where Schid ={7}";
                    Query = string.Format(Query, Department, Day, Sub1, Sub2, Sub3, Sub4, Sub5, SchedualeGrid.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showScheduale();
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
                if (DepCb.SelectedIndex == -1 || DqyCb.SelectedIndex == -1 || Sub1Cb.SelectedIndex == -1 || Sub2Cb.SelectedIndex == -1 || Sub3Cb.SelectedIndex == -1 || Sub4Cb.SelectedIndex == -1 || Sub5Cb.SelectedIndex == -1)
                {
                    // ErrMsg.InnerText ="Missing Details!!!";
                }
                else
                {
                    int Department = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Day = DqyCb.SelectedItem.ToString();
                    string Sub1 = Sub1Cb.SelectedItem.ToString();
                    string Sub2 = Sub2Cb.SelectedItem.ToString();
                    string Sub3 = Sub3Cb.SelectedItem.ToString();
                    string Sub4 = Sub4Cb.SelectedItem.ToString();
                    string Sub5 = Sub5Cb.SelectedItem.ToString();
                    string Query = "DELETE from SchedulTbl where Schid ={0}";
                    Query = string.Format(Query, SchedualeGrid.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showScheduale();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        protected void ClearAll()
        {
            DepCb.SelectedIndex = -1;
            DqyCb.SelectedIndex = -1;
            Sub1Cb.SelectedIndex = -1;
            Sub2Cb.SelectedIndex = -1;
            Sub3Cb.SelectedIndex = -1;
            Sub4Cb.SelectedIndex = -1;
            Sub5Cb.SelectedIndex = -1;
        }

    }
}