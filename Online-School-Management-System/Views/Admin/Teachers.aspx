<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="Online_School_Management_System.Views.Admin.Teachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row ">
        <div class="col bg-warning">
            <h6 class="text-center">Manage Teachers</h6>
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
                            <label>Teachers Name :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
                            <label>Teachers Email :</label>
                            <input type="email" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Teachers Phone :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
                            <label>Address :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Date of Birth :</label>
                            <input type="date" class="form-control" />
                        </div>
                    </div>
                     <div class="col">
                        <div class="mb-2">
                            <label>Teachers Salary :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>Password :</label>
                            <input type="text" class="form-control" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
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
                        <h5 class="text-center text-danger">Student List</h5>
                    </div>
                </div>
                <asp:GridView runat="server" class="table"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
