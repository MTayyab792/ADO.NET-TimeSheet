<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.AddSkill" %>--%>

<%@ Page Title="AddSkill" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.AddSkill" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



   
    <br />

    <div class="row">

        <div class="well">

            <div class="form-group">
                <fieldset>
                    <legend>Edit Existing Skills </legend>

                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Name:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox ID="txtname" CssClass="form-control" runat="server"></asp:TextBox>

                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Status:</label>
                        <div class=" inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:CheckBox ID="cbIsActive" CssClass="aql" runat="server" />
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label"></label>
                        <div class="col-md-4">
                            <asp:Button ID="Add_Skill" runat="server" OnClick="Add_Skill_Click" Text="Add Skill" />

                            <asp:Button ID="Cancel_Record" runat="server" OnClick="Cancel_Record_Click" Text="Cancel" />

                        </div>
                    </div>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
         </fieldset>
                       </div>
        </div>
    </div>


    <%--     <div class="main">
            <table>
                <tr>
                    <td>Name: </td>
                    <td>
                        <%--<asp:TextBox ID="txtname" runat="server"></asp:TextBox>--%>
    <%--  </td>
                </tr>
                <tr>
                    <td>Status: </td>
                    <td>--%>
    <%--       <%--<asp:CheckBox ID="cbIsActive" runat="server" />--%>
    <%--</td>
                </tr>
                <tr>--%>
    <%-- <td>--%>
    <%--<asp:Button ID="Add_Skill" runat="server" OnClick="Add_Skill_Click" Text="Add Skill" />--%>
    <%--</td>
                    <td>--%>
    <%--<asp:Button ID="Cancel_Record" runat="server" OnClick="Cancel_Record_Click" Text="Cancel" />--%>
    <%-- </td>
                </tr>--%>
    <%--<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>--%>
    <%--</table>
        </div>--%>
</asp:Content>
