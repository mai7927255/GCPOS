<%@ Page Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="UserMain.aspx.cs" Inherits="UserMain" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


      <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                     <h2>User Main</h2>   
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
                             User Data
                        </div>
                        <div class="panel-body">
                            <div class="table-responsive">
                                
                                   <!-- ส่วนนี้คือปุ่ม +Add -->
                               <a class="btn btn-primary btn-sm" href="UserForm.aspx?action=A" role="button">&nbsp;&nbsp;<span class="glyphicon glyphicon-plus"></span> Add &nbsp;&nbsp;</a>
                        
                                
          

                                <table class="table table-striped table-bordered table-hover" id="dtUserMain">
                                    <thead>
                                      
                                        <tr>

                                            <th>Name</th>
                                            <th>Lastname</th> 
                                            <th>UserAccount</th>
                                            <th>TypeCode</th>
                                            <th>Status</th>
                                            <th>Action Menu</th>

                                        </tr>
                                        
                                    </thead>
                                    <tbody>
                                        <%
                                        int i = 1;
                                        System.Data.DataTable dt = this.GetUserMain();
                                        foreach (System.Data.DataRow item in dt.Rows)
                                        { %>
                                         <tr>
                                            <td width="10%"><%: item["FirstName"] %></td>
                                            <td><%: item["Lastname"] %></td>
                                             <td width="10%"><%: item["AccountName"] %></td>
                                             <td width="10%"><%: item["UserTypeCode"] %></td>
                                            <td width="10%"><%: item["IsActive"] %></td>

                                             <td><div align="center"><a href="UserForm.aspx?action=E&ID=<%: item["ID"] %>" class="btn btn-primary btn-sm">
                                                 <span class="glyphicon glyphicon-pencil" title="Edit" aria-hidden="true"></span>Edit &nbsp;&nbsp;</a></td>
                                             

                                            
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
                $("#dtUserMain").dataTable();
            });
    </script>


</asp:Content>