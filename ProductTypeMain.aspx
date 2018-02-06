<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="ProductTypeMain.aspx.cs" Inherits="ProductType" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div id="page-inner">
        <div class="row">
            <div class="col-md-12">
                <h2>Product Type</h2>
                <h5>Product Type Form </h5>

            </div>
        </div>
        <!-- /. ROW  -->
        <hr />

        <div class="row">
            <div class="col-md-12">
                <!-- Advanced Tables -->
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product Type Item
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">

                            
                               <a class="btn btn-primary btn-sm" href="ProductTypeForm.aspx?action=A" role="button">&nbsp;&nbsp;<span class="glyphicon glyphicon-plus"></span> Add &nbsp;&nbsp;</a>
                        


                            <table class="table table-striped table-bordered table-hover" id="dtProduct">
                                <thead>
                                    <tr>
                                        <th width="15%">Code</th>
                                        <th>Name</th>
                                        <th width="10%">Active</th>
                                        <th width="10%"></th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <%
                                        int i = 1;
                                        System.Data.DataTable dt = this.GetProductMain();
                                        foreach (System.Data.DataRow item in dt.Rows)
                                        { %>
                                    <tr>
                                        <td><%: item["ProductTypeCode"] %></td>
                                        <td><%: item["ProductTypeName"] %></td>
                                        <td><%: item["IsActive"] %></td>
                                        <td>
                                            <div align="center"><a href="ProductTypeForm.aspx?action=E&ID=<%: item["ProductTypeCode"] %>" class="btn btn-primary btn-sm"><span class="glyphicon glyphicon-pencil" title="Edit" aria-hidden="true"></span></a></div>
                                        </td>
                                    </tr>
                                    <%-- <tr>
                                        <td><%:i++ %></td>
                                        <td><%: item["EndUserNumber"] %></td>
                                        <td><%: item["EndUserName"] %></td>
                                        <td><%: item["EndUserTypeName"] %></td>
                                        <td><%: item["EndUserStatusName"] %></td>
                                        <td><%: item["CountryName"] %></td>
                                        <td>
                                            <div align="center"><a href="EndUserForm.aspx?action=E&EndUserID=<%: item["EndUserID"] %>" class="btn btn-primary btn-sm"><span class="glyphicon glyphicon-pencil" title="Edit" aria-hidden="true"></span></a></div>
                                        </td>
                                    </tr>--%>
                                    <%} %>
                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                <!--End Advanced Tables -->
            </div>
        </div>

    </div>


    <script src="Content/assets/js/dataTables/jquery.dataTables.js"></script>
    <script src="Content/assets/js/dataTables/dataTables.bootstrap.js"></script>
    <script>
        $(document).ready(function () {
            $("#dtProduct").dataTable();
        });
    </script>
</asp:Content>
