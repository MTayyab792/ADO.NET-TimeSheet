<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.AddProject" %>--%>

<%@ Page Title="AddProject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Computan.Timesheet.v2.Projects.AddProject" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="row">

        <div class="well">

                <div class="form-group">
                <fieldset>
                    <legend>Enter a new Project</legend>
                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Title:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox ID="txttitle" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="txttitlerequirefield" class=" text-danger" runat="server" Display="Dynamic" ValidationGroup="groupone" ErrorMessage="Title is Required" ControlToValidate="txttitle"  ForeColor="Red"></asp:RequiredFieldValidator>
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
                                <asp:RequiredFieldValidator ID="txtdescriptionRequiredField"  Display="Dynamic" runat="server" ErrorMessage="Description is must for Add project" ControlToValidate="txtdescription" ForeColor="Red" ValidationGroup="groupone"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Status:</label>
                        <div class=" inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:CheckBox ID="cbIsactive" CssClass="aql" runat="server" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label"></label>
                        <div class="col-md-4">
                            <asp:Button ID="Button1" CssClass="btn btn-success" ValidationGroup="groupone" runat="server" OnClick="Button1_Click" Text="Add Project" />
                            <asp:Button ID="Cancel_Record" CssClass="btn btn-primary" runat="server" OnClick="Cancel_Record_Click" Text="Cancel" />

                        </div>
                    </div>


                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </fieldset>

            </div>
        </div>

    </div>
</asp:Content>
