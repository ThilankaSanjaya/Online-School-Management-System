<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Departmets.aspx.cs" Inherits="Online_School_Management_System.Views.Admin.Departmets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row ">
        <div class="col bg-warning">
            <h6 class="text-center">Manage Departments</h6>
        </div>
        <div class="row">
            <div class="col-5">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <img src="../../Assets/Images/teacher.png" />
                    </div>
                    <div class="col"></div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Department Name :</label>
                            <input type="text" class="form-control" runat="server" id="txtDepName"/>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
                            <label>Remarks :</label>
                            <input type="text" class="form-control" runat="server" id="txtRemarks"/>
                        </div>
                    </div>
                </div>
                  <div class="row mt-5">
                    <div class="col d-grid">
                        <asp:Button Text="Update" id="Depedit" Onclick="DepEdit_Click"  runat="server" CssClass="btn btn-warning btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" id="DepSave" Onclick="Depsave_Click" runat="server" CssClass="btn btn-primary btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" id="Depdelete" runat="server" OnClick="Delete_Click" CssClass="btn btn-danger btn-block" />
                    </div>

                </div>
            </div>
            <div class="col-7">
                <div class="row">
                    <div class="col">
                        <h5 class="text-center text-danger">Department List</h5>
                    </div>
                </div>
                <asp:GridView runat="server" class="table" ID="DepartmentGrid" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" UseAccessibleHeader="False" AutoPostBack = "true"  OnSelectedIndexChanged = "DepartmentList_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
            </div>
        </div>
    </div>
</asp:Content>
