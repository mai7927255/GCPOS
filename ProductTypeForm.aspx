<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="ProductTypeForm.aspx.cs" Inherits="ProductTypeForm" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Product Type</h1>


        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Master Data Entry > <a href="ProductTypeMain.aspx">Product Type</a> > Product Type Form
                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="divLoading" style="display: none;">
                        <center><button class="btn btn-lg btn-warning"><span class="glyphicon glyphicon-refresh glyphicon-refresh-animate"></span> Loading...</button></center>
                    </div>
               <div id="registrationForm" runat="server">
                        <table width="100%" border="0">
                            <tr valign="top">
                                <td width="20%">Product Type Code :<font color="#ff0000">*</font></td>
                                <td width="30%">
                                    <input type="text" name="txtProductCode" id="txtProductCode" runat="server" class="form-control">
                                </td>
                                <td width="2%"></td>
                                <td width="20%"></td>
                                <td width="30%">
                                </td>
                            </tr>

                            <tr valign="top">
                                <td>Product Type Name:<font color="#ff0000">*</font></td>
                                <td>
                                    <input type="text" name="txtProductName" id="txtProductName" runat="server" class="form-control">
                                </td>
                                <td></td>
                           <td width="20%">Active: </td>
                                <td width="30%">
                                    <input type="checkbox" name="active" id="active" runat="server" checked="checked">
                                </td>
                            </tr>


                            <tr>
                                <td>Description:</td>
                                <td colspan="4">
                                    <textarea class="form-control" id="txtProductDetail" name="txtProductDetail" runat="server" rows="5"></textarea></td>
                            </tr>
                            <tr>
                                <td>Created Person:</td>
                                <td>
                                    <input type="text" name="create_person" id="create_person" runat="server" class="readonly form-control" readonly></td>
                                <td width="2%"></td>
                                <td width="20%">Created Date/Time:</td>
                                <td>
                                    <input type="text" name="create_date" id="create_date" runat="server" class="readonly form-control" readonly></td>
                            </tr>
                            <tr>
                                <td>Updated Person:</td>
                                <td>
                                    <input type="text" name="update_person" id="update_person" runat="server" class="readonly form-control" readonly></td>
                                <td width="2%"></td>
                                <td>Update Date/Time:</td>
                                <td>
                                    <input type="text" name="update_date" id="update_date" runat="server" class="readonly form-control" readonly></td>
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