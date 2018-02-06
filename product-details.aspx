<%@ Page Language="C#" MasterPageFile="~/FrontEnd.Master" AutoEventWireup="true" CodeFile="product-details.aspx.cs" Inherits="product_details" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    
    	<section>
		<div class="container">
			<div class="row">
				<div class="col-sm-3">
					<div class="left-sidebar">
						<h2>Category</h2>
						<div class="panel-group category-products" id="accordian"><!--category-productsr-->
							<div class="panel panel-default">
								<div class="panel-heading">
									<h4 class="panel-title">
										<a data-toggle="collapse" data-parent="#accordian" href="#sportswear">
											<span class="badge pull-right"><i class="fa fa-plus"></i></span>
											Sportswear
										</a>
									</h4>
								</div>
								<div id="sportswear" class="panel-collapse collapse">
									<div class="panel-body">
										<ul>
											<li><a href="#">Nike (20)</a></li>
											<li><a href="#">Under Armour (15)</a></li>
											<li><a href="#">Adidas (3)</a></li>
											<li><a href="#">Puma (5)</a></li>
											<li><a href="#">ASICS (3)</a></li>
										</ul>
									</div>
								</div>
							</div>
							<div class="panel panel-default">
								<div class="panel-heading">
									<h4 class="panel-title">
										<a data-toggle="collapse" data-parent="#accordian" href="#mens">
											<span class="badge pull-right"><i class="fa fa-plus"></i></span>
											Mens
										</a>
									</h4>
								</div>
								<div id="mens" class="panel-collapse collapse">
									<div class="panel-body">
										<ul>
											<li><a href="#">Fendi (3)</a></li>
											<li><a href="#">Guess (5)</a></li>
											<li><a href="#">Valentino (43)</a></li>
											<li><a href="#">Dior (30)</a></li>
											<li><a href="#">Versace (3)</a></li>
											<li><a href="#">Armani (3)</a></li>
											<li><a href="#">Prada (3)</a></li>
											<li><a href="#">Dolce and Gabbana (54)</a></li>
											<li><a href="#">Chanel (32)</a></li>
											<li><a href="#">Gucci (3)</a></li>
										</ul>
									</div>
								</div>
							</div>
							
							<div class="panel panel-default">
								<div class="panel-heading">
									<h4 class="panel-title">
										<a data-toggle="collapse" data-parent="#accordian" href="#womens">
											<span class="badge pull-right"><i class="fa fa-plus"></i></span>
											Womens
										</a>
									</h4>
								</div>
								<div id="womens" class="panel-collapse collapse">
									<div class="panel-body">
										<ul>
											<li><a href="#">Fendi (43)</a></li>
											<li><a href="#">Guess (32)</a></li>
											<li><a href="#">Valentino (32)</a></li>
											<li><a href="#">Dior (65)</a></li>
											<li><a href="#">Versace (3)</a></li>
										</ul>
									</div>
								</div>
							</div>
						</div><!--/category-products-->
					


						<div class="shipping text-center"><!--shipping-->
							<img src="Content/FrontEnd/images/home/shipping.jpg" alt="" />
						</div><!--/shipping-->
					
					</div>
				</div>

					
				<div class="col-sm-9 padding-right">
					<div class="product-details"><!--product-details-->
						<div class="col-sm-5">
							<div class="view-product">
								<img src="Content/FrontEnd/images/product-details/1.jpg" alt="" />
								<h3>ZOOM</h3>
							</div>
							<div id="similar-product" class="carousel slide" data-ride="carousel" style="display:none;">
								
								  <!-- Wrapper for slides -->
								    <div class="carousel-inner">
										<div class="item active">
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar1.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar2.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar3.jpg" alt=""></a>
										</div>
										<div class="item">
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar1.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar2.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar3.jpg" alt=""></a>
										</div>
										<div class="item">
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar1.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar2.jpg" alt=""></a>
										  <a href=""><img src="Content/FrontEnd/images/product-details/similar3.jpg" alt=""></a>
										</div>
										
									</div>

								  <!-- Controls -->
								  <a class="left item-control" href="#similar-product" data-slide="prev">
									<i class="fa fa-angle-left"></i>
								  </a>
								  <a class="right item-control" href="#similar-product" data-slide="next">
									<i class="fa fa-angle-right"></i>
								  </a>
							</div>

						</div>
						<div class="col-sm-7">
							<div class="product-information"><!--/product-information-->
								<img src="images/product-details/new.jpg" class="newarrival" alt="" />
								<h2>Anne Klein Sleeveless Colorblock Scuba</h2>
								<p>Web ID: 1089772</p>
								<img src="images/product-details/rating.png" alt="" />
								<span>
									<span>US $59</span>
									<label>Quantity:</label>
									<input type="text" value="3" />
									<button type="button" class="btn btn-fefault cart">
										<i class="fa fa-shopping-cart"></i>
										Add to cart
									</button>
								</span>
								<p><b>Availability:</b> In Stock</p>
								<p><b>Condition:</b> New</p>
								<p><b>Brand:</b> E-SHOPPER</p>
								<a href=""><img src="images/product-details/share.png" class="share img-responsive"  alt="" /></a>
							</div><!--/product-information-->
						</div>
					</div><!--/product-details-->
					
					<div class="category-tab shop-details-tab"><!--category-tab-->
						<div class="col-sm-12">
							<ul class="nav nav-tabs">
								<li class="active"><a href="#details" data-toggle="tab">Details</a></li>

							</ul>
						</div>
						<div class="tab-content">
							<div class="tab-pane fade" id="details" >
								<div class="col-sm-3">
									<div class="product-image-wrapper">
										<div class="single-products">
											<div class="productinfo text-center">
												<img src="images/home/gallery1.jpg" alt="" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type="button" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class="col-sm-3">
									<div class="product-image-wrapper">
										<div class="single-products">
											<div class="productinfo text-center">
												<img src="images/home/gallery2.jpg" alt="" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type="button" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class="col-sm-3">
									<div class="product-image-wrapper">
										<div class="single-products">
											<div class="productinfo text-center">
												<img src="images/home/gallery3.jpg" alt="" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type="button" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class="col-sm-3">
									<div class="product-image-wrapper">
										<div class="single-products">
											<div class="productinfo text-center">
												<img src="images/home/gallery4.jpg" alt="" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type="button" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
							</div>
							

						</div>
					</div><!--/category-tab-->
					
	
					
				</div>
			</div>
		</div>
	</section>
	
	

    </asp:Content>