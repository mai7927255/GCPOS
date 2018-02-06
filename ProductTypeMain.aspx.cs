using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ProductType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public DataTable GetProductMain()
    {
        DataTable dt = new DataTable();
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ProductTypeCode,ProductTypeName ,IsActive  FROM Mas_ProductType");
           // ConnectDB db = new ConnectDB();
            dt = ConnectDB.GetData(sb.ToString(), "tblproduct");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
    
        }

        return dt;
    }
}