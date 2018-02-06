<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="CurrencyForm.aspx.cs" Inherits="CurrencyForm" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">CurrencyForm</h1>


        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="Currency_Main.aspx">Back to index</a>
                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="divLoading" style="display: none;">
                        <center><button class="btn btn-lg btn-warning"><span class="glyphicon glyphicon-refresh glyphicon-refresh-animate"></span> Loading...</button></center>
                    </div>
               <div id="registrationForm" runat="server">
                          
                   <div class="panel-body">
                    <table width="100%" border="0">
                        <tr>
                            <td width="20%">Name (Ex.THB,USD) :<font color="#ff0000">*</font></td>
                            <td width="30%">
                               <input type="text" name="cu_code" id="cu_code" runat="server" class="form-control">
                            </td>
                            <td width="2%"></td>
                            <td width="20%">Money surname :</td>
                            <td width="30%">
                                 <input type="text" name="cu_name" id="cu_name" runat="server" class="form-control">
                            </td>
                        </tr>

                        <tr>
                            <td width="20%">Exchange Rate :<font color="#ff0000">*</font></td>
                            <td width="30%">
                               <input type="text" name="cu_rate" id="cu_rate" runat="server" class="form-control">
                            </td>
                            <td width="2%"></td>
                            <td width="20%">Active :</td>
                            <td width="30%">
                                 <input type="checkbox" name="cu_active" id="cu_active" runat="server" checked="checked">
                            </td>
                        </tr>
                        <tr>
                            <td>

                            </td>
                        </tr>
                        
                        <tr>
                            <td width="20%">Create By :<font color="#ff0000">*</font></td>
                            <td width="30%">
                               <input type="Text" name="cu_createby" id="cu_createby" runat="server" class="form-control">
                            </td>
                            <td width="2%"></td>
                            <td width="20%">Create Date :</td>
                            <td width="30%">
                            <input type="Text" name="cu_createdate" id="cu_createdate" runat="server" class="form-control">
                            </td>
                        </tr>

                        <tr>
                            <td width="20%">Update By :<font color="#ff0000">*</font></td>
                            <td width="30%">
                               <input type="Text" name="cu_updateby" id="cu_updateby" runat="server" class="form-control">
                            </td>
                            <td width="2%"></td>
                            <td width="20%">Update Date :</td>
                            <td width="30%">
                            <input type="Text" name="cu_updatedate" id="cu_updatedate" runat="server" class="form-control">
                            </td>
                        </tr>

                        <br />

                        </table>
                                                        
                        <center>
                        <%if (Request.QueryString["action"] == "A")
                          { %>
                        <asp:Button ID="Button1" OnClick="btnAdd_Click" runat="server" class="btn btn-success btn-large" Text="Add" />
                        <%}
                          else
                          { %>
                        <asp:Button ID="Button2" OnClick="btnUpdate_Click" runat="server" class="btn btn-success btn-large" Text="Update" />
                        <%} %>
                            </center>
                           
                            
                   </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
