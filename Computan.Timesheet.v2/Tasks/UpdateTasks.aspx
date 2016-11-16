<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateTasks.aspx.cs" Inherits="Computan.Timesheet.v2.Tasks.UpdateTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="css/datepicker.css" rel="stylesheet" type="text/css"/>


   <link href="http://cdn-na.infragistics.com/igniteui/latest/css/themes/infragistics/infragistics.theme.css" rel="stylesheet" />  
   
    <link href="http://cdn-na.infragistics.com/igniteui/latest/css/structure/infragistics.css" rel="stylesheet" /> 
    
     <script src="~/Scripts/jquery-ui-1.10.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    
   
  <script>
         $(function() {
             $("#<%= txtdatetime.ClientID %>").datepicker({
                 altField: "#alternate",
                 altFormat: "DD, d MM, yy"
             });
            
         });
      </script>






    <br />

    <div class="row">

        <div class="well">
            <div class="form-group">
                <fieldset>
                    <legend>Edit Existing Task </legend>


                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Project Name:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:DropDownList ID="projectnameDropDownList2" Width="280px" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="projectnameRequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="projectnameDropDownList2" ErrorMessage="Please select a type" ForeColor="Red" InitialValue="0" ValidationGroup="groupone"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>



                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Skill Name:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:DropDownList ID="skillnameDropDownList3" Width="280px" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="skillnameRequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="skillnameDropDownList3" ErrorMessage="Please select a type" ForeColor="Red" InitialValue="0" ValidationGroup="groupone"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Task Date:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox ID="txtdatetime" CssClass="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>



                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Title:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox ID="txttitle" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Time in Minutes:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:DropDownList ID="timeInMinutesDropDownList1" Width="280px" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label" style="text-align: RIGHT;">Details:</label>
                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                                <asp:TextBox ID="txtdetails" CssClass="form-control" runat="server" TextMode="MultiLine" Width="493" Height="168"></asp:TextBox>

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

                        <div class="inputGroupContainer">
                            <div class="input-group">
                                <%--<span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>--%>
                                <asp:Button ID="btnUpdatetask" runat="server" OnClick="btnUpdatetask_Click" CssClass="btn btn-success" Text="Update Task" />
                                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" CssClass="btn btn-primary" Text="Cancel" />

                            </div>
                        </div>
                    </div>

                    <%--  <tr>
                 <td>Project Name:</td>
                 <td>
                     <asp:DropDownList ID="projectnameDropDownList2" runat="server">
                     </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="projectnameRequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="projectnameDropDownList2" ErrorMessage="Please select a type" ForeColor="Red" InitialValue="0" ValidationGroup="groupone"></asp:RequiredFieldValidator>
                 </td>
             </tr>--%>
                    <%--       <tr>
                        <td>Skill Name:</td>
                        <td>
                            <asp:DropDownList ID="skillnameDropDownList3" runat="server">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="skillnameRequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="skillnameDropDownList3" ErrorMessage="Please select a type" ForeColor="Red" InitialValue="0" ValidationGroup="groupone"></asp:RequiredFieldValidator>
                        </td>
                    </tr>--%>
                    <%--  <tr>
                        <td>Task Date:</td>
                        <td>
                            <asp:TextBox ID="txtdatetime" runat="server"></asp:TextBox>
                        </td>
                    </tr>--%>
                    <%--   <tr>
                        <td>Title:</td>
                        <td>
                            <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
                        </td>
                    </tr>--%>
                    <%--   <tr>
                        <td>Details:</td>
                        <td>
                            <asp:TextBox ID="txtdetails" runat="server"></asp:TextBox>
                        </td>
                    </tr>--%>
                    <%--     <tr>
                        <td>Time in Minutes:</td>
                        <td>
                            <asp:DropDownList ID="timeInMinutesDropDownList1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>--%>

                    <%--         <tr>
                        <td>
                            <asp:Button ID="btnaddtask" runat="server" OnClick="btnaddtask_Click" Text="Add Task" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                        </td>
                    </tr>--%>
                </fieldset>
            </div>

        </div>
    </div>

</asp:Content>
