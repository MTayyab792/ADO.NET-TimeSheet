<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.UpdateProject" %>--%>


<%@ Page Title="UpdateProject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.UpdateProject" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />

      <div class="row">

        <div class="well">

            <div class="form-group">
                <fieldset>
                    <legend>Edit Existing Project </legend>
                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Title:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox ID="txttitle" CssClass="form-control" runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="txttitlerequirefield" runat="server" Display="Dynamic" ValidationGroup="groupone" ErrorMessage="title is Required" ControlToValidate="txttitle"  ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="txttitleRegularExpressionValidator1" Display="Dynamic" runat="server" ErrorMessage="not start the title this character (!,@,#,$,%,^,&,*,(,),{},\)" ValidationGroup="groupone" ControlToValidate="txttitle" ValidationExpression="^[a-zA-Z]*$" ForeColor="Red"></asp:RegularExpressionValidator>    
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label" style="text-align: right">Description: </label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                                <asp:TextBox ID="txtdescription" CssClass="form-control" runat="server" TextMode="MultiLine" Width="500px" Height="231px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="txtdescriptionRequiredField" Display="Dynamic" runat="server" ErrorMessage="Description is must for Add project" ControlToValidate="txtdescription" ForeColor="Red" ValidationGroup="groupone"></asp:RequiredFieldValidator>

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
                        <label class="control-label" style="text-align: RIGHT;">CreatedOn:</label>
                        <div class=" inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicons glyphicon-calendar"></i></span>
                               <asp:Label ID="Created_Date" CssClass="label label-primary" runat="server"></asp:Label>
                                
                            </div>
                        </div>
                    </div>

                      <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">LastUpdatedOn:</label>
                        <div class=" inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicons glyphicon-calendar"></i></span>
             <asp:Label ID="Last_Update_Date" CssClass="label label-success" runat="server"></asp:Label>
                                
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label"></label>
                        <div class="col-md-4">
           <asp:Button ID="update_Record" CssClass="btn btn-success" ValidationGroup="groupone" runat="server" OnClick="update_Record_Click" Text="Update Project" />
                <asp:Button ID="Cancel_Record" runat="server" CssClass="btn btn-primary" OnClick="Cancel_Record_Click" Text="Cancel" />
                           
                        </div>
                    </div>
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>


                </fieldset>

            </div>
        </div>

    </div>








 <%--<div><h1 class="auto-style1">Edit Existing Project </h1></div>
<br />--%>
<%--<div class="main">--%>
   <%-- <table>
        <tr><td>Title: </td><td>
            <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
            </td></tr>
        <tr><td>Description:</td><td>
            <asp:TextBox ID="txtdescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td></tr>
        <tr><td>Status:</td><td>
        <asp:CheckBox runat="server" ID="cbIsActive" />    
        </td></tr>--%>
      <%--  <tr><td>CreatedOn:</td><td>
            <asp:Label ID="Created_Date" runat="server"></asp:Label>
            </td></tr>--%>
        <%-- <tr><td>LastUpdatedOn:</td><td>
             <asp:Label ID="Last_Update_Date" runat="server"></asp:Label>
            </td></tr>   --%>  
        
         <%--  <tr><td>IpUsed:</td><td>
            <asp:TextBox ID="txtipused" runat="server"></asp:TextBox>
       
            </td></tr>--%><%--  <tr><td>UserId:</td><td>
            <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
            </td></tr>--%>
      <%-- <tr><td>--%>

           <%--<asp:Button ID="update_Record" runat="server" OnClick="update_Record_Click" Text="Update Project" />--%>

           <%--</td><td>--%>

               
                <%--<asp:Button ID="Cancel_Record" runat="server" OnClick="Cancel_Record_Click" Text="Cancel" />--%>

               
               <%-- </td></tr>--%>
            <%--<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>--%>
  <%--  </table>
</div>--%>
  
    </asp:Content>