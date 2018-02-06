<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="ProductForm.aspx.cs" Inherits="ProductForm"%>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

                  
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">ProductForm</h1>
                        <div class="panel panel-default">      
                            <div class="panel-heading">
                    <a href="ProductMain.aspx">Back to index</a>  
                            <div class="panel-body">
                                <div id="Product_form" runat="server">
                                    <table width="100%" border="0">
                                        <tr>
                                            <td width="20%"><span id="spTableDescription" runat="server"></span>Product Code:<font color="#ff0000">*</font></td>
                                            <td width="30%">
                                                <input type="text" name="pd_code" id="pd_code" runat="server" class="form-control">
                                                <!-- <input type="hidden" name="type_id" id="type_id" runat="server" class="input-smaill-200"> -->
                                               <!--  <input type="hidden" name="tbltitle" id="tbltitle" runat="server" class="input-smaill-200"> -->
                                            </td>
                                            <td width="2%"></td>
                                            <td width="20%">Urent:</td>
                                            <td width="30%">
                                                <input type="text" name="pd_urent" id="pd_urent" runat="server" class="form-control">
                                                
                                            </td>
                                        </tr>

                                         <tr>
                                            <td>Product Thai Name:</td>
                                            <td>
                                                <input type="text" name="pd_thainame" id="pd_thainame" runat="server" class="form-control">
                                            </td>
                                            <td width="2%"></td>
                                            <td width="20%">Product Eng Name :</td>
                                            <td width="30%">
                                                <input type="text" name="pd_engname" id="pd_engname" runat="server" class="form-control"></td>
                                        </tr>
                                        
                                         <tr>
                                            <td>Product Size:</td>
                                            <td>
                                                <input type="text" name="pd_size" id="pd_size" runat="server" class="form-control">
                                            </td>
                                            <td width="2%"></td>
                                            <td width="20%">Product Color :</td>
                                            <td width="30%">
                                                <input type="text" name="pd_color" id="pd_color" runat="server" class="form-control"></td>
                                        </tr> 
                                     

                                        <tr>
                                            <td>Product Type :</td>
                                            <td><select class="form-control" name="pd_type" id="pd_type" runat="server"></select></td>
                                            <td width="2%"></td>
                                            <td width="20%">Product Group :</td>
                                            <td width="30%"><select class="form-control" name="pd_group" id="pd_group" runat="server"></select></td>
                                        </tr>
                                       
                                          <tr>
                                            <td>Product Amount</td>
                                            <td>
                                               <input type="text" name="pd_amount" id="pd_amount" runat="server" class="form-control"></td>
                                            <td width="2%"></td>
                                            <td width="20%">Active Status :</td>
                                            <td width="30%">
                                                <input type="checkbox" name="status" id="status" runat="server" /><td width="30%">&nbsp;</td>
                                        </tr>
                                        
                                        <tr>
                                            <td>Remark</td>
                                            <td><textarea class="form-control" name="description" id="description" runat="server" rows="5" cols="20"></textarea></td>
                                            <td width="2%"></td>
                                            <td width="20%"></td>
                                            
                                        </tr>
                                        <tr><td>&nbsp;</td></tr>
                                        <tr>
                                            <td>Created Person:</td>
                                            <td><input type="text" name="createby" id="createby" runat="server" class="readonly form-control" readonly></td>
                                            <td width="2%"></td>
                                            <td width="20%">Created Date/Time:</td>
                                            <td>
                                                <input type="text" name="create_date" id="create_date" runat="server" class="readonly form-control" readonly>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Updated Person:</td>
                                            <td>
                                                <input type="text" name="updateby" id="updateby" runat="server" class="readonly form-control" readonly>
                                            </td>
                                            <td width="2%"></td>
                                            <td>Update Date/Time:</td>
                                            <td>
                                                <input type="text" name="update_date" id="update_date" runat="server" class="readonly form-control" readonly>
                                            </td>
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
</asp:Content>
