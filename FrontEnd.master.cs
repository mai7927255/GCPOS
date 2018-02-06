using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrontEnd : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (!Page.IsPostBack)
       //     getCurrency();
        genCategory();
    }

    public DataTable getCurrency()
    {
        DataTable dt = new DataTable();
        StringBuilder sb = new StringBuilder();
        try
        {
            sb.Append("select * from Mas_Currency where IsActive = 1 order by OrderBy ");
            dt = ConnectDB.GetData(sb.ToString(), "tbcurrency");

            if (dt.Rows.Count != 0)
            {
                sb = new StringBuilder();
                sb.Append(" <ul class='dropdown-menu'> ");
                foreach(DataRow row in dt.Rows)
                {
                    sb.Append("<li><a href='#' class='currency'>" + row["CurrencyCode"].ToString() + "</a></li>");
                }				
            }

            //ltrCurrency.Text = sb.ToString();
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

            sb.Append("<ul class='nav navbar-nav collapse navbar-collapse'>");

            foreach (DataRow row in dtType.Rows)
            {
                DataRow[] dr = dtGroup.Select("ProductTypeCode = '" + row["ProductTypeCode"] + "'");
                string typeName = row["ProductTypeName"].ToString();
                string typeCode = row["ProductTypeCode"].ToString();


                sb.Append("<li><a href='#'>" + typeName + "<i class='fa fa-angle-down'></i></a>");
                sb.Append("<ul role='menu' class='sub-menu'>");


                if (dr.Length != 0)
                {


                    for (int i = 0; i < dr.Length; i++)
                    {
                        string groupName = dr[i]["ProductGroupName"].ToString();
                        sb.Append("<li><a href='/index.aspx?type=" + dr[i]["ProductTypeCode"].ToString() + "&group=" + dr[i]["ProductGroupCode"].ToString() + "'>" + groupName + "</a></li>");
                    }


                }

                sb.Append("</ul></li>");
            }
            sb.Append("</ul>");
            ltrMenu.Text = sb.ToString();
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
}
