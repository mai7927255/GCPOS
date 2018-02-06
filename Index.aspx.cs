using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Web.Security;


public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            genProduct();
            genBanner();
        }


    }


    public void genBanner()
    {
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            dt = getBanner();

            if (dt.Rows.Count != 0)
            {
                sb.Append("<div class='container'>");
                sb.Append("<div class='row'>");
                sb.Append("<div class='col-sm-12'>");
                sb.Append("<div id='slider-carousel' class='carousel slide' data-ride='carousel'>");
                sb.Append("<ol class='carousel-indicators'>");

                string classActive1 = string.Empty;
                for (int i = 0; i < dt.Rows.Count; i++) {
                    sb.Append("<li data-target='#slider-carousel' data-slide-to='" + i + "' " + (classActive1 == "" ? "class='active'" : "") + "></li>");
                    classActive1 = "active";
                }
                sb.Append("</ol>");
                sb.Append("<div class='carousel-inner'>");

                string classActive2 = string.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    string topic = row["Topic"].ToString();
                    string detail = row["Detail"].ToString();
                    string img = row["ImageURL"].ToString();

                    sb.Append("<div class='item"+(classActive2 == "" ? " active" : "") +"'>");
                    sb.Append("<div class='col-sm-6'>");
                    sb.Append("<h1></h1><h2>" + topic + "</h2>");
                    sb.Append("<p>" + detail + "</p>");
                    //sb.Append("<button type='button' class='btn btn-default get'>Get it now</button>");
                    sb.Append("</div>");
                    sb.Append("<div class='col-sm-6'>");
                    sb.Append("<img src='" + img + "' class='girl img-responsive' style='height: 200px;' />");
	                sb.Append("</div>");
                    sb.Append("</div>");
                    classActive2 = "active";
                }

                sb.Append("</div>");
                sb.Append("<a href='#slider-carousel' class='left control-carousel hidden-xs' data-slide='prev'>");
                sb.Append("<i class='fa fa-angle-left'></i>");
                sb.Append("</a>");
                sb.Append("<a href='#slider-carousel' class='right control-carousel hidden-xs' data-slide='next'>");
                sb.Append("<i class='fa fa-angle-right'></i>");
                sb.Append("</a></div></div></div></div>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
        ltrBanner.Text = sb.ToString();
    }

    public DataTable getBanner()
    {
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            sb.Append(" select * from Mas_Banner where IsActive=1 Order By OrderBy");
            dt = ConnectDB.GetData(sb.ToString(), "tbbanner");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
        return dt;
    }

    public void genProduct()
    {
        string type = Request.QueryString["type"];
        string group = Request.QueryString["group"];
        string pageNumber = Request.QueryString["page"];
        pageNumber = (string.IsNullOrEmpty(pageNumber)) ? "1" : pageNumber;
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();

        if (!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(group))
        {
           dt = getProduct(type, group,pageNumber);
        }
        else
        {          
            dt = getProductAll(pageNumber);
        }

        if (dt.Rows.Count != 0)
        {
            foreach (DataRow row in dt.Rows)
            {
                sb.Append(" <div class='col-sm-3'> ");
                sb.Append(" <div class='product-image-wrapper'> ");
                sb.Append(" <div class='single-products'> ");
                sb.Append(" <div class='productinfo text-center'> ");
                sb.Append(" <img style='height:230px;' src='/Images/Product/" + row["ProductCode"].ToString() + ".jpg' /> ");
                sb.Append(" <h2>$56</h2> ");
                sb.Append(" <p>" + row["ProductDetailEN"].ToString() + "</p> ");
                sb.Append(" <p>" + row["ProductSize"].ToString() + "</p> ");
                //sb.Append(" <p>" + row["ProductColor"].ToString() + "</p> ");
                //sb.Append(" <a href='#' class='btn btn-default add-to-cart' data-toggle='modal' data-target='#myModal'><i class='fa fa-shopping-cart'></i>Add to cart</a> ");
                sb.Append(" <img src='/Content/FrontEnd/images/addcart.png' style='width:150px;' data-toggle='modal' data-target='#myModal'/>");
                //sb.Append(" <a href='/product-details.aspx' class='btn btn-default add-to-cart'><i class='fa'></i>More details</a> ");
                sb.Append(" </div> ");
                //sb.Append(" <div class='product-overlay'> ");
                //sb.Append(" <div class='overlay-content'> ");
                //sb.Append(" <h2>$56</h2> ");
                //sb.Append(" <p>Easy Polo Black Edition</p> ");
                //sb.Append(" <a href='#' class='btn btn-default add-to-cart'><i class='fa fa-shopping-cart'></i>Add to cart</a> ");
                //sb.Append(" <a href='/product-details.aspx' class='btn btn-default add-to-cart'><i class='fa'></i>More details</a> ");
                sb.Append(" </div></div></div>");
                //sb.Append(" </div></div></div></div></div>");
            }
        }
        ltrProduct.Text = sb.ToString();
    }

    public DataTable getProduct(string type, string group, string pageNumber)
    {
        StringBuilder sb = new StringBuilder();
        DataTable dt = new DataTable();

        try
        {

            sb.Append(" DECLARE @PageSize INT = 20, @PageNum  INT = " + pageNumber + ", @TotalRows INT; ");
            sb.Append(" SELECT *,TotalRows = COUNT(*) OVER(),TotalPages = (Count(*) OVER()/@PageSize)+1 FROM Mas_Product ");
            sb.Append(" where ProductTypeCode = '" + type + "' and ProductGroupCode = '" + group + "'");
            sb.Append(" ORDER BY [ProductCode] ");
            sb.Append(" OFFSET (@PageNum - 1) * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY; ");
            dt = ConnectDB.GetData(sb.ToString(), "tbproduct");

            if (dt.Rows.Count != 0)
                genPaging(dt.Rows[0]["TotalPages"].ToString(), pageNumber);
              
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
        return dt;
    }


    public DataTable getProductAll(string pageNumber)
    {
        StringBuilder sb = new StringBuilder();
        DataTable dt = new DataTable();
        try
        {
            sb.Append(" DECLARE @PageSize INT = 20, @PageNum  INT = " + pageNumber + ", @TotalRows INT; ");
            sb.Append(" SELECT *,TotalRows = COUNT(*) OVER(),TotalPages = (Count(*) OVER()/@PageSize)+1 FROM Mas_Product ");
            sb.Append(" ORDER BY [ProductCode] ");
            sb.Append(" OFFSET (@PageNum - 1) * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY; ");
            dt = ConnectDB.GetData(sb.ToString(), "tbproduct");

            if (dt.Rows.Count != 0)
                genPaging(dt.Rows[0]["TotalPages"].ToString(), pageNumber);

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
        return dt;
    }

    private void genCategory()
    {
        DataTable dtType = new DataTable();
        DataTable dtGroup = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            dtType = getProductType();
            dtGroup = getProductGroup();
	
            foreach (DataRow row in dtType.Rows)
            {
                DataRow[] dr = dtGroup.Select("ProductTypeCode = '"+ row["ProductTypeCode"] + "'");
                string typeName = row["ProductTypeName"].ToString();
                string typeCode = row["ProductTypeCode"].ToString();
                sb.Append(" <div class='panel panel-default'>");
                sb.Append(" <div class='panel-heading'> ");
                sb.Append(" <h4 class='panel-title'> ");
                sb.Append(" <a data-toggle='collapse' data-parent='#accordian' href='#" + typeCode + "'> ");
                sb.Append(" <span class='badge pull-right'><i class='fa fa-plus'></i></span> ");
                sb.Append(typeName);
                sb.Append(" </a> ");
                sb.Append(" </h4> ");
                sb.Append(" </div> ");				
										
                if(dr.Length != 0)
                {
                    sb.Append(" <div id='" + typeCode + "' class='panel-collapse collapse'> ");
				    sb.Append(" <div class='panel-body'> ");	
		            sb.Append(" <ul> ");

					for(int i = 0;i<dr.Length;i++) {
                        string groupName = dr[i]["ProductGroupName"].ToString();
                        sb.Append("<li><a href='/index.aspx?type=" + dr[i]["ProductTypeCode"].ToString() + "&group="+ dr[i]["ProductGroupCode"].ToString() + "'>" + groupName + "</a></li>");
                    }
											
		            sb.Append("</ul>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                }

    			sb.Append("</div>");			
            }
            //ltrCategory.Text = sb.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
    }

    public DataTable getProductType()
    {
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            sb.Append("select * from mas_producttype where IsActive = 1 order by OrderBy ");
            dt = ConnectDB.GetData(sb.ToString(), "tbproducttype");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }

        return dt;
    }

    public DataTable getProductGroup()
    {
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            sb.Append(" Select mp.ProductTypeCode, mp.ProductGroupCode, pg.ProductGroupName ");
            sb.Append(" From Mas_Mapping mp Left Join Mas_ProductGroup pg on mp.ProductGroupCode = pg.ProductGroupCode ");
            sb.Append(" Where pg.IsActive = 1 Order By mp.OrderBy ");
            dt = ConnectDB.GetData(sb.ToString(), "tbmapping");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }
        return dt;
    }

    public void genPaging(string total, string current)
    {
        StringBuilder sb = new StringBuilder();


            string type = Request.QueryString["type"];
            string group = Request.QueryString["group"];
            string urlQueryString = string.Empty;

            if (!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(group))
            {
                urlQueryString = "&type=" + type + "&group=" + group;
            }
        try
        {
            int iTotal = int.Parse(total);
            int iCurrent = int.Parse(current);
            sb.Append("<ul class='pagination pagination-lg'>");
            if (iCurrent == 1)
            {
                sb.Append(" <li class='page-item active'><a class='page-link' href='#'>1</a></li> ");
                int next = iCurrent +2;
                int nextPage = iTotal - iCurrent;
                for (int i = iCurrent; i < next;i++ )
                {
                    if (nextPage > 0 && i < iTotal)
                    {
                        sb.Append(" <li class='page-item'><a class='page-link' href='/index.aspx?page=" + (i + 1) + urlQueryString + "'>" + (i + 1) + "</a></li> ");
                    }
                }

            }

            if (iCurrent == 2)
            {
                sb.Append("<li class='page-item'><a class='page-link' href='/index.aspx?page=" + (iCurrent - 1) + urlQueryString + "'>Previous</a></li>");
                sb.Append(" <li class='page-item'><a class='page-link' href='/index.aspx?page=1" + urlQueryString + "'>1</a></li> ");
                sb.Append(" <li class='page-item active'><a class='page-link' href='#'>2</a></li> ");
                int next = iCurrent + 2;
                int nextPage = iTotal - iCurrent;
                for (int i = iCurrent; i <= next; i++)
                {
                    if (nextPage > 0 && i < iTotal)
                    {
                        sb.Append(" <li class='page-item'><a class='page-link' href='/index.aspx?page=" + (i + 1) + urlQueryString + "'>" + (i + 1) + "</a></li> ");
                    }
                }
            }

            if (iCurrent >= 3)
            {
                sb.Append("<li class='page-item'><a class='page-link' href='/index.aspx?page=" + (iCurrent - 1) + urlQueryString + "'>Previous</a></li>");
                int pre = iCurrent - 2;
                for (int i = pre ; i < iCurrent; i++)
                {
                    sb.Append(" <li class='page-item'><a class='page-link' href='/index.aspx?page=" + i + urlQueryString + "'>" + i + "</a></li> ");
                }

                sb.Append(" <li class='page-item active'><a class='page-link' href='#'>"+iCurrent+"</a></li> ");
                int next = iCurrent + 2;
                int nextPage = iTotal - iCurrent;
      
                for (int i = iCurrent ; i < next; i++)
                {
                    if (nextPage > 0 && i < iTotal)
                    {
                        sb.Append(" <li class='page-item'><a class='page-link' href='/index.aspx?page=" + (i + 1) + urlQueryString + "'>" + (i + 1) + "</a></li> ");
                    }
                     
                }

            }

            if (iCurrent < iTotal)
            {
                sb.Append("<li class='page-item'>");
                sb.Append(" <a class='page-link'  href='/index.aspx?page=" + (iCurrent+1) + "'>Next</a>");
                sb.Append(" </li>");
            }


            sb.Append(" </ul>");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
        }

        ltrPaging.Text = sb.ToString();
    }



}