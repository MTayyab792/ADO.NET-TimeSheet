<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewTasks.aspx.cs" Inherits="Computan.Timesheet.v2.Tasks.ViewTasks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />

        <div class="row">

            <div class="well">
                <fieldset>
                    <legend>List of All Tasks
                    </legend>
                </fieldset>
                <br />
                <div>
                    <asp:Button ID="btnaddtasks" runat="server" Text="Add New Tasks" CssClass=" btn btn-info" OnClick="btnaddtasks_Click" />
                </div>


    <div class ="main">
    <asp:GridView ID="GridView" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" OnRowDataBound="GridView_RowDataBound" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="TaskDate" HeaderText="Task Date" />           
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Details" HeaderText="Details" />
            <asp:BoundField DataField="TimeInMinutes" HeaderText="Time In Minutes" />
            <asp:BoundField DataField="CreatedOnUTC" HeaderText="Created On UTC" />
            <asp:BoundField DataField="UpdatedOnUTC" HeaderText="Updated On UTC" />
            <asp:BoundField DataField="ProjectId" HeaderText="Project" />
            <asp:BoundField DataField="SkillId" HeaderText="Skill" />

           
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
    
</asp:Content>
