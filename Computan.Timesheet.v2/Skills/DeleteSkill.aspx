<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.DeleteSkill" %>--%>

<%@ Page Title="DeleteSkill" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteSkill.aspx.cs" Inherits="Computan.Timesheet.v2.Skills.DeleteSkill" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



       <br />

    <div class="row">

        <div class="well">

            <div class="form-group">
                <fieldset>
                    <legend>Delete Existing Skills </legend>

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
           <asp:Button ID="Delete_Skill" runat="server" CssClass="btn btn-danger" OnClick="Delete_Skill_Click" Text="Delete Skill" OnClientClick="if (!confirm('Are you sure you want delete?')) return false;" />
                    

               <asp:Button ID="Cancel" runat="server" CssClass="btn btn-primary" OnClick="Cancel_Click" Text="Cancel" />
                           

                        </div>
                    </div>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
         </fieldset>
                       </div>
        </div>
    </div>











<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Delete Skill</title>
</head>
<body>
  
 <div><h1 class="auto-style1">Delete Skill</h1></div>
<br />
<div class="main">
    <table>
        <tr><td>Name: </td><td>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td></tr>
          <tr><td>Status:</td><td>
           <asp:CheckBox ID="cbIsActive" runat="server" />
            </td></tr>

      
       <tr><td>
           <asp:Button ID="Delete_Skill" runat="server" OnClick="Delete_Skill_Click" Text="Delete Skill" />
           </td><td>              
               <asp:Button ID="Cancel" runat="server" OnClick="Cancel_Click" Text="Cancel" />
                </td></tr>
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    </table>
</div>
   
</body>
</html>--%>
     </asp:Content>