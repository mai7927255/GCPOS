<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/GCPOS.Master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
         <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                     <h2>Admin Dashboard</h2>   
                        <h5>Welcome Jhon Deo , Love to see you back. </h5>
                    </div>
                </div>              
                 <!-- /. ROW  -->
                  <hr />
                <div class="row">

                      <div class="col-md-4 col-sm-12 col-xs-12 ">

                      <div class="panel panel-back noti-box">
                <span class="icon-box bg-color-red set-icon">
                    <i class="fa fa-clock-o"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">30</p>
                    <p class="main-text">Tasks</p>
                </div>
             </div>
                      </div>

                     <div class="col-md-4 col-sm-12 col-xs-12 ">
                      <div class="panel panel-back noti-box">
                <span class="icon-box bg-color-blue set-icon">
                    <i class="fa fa-bell-o"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">5</p>
                    <p class="main-text">In Progess</p>
                </div>
             </div>
                     </div>

                     <div class="col-md-4 col-sm-12 col-xs-12 ">
                      <div class="panel panel-back noti-box">
                <span class="icon-box bg-color-brown set-icon">
                    <i class="fa fa-rocket"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">10</p>
                    <p class="main-text">Completed</p>
                </div>
             </div>
                     </div>
                   <%-- <div class="col-md-4 col-sm-6 col-xs-6">           
			<div class="panel panel-back noti-box">
                <span class="icon-box bg-color-red set-icon">
                    <i class="fa fa-clock-o"></i>
                </span>
                <div class="text-box">
                    <p class="main-text">120 Tasks</p>
         
                </div>
             </div>
		     </div>

                    <div class="col-md-4 col-sm-6 col-xs-6">           
			<div class="panel panel-back noti-box">
                <span class="icon-box bg-color-blue set-icon">
                    <i class="fa fa-bell-o"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">240 In Progess</p>
              
                </div>
             </div>
		     </div>

                    <div class="col-md-4 col-sm-6 col-xs-6">           
			<div class="panel panel-back noti-box">
                <span class="icon-box bg-color-brown set-icon">
                    <i class="fa fa-rocket"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">3 Completed</p>
                  
                </div>
             </div>
		     </div>--%>
			</div>
                 <!-- /. ROW  -->
                <hr />                
                <div class="row">
                    <div class="col-md-9 col-sm-12 col-xs-12">           
			<div class="panel panel-back noti-box">
                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>First Name</th>
                                    <th>Last Name</th>
                                    <th>Username</th>
                                    <th>User No.</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>Mark</td>
                                    <td>Otto</td>
                                    <td>@mdo</td>
                                    <td>100090</td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Jacob</td>
                                    <td>Thornton</td>
                                    <td>@fat</td>
                                    <td>100090</td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>Larry</td>
                                    <td>the Bird</td>
                                    <td>@twitter</td>
                                    <td>100090</td>
                                </tr>
                                <tr>
                                    <td>1</td>
                                    <td>Mark</td>
                                    <td>Otto</td>
                                    <td>@mdo</td>
                                    <td>100090</td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Jacob</td>
                                    <td>Thornton</td>
                                    <td>@fat</td>
                                    <td>100090</td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>Larry</td>
                                    <td>the Bird</td>
                                    <td>@twitter</td>
                                    <td>100090</td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
             </div>
		     </div>

                    <div class="col-md-3 col-sm-12 col-xs-12 ">
                     <div class="panel ">
          <div class="main-temp-back">
            <div class="panel-body">
              <div class="row">
                <div class="col-xs-6"> <i class="fa fa-cloud fa-3x"></i> Newyork City </div>
                <div class="col-xs-6">
                  <div class="text-temp"> 10° </div>
                </div>
              </div>
            </div>
          </div>
          
        </div>
                     <div class="panel panel-back noti-box">
                <span class="icon-box bg-color-green set-icon">
                    <i class="fa fa-desktop"></i>
                </span>
                <div class="text-box" >
                    <p class="main-text">Display</p>
                    <p class="text-muted">Looking Good kkuyuy ky k ku</p>
                </div>
             </div>
			
    </div>
                        
        </div>
                 <!-- /. ROW  -->
                <div class="row"> 
                    
                      
                               <div class="col-md-9 col-sm-12 col-xs-12">                     
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Bar Chart Example
                        </div>
                        <div class="panel-body">
                            <div id="morris-bar-chart"></div>
                        </div>
                    </div>            
                </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">                       
                    <div class="panel panel-primary text-center no-boder bg-color-green">
                        <div class="panel-body">
                            <i class="fa fa-bar-chart-o fa-5x"></i>
                            <h3>120 GB </h3>
                        </div>
                        <div class="panel-footer back-footer-green">
                           Disk Space Available
                            
                        </div>
                    </div>
                    <div class="panel panel-primary text-center no-boder bg-color-red">
                        <div class="panel-body">
                            <i class="fa fa-edit fa-5x"></i>
                            <h3>20,000 </h3>
                        </div>
                        <div class="panel-footer back-footer-red">
                            Articles Pending
                            
                        </div>
                    </div>                         
                        </div>
                
           </div>
                 <!-- /. ROW  -->
             
      
                 <!-- /. ROW  -->           
    </div>
</asp:Content>