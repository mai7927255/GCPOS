<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="Currency_Main.aspx.cs" Inherits="Currency_Main" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">




    <div id="page-inner">
        <div class="row">
            <div class="col-md-12">
                <h2>Currency Rate</h2>


            </div>
        </div>
        <!-- /. ROW  -->
        <hr />
        <a class="btn btn-primary btn-sm" href="CurrencyForm.aspx?action=A" role="button">&nbsp;&nbsp;<span class="glyphicon glyphicon-plus"></span> Add &nbsp;&nbsp;</a>
        <div class="row">
            <div class="col-md-12">
                <!-- Advanced Tables -->

                <div class="panel panel-default">
                    <div class="panel-heading">
                        <!--หัวตาราง-->
                        Currency Data
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">




                            <table class="table table-striped table-bordered table-hover" id="dtCurrency">
                                <thead>
                                    <tr>
                                        <th>Currency Code</th>
                                        <th>Currency Name</th>
                                        <th>ThaiBath</th>
                                        <th>Active</th>
                                        <th>CreateDate</th>
                                        <th>CreateBy</th>
                                        <th>UpdateDate</th>
                                        <th>UpdateBy</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <%
                                        int i = 1;
                                        System.Data.DataTable dt = this.GetCurrency();
                                        foreach (System.Data.DataRow item in dt.Rows)
                                        { %>
                                    <tr>
                                        <td width="10%"><%: item["CurrencyCode"] %></td>
                                        <td><%: item["CurrencyName"] %></td>
                                        <td width="10%"><%: item["ThaiBath"] %></td>
                                        <td width="10%"><%: item["IsActive"] %></td>
                                        <td width="10%"><%: item["CreateDate"] %></td>
                                        <td width="10%"><%: item["CreateBy"] %></td>
                                        <td width="10%"><%: item["UpdateDate"] %></td>
                                        <td width="10%"><%: item["UpdateBy"] %></td>

                                        <td>
                                            <div align="center">
                                                <a href="CurrencyForm.aspx?action=E&ID=<%: item["CurrencyCode"] %>" class="btn btn-primary btn-sm">
                                                    <span class="glyphicon glyphicon-pencil" title="Edit" aria-hidden="true"></span>Edit &nbsp;&nbsp;</a>
                                        </td>

                                    </tr>

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
            $("#dtCurrency").dataTable();
        });
    </script>
</asp:Content>

