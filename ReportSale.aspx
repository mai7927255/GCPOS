<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="ReportSale.aspx.cs" Inherits="ReportSale" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div id="page-inner">
        <div class="row">
            <div class="col-md-12">
                <h2>Sale report</h2>


            </div>
        </div>
        <!-- /. ROW  -->
        <hr />
        <!-- <a class="btn btn-primary btn-sm" href="CurrencyForm.aspx?action=A" role="button">&nbsp;&nbsp;<span class="glyphicon glyphicon-plus"></span> Add &nbsp;&nbsp;</a>-->
        <div class="row">
            <div class="col-md-12">
                <!-- Advanced Tables -->

                <div class="panel panel-default">
                    <div class="panel-heading">
                        <!--หัวตาราง-->
                        Sale Report
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
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
