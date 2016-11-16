<%@ Page Title="Log in" Language="C#" MasterPageFile="~/MasterPages/_Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Computan.Timesheet.v2.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <%-- <h2><%: Title %>.</h2>--%>


    <style type="text/css">
        body {
            background-color: #525252;
        }

        .centered-form {
            margin-top: 60px;
        }

            .centered-form .panel {
                background: rgba(255, 255, 255, 0.8);
                box-shadow: rgba(0, 0, 0, 0.3) 20px 20px 20px;
            }
    </style>


    <div class="row">

        <section id="loginForm">
            <div id="login-overlay" class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title" id="myModalLabel">Login to Computan TimeSheet.com</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-xs-6" style="margin: auto; float: none;">
                                <div class="well">

                                    <div class="form-group">

                                        <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                                            <p class="text-danger">
                                                <asp:Literal runat="server" ID="FailureText" />
                                            </p>
                                        </asp:PlaceHolder>
                                        <div class="form-group">
                                            <asp:Label runat="server" CssClass="control-label" AssociatedControlID="Email">Email</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="Email" TextMode="Email" />
                                            <span class="help-block"></span>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" CssClass="text-danger" ErrorMessage="The email field is required." />
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server" CssClass="control-label" AssociatedControlID="Password">Password</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="Password" TextMode="Password" />
                                            <span class="help-block"></span>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                                        </div>
                                        <div id="loginErrorMsg" class="alert alert-error hide">Wrong username or password</div>

                                        <div class="checkbox">
                                            <label runat="server" associatedcontrolid="RememberMe">
                                                <asp:CheckBox runat="server" ID="RememberMe" />
                                                Remember login
                                            </label>
                                            <p class="help-block">(if this is a private computer)</p>
                                        </div>
                                        <%--<div class="checkbox">
                                            <asp:CheckBox runat="server" ID="RememberMe" />
                                            <asp:Label runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                                            <p class="help-block">(if this is a private computer)</p>

                                        </div>--%>

                                        <asp:Button runat="server" CssClass="btn btn-success btn-block" OnClick="LogIn" Text="Log in" />
                                        <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" CssClass="btn btn-info btn-block">Yes please, register now!</asp:HyperLink>
                                      
                                          <%--<a href="/forgot/" class="btn btn-default btn-block">Help to login</a>--%>
                                    </div>
                                </div>

                            </div>
                            <%-- <div class="col-xs-6">
                                <p class="lead">Register now for <span class="text-success">FREE</span></p>
                                <ul class="list-unstyled" style="line-height: 2">
                                    <li><span class="fa fa-check text-success"></span>See all your orders</li>
                                    <li><span class="fa fa-check text-success"></span>Fast re-order</li>
                                    <li><span class="fa fa-check text-success"></span>Save your favorites</li>
                                    <li><span class="fa fa-check text-success"></span>Fast checkout</li>
                                    <li><span class="fa fa-check text-success"></span>Get a gift <small>(only new customers)</small></li>
                                    <li><a href="/read-more/"><u>Read more</u></a></li>
                                </ul>
                                <%--<p><a href="/new-customer/" class="btn btn-info btn-block">Yes please, register now!</a></p>
                          <p>
                            </div>--%>
                        </div>

                    </div>
                </div>
            </div>

            <p>
                <%-- Enable this once you have account confirmation enabled for password reset functionality
                    <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
                --%>
            </p>
        </section>
    </div>
    <section id="socialLoginForm">
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" Visible="false" />
    </section>
</asp:Content>
