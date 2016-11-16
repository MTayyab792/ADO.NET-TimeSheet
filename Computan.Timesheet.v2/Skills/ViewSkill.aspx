<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.ViewSkill" %>--%>

<%@ Page Title="AddSkill" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.ViewSkill" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>View Skill</title>
</head>
<body>

     <br />
        <div class="row">

            <div class="well">
                <fieldset>
                    <legend>List of the All Skills
                    </legend>
                </fieldset>
    <asp:Button ID="Add_Skill" runat="server" CssClass=" btn btn-info" OnClick="Add_Skill_Click" Text="Add new Skill" />


<div class ="main">
    <asp:GridView ID="GridView" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" OnRowDataBound="GridView_RowDataBound" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />           
            <asp:BoundField DataField="IsActive" HeaderText="Status" />
           
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
    
</body>
</html>
       </asp:Content>