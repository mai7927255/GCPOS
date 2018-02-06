<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="ProductMain.aspx.cs" Inherits="ProductMain" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <div id="page-inner">
        <div class="row">
            <div class="col-md-12">
                <h2>Product Main</h2>
                <h5>Welcome to GCPOS System. </h5>

            </div>
        </div>
        <!-- /. ROW  -->
        <hr />

        <div class="row">
            <div class="col-md-12">
                <!-- Advanced Tables -->
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product Detail
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">

                            <!-- ส่วนนี้คือปุ่ม +Add -->
                            <a class="btn btn-primary btn-sm" href="ProductForm.aspx?action=A" role="button">&nbsp;&nbsp;<span class="glyphicon glyphicon-plus"></span> Add &nbsp;&nbsp;</a>




                            <table class="table table-striped table-bordered table-hover" id="dtProductMain">
                                <thead>

                                    <tr>

                                        <th>ProductCode</th>
                                        <th>Urent</th>
                                        <th>ProductTH</th>
                                        <th>Size</th>
                                        <th>Color</th>
                                        <th>Type</th>
                                        <th>Group</th>
                                        <th>Amount</th>
                                        <th>Status</th>
                                        <th>Action Menu</th>

                                    </tr>

                                </thead>
                                <tbody>
                                    <%
                                        int i = 1;
                                        System.Data.DataTable dt = this.GetProductMain();
                                        foreach (System.Data.DataRow item in dt.Rows)
                                        { %>
                                    <tr>
                                        <td width="10%"><%: item["ProductCode"] %></td>
                                        <td><%: item["Urent"] %></td>
                                        <td width="10%"><%: item["ProductDetailTH"] %></td>
                                        <td width="10%"><%: item["ProductSize"] %></td>
                                        <td width="10%"><%: item["ProductColor"] %></td>
                                        <td width="10%"><%: item["ProductTypeCode"] %></td>
                                        <td width="10%"><%: item["ProductGroupCode"] %></td>
                                        <td width="10%"><%: item["ProductAmount"] %></td>
                                        <td width="10%"><%: item["IsActive"] %></td>

                                        <td>
                                            <div align="center">
                                                <a href="ProductForm.aspx?action=E&ID=<%: item["ProductCode"] %>" class="btn btn-primary btn-sm">
                                                    <span class="glyphicon glyphicon-pencil" title="Edit" aria-hidden="true"></span>Edit &nbsp;&nbsp;</a>
                                        </td>



                                    </tr>
                                    <%  } %>
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
            $("#dtProductMain").dataTable();
        });
    </script>


</asp:Content>

