<%@ Page Language="C#" MasterPageFile="~/FrontEnd.Master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <section id="slider">
        <!--slider-->
        <asp:Literal ID="ltrBanner" runat="server"></asp:Literal>
    </section>
    <!--/slider-->


    <section>
        <div class="container">

            <div class="row">
                <div class="col-sm-12 padding-right">
                    <div class="features_items">
                        <!--features_items-->
                        <h2 class="title text-center">Product Items</h2>
                        <asp:Literal ID="ltrProduct" runat="server"></asp:Literal>
                     
                    </div>
                    <!--features_items-->


    <div style="text-align:right;">
      <asp:Literal ID="ltrPaging" runat="server"></asp:Literal>
    </div>

                </div>
            </div>
        </div>
        <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button>

        <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog modal-lg">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">หยิบสินค้าใส่ตะกร้า</h4>
        </div>
        <div class="modal-body">
          	<div class="product-details"><!--product-details-->
					
						<div>
							<div class="product-information"><!--/product-information-->
                                <table width="100%"><tr><td style="text-align:center;">
                                    <img style="height:230px;" src="/Images/test01.jpg">
                                                        </td></tr></table>
                                
								<img src="images/product-details/new.jpg" class="newarrival" alt="" />
								<h2>โซฟาผ้า - โซฟาขนาด 2 ที่นั่ง</h2>
								<p>Web ID: 1089772</p>
								<img src="images/product-details/rating.png" alt="" />
								<span>
									<span>ราคา 12,000</span>
									<label>จำนวน:</label>
									<input type="text" value="3" />
									<button type="button" class="btn btn-fefault cart">
										<i class="fa fa-shopping-cart"></i>
										หยิบใส่ตะกร้า
									</button>
								</span>
								
							</div><!--/product-information-->
						</div>
                 <h4> รายละเอียดเพิ่มเติม</h4>
                  <textarea class="form-control" rows="5"></textarea>
					</div><!--/product-details-->
        </div>
        <div class="modal-footer">
            
          <button type="button" class="btn btn-default" data-dismiss="modal">ปิด</button>
        </div>
      </div>
      
    </div>
  </div>

    </section>


</asp:Content>
