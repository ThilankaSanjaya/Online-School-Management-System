<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Marks.aspx.cs" Inherits="Online_School_Management_System.Views.Admin.Marks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row ">
        <div class="col bg-warning">
            <h6 class="text-center">Manage Marks</h6>
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
                            <label>Student Name :</label>
                            <asp:DropDownList runat="server" CssClass="form-control">

                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
                            <label>Subject :</label>
                            <asp:DropDownList runat="server" CssClass="form-control">

                            </asp:DropDownList>  
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Marks :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Comments :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col d-grid">
                        <asp:Button Text="Edit" runat="server" CssClass="btn btn-warning btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" CssClass="btn btn-primary btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" CssClass="btn btn-danger btn-block" />
                    </div>

                </div>
            </div>
            <div class="col-7">
                <div class="row">
                    <div class="col">
                        <h5 class="text-center text-danger">Marks List</h5>
                    </div>
                </div>
                <asp:GridView runat="server" class="table"></asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
