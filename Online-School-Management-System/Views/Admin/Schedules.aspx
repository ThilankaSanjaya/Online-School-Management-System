<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Schedules.aspx.cs" Inherits="Online_School_Management_System.Views.Admin.Schedules" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row ">
        <div class="col bg-warning">
            <h6 class="text-center">Manage Time Table</h6>
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
                            <asp:DropDownList runat="server" id="DepCb" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-2">
                            <label>Day :</label>
                            <asp:DropDownList runat="server" id="DqyCb" CssClass="form-control">
                                <asp:ListItem>Monday</asp:ListItem>
                                <asp:ListItem>Tuesday</asp:ListItem>
                                <asp:ListItem>Wednesday</asp:ListItem>
                                <asp:ListItem>Thursday</asp:ListItem>
                                <asp:ListItem>Friday</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>8AM-9AM</label>
                            <asp:DropDownList runat="server" id="Sub1Cb" CssClass="form-control">
                                <asp:ListItem>Maths</asp:ListItem>
                                <asp:ListItem>English</asp:ListItem>
                                <asp:ListItem>Hindi</asp:ListItem>
                                <asp:ListItem>Sinhala</asp:ListItem>
                                <asp:ListItem>History</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                     <div class="col">
                        <div class="mb-2">
                            <label>9AM-10AM</label>
                            <asp:DropDownList runat="server" id="Sub2Cb" CssClass="form-control">
                                <asp:ListItem>Maths</asp:ListItem>
                                <asp:ListItem>English</asp:ListItem>
                                <asp:ListItem>Hindi</asp:ListItem>
                                <asp:ListItem>Sinhala</asp:ListItem>
                                <asp:ListItem>History</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>10AM-11AM</label>
                            <asp:DropDownList runat="server" id="Sub3Cb" CssClass="form-control">
                                <asp:ListItem>Maths</asp:ListItem>
                                <asp:ListItem>English</asp:ListItem>
                                <asp:ListItem>Hindi</asp:ListItem>
                                <asp:ListItem>Sinhala</asp:ListItem>
                                <asp:ListItem>History</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                     <div class="col">
                        <div class="mb-2">
                            <label>11AM-12PM</label>
                            <asp:DropDownList runat="server" id="Sub4Cb" CssClass="form-control">
                                <asp:ListItem>Maths</asp:ListItem>
                                <asp:ListItem>English</asp:ListItem>
                                <asp:ListItem>Hindi</asp:ListItem>
                                <asp:ListItem>Sinhala</asp:ListItem>
                                <asp:ListItem>History</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row mt-2">
                    <div class="col">
                        <div class="mb-2">
                            <label>12PM-1PM</label>
                            <asp:DropDownList runat="server" id="Sub5Cb" CssClass="form-control">
                                <asp:ListItem>Maths</asp:ListItem>
                                <asp:ListItem>English</asp:ListItem>
                                <asp:ListItem>Hindi</asp:ListItem>
                                <asp:ListItem>Sinhala</asp:ListItem>
                                <asp:ListItem>History</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                     <div class="col">
                        <div class="mb-2">
                        </div>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col d-grid">
                        <asp:Button Text="Edit" runat="server" id="Edit" CssClass="btn btn-warning btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" id="Save" OnClick="SaveBtn_Click" CssClass="btn btn-primary btn-block" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" id="Delete" CssClass="btn btn-danger btn-block" />
                    </div>

                </div>
            </div>
            <div class="col-7">
                <div class="row">
                    <div class="col">
                        <h5 class="text-center text-danger">Scheduale List</h5>
                    </div>
                </div>
                    <asp:GridView runat="server" class="table" ID="SchedualeGrid" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" UseAccessibleHeader="False" AutoPostBack = "true"  OnSelectedIndexChanged = "SchedualeList_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
