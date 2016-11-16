<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Computan.Timesheet.v2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <br />
        <div class="row">

            <div class="well">
                <fieldset>
                    <legend>List of All Projects
                    </legend>
                </fieldset>
          

<br />  
    <asp:Button ID="Add_Record" runat="server" CssClass=" btn btn-info" OnClick="Add_Record_Click" Text="Add New Project" />
<br />

<div class ="main">
    <asp:GridView ID="GridView" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" OnRowDataBound="GridView_RowDataBound" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="IsActive" HeaderText="Status" />
            <asp:BoundField DataField="CreatedOn" HeaderText="Created On" />
            <asp:BoundField DataField="LastUpdatedOn" HeaderText="Last Updated On" />
            <%--<asp:BoundField DataField="IpUsed" HeaderText="IpUsed" />--%>
            <%--<asp:BoundField DataField="UserId" HeaderText="UserId" />--%>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="hlUpdate" CssClass="btn btn-success" runat="server"></asp:HyperLink>

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


  <%--  <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>
