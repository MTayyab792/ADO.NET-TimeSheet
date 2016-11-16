<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Computan.Timesheet.v2.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>


    <style type="text/css">
    body{
    background-color: #525252;
}
.centered-form{
	margin-top: 60px;
}

.centered-form .panel{
	background: rgba(255, 255, 255, 0.8);
	box-shadow: rgba(0, 0, 0, 0.3) 20px 20px 20px;
}
    </style>



    <div class="form-group">
       
        <hr />

        <div class="container">
             <div class="row centered-form">
        <div class="col-xs-12 col-sm-8 col-md-4 col-sm-offset-2 col-md-offset-4">
        <div class="panel panel-default">
       
         <h4 style="text-align:center">Create a new account</h4>
         <div class="panel-heading">
			    		<h3 class="panel-title">Please sign up for TimeSheet <small>It's free!</small></h3>
			 			</div>
        <div class="panel-body">

        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <%--<asp:Label runat="server" AssociatedControlID="Email" CssClass="form-control input-sm">Email</asp:Label>--%>
            <asp:TextBox runat="server" placeholder="Email Address"  ID="Email" CssClass="form-control input-sm" TextMode="Email" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" CssClass="text-danger" ErrorMessage="The email field is required." />
        </div>
        <div class="row">
	    <div class="col-xs-6 col-sm-6 col-md-6">
        <div class="form-group">
            <%--<asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>--%> 
            <asp:TextBox runat="server" ID="Password" placeholder="Password" TextMode="Password" CssClass="form-control input-sm" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
     </div>
       
            <div class="col-xs-6 col-sm-6 col-md-6">
            <div class="form-group">
            <%--<asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>--%>   
                <asp:TextBox runat="server" placeholder="Confirm Password" ID="ConfirmPassword" TextMode="Password" CssClass="form-control input-sm" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"  CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
            </div>

            </div>

        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-info btn-block" />
     
  </div>
            </div>
           </div>
                 </div>
            </div>
    </div>
</asp:Content>
