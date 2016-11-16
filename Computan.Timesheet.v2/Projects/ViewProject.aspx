<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.ViewProject" %>--%>

<%@ Page Title="ViewProject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.ViewProject" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
    </head>
    <body>

        <br />
        <div class="row">

            <div class="well">
                <fieldset>
                    <legend>List of All Projects
                    </legend>
                </fieldset>
                <br />
                <div>
                    <asp:Button ID="Button1" runat="server" CssClass=" btn btn-info" OnClick="Button1_Click" Text="Add New Project " />
                </div>


                <div class="main">
                    <asp:GridView ID="GridView" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" OnRowDataBound="GridView_RowDataBound" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                        <Columns>
                            <asp:BoundField DataField="Title" HeaderText="Title"/>
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="IsActive" HeaderText="Status" />
                            <asp:BoundField DataField="CreatedOn" HeaderText="Created On" />
                            <asp:BoundField DataField="LastUpdatedOn" HeaderText="Last Updated On" />
                            <%--  <asp:BoundField DataField="IpUsed" HeaderText="IpUsed" />--%>
                            <%--<asp:BoundField DataField="UserId" HeaderText="UserId" />--%>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="hlUpdate" CssClass="btn btn-success" Text="update" runat="server"></asp:HyperLink>

                                </ItemTemplate>

                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="hlDelete" CssClass="btn btn-danger" runat="server"></asp:HyperLink>
                                </ItemTemplate>

                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>

                </div>
            </div>
        </div>

    </body>
    </html>
</asp:Content>
