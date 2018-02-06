<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="UserForm.aspx.cs" Inherits="UserForm" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">UserForm</h1>


        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="UserMain.aspx">Back to index</a>

                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="divLoading" style="display: none;">
                        <center><button class="btn btn-lg btn-warning"><span class="glyphicon glyphicon-refresh glyphicon-refresh-animate"></span> Loading...</button></center>
                    </div>
                    <div id="registrationForm" runat="server">
                        <table width="100%" border="0">
                            <tr valign="top">
                                <td width="20%">Firstname :</td>
                                <td width="30%">
                                    <input type="text" name="fname" id="fname" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">UserTypeCode</td>
                                <td width="30%">

                                    <input type="text" name="UserTypeCode" id="UserTypeCode" runat="server" class="form-control"></td>
                                </td>
                            </tr>

                            <tr>
                                <td>Lastname:</td>
                                <td>
                                    <input type="text" name="Lastname" id="Lastname" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">UserAccount :</td>
                                <td width="30%">
                                    <input type="text" name="UserAccount" id="UserAccount" runat="server" class="form-control"></td>
                            </tr>
                            <tr>
                                <td>Company Name:</td>
                                <td>
                                    <input type="text" name="Company_name" id="Company_name" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">Password :</td>
                                <td width="30%">
                                    <input type="text" name="Password" id="Password" runat="server" class="form-control"></td>
                            </tr>

                            <tr valign="top">
                                <td>Address:</td>
                                <td>
                                    <textarea class="form-control" name="Address" id="Address" runat="server" rows="5" cols="20"></textarea></td>
                                <td width="2%"></td>
                                <td width="20%">Remark</td>
                                <td width="30%">
                                    <textarea class="form-control" name="Remark" id="Remark" runat="server" rows="5" cols="20"></textarea></td>
                            </tr>
                            <tr>
                                <td>Boothname:</td>
                                <td>
                                    <input type="text" name="Boothname" id="Boothname" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">Active</td>
                                <td width="30%">
                                    <input type="checkbox" name="status" id="status" runat="server"></td>

                            </tr>
                            <tr>
                                <td>CreateDate:</td>
                                <td>
                                    <input type="text" disabled="disabled" name="CreateDate" id="CreateDate" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">CreateBy :</td>
                                <td width="30%">
                                    <input type="text" name="CreateBy" id="CreateBy" runat="server" class="form-control"></td>
                            </tr>
                            <tr>
                                <td>UpdateDate:</td>
                                <td>
                                    <input type="text" name="UpdateDate" id="UpdateDate" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%">UpdateBy :</td>
                                <td width="30%">
                                    <input type="text" name="UpdateBy" id="UpdateBy" runat="server" class="form-control"></td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    <hr />
                                </td>
                            </tr>

                        </table>
                        <center>
                        <%if (Request.QueryString["action"] == "A")
                          { %>
                        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" class="btn btn-success btn-large" Text="Add" />
                        <%}
                          else
                          { %>
                        <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" class="btn btn-success btn-large" Text="Update" />
                        <%} %>
                            </center>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
