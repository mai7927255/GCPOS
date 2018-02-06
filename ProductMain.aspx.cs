using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class ProductMain : System.Web.UI.Page
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
            sb.Append(" SELECT ProductCode,Urent,ProductDetailTH ,ProductSize,ProductColor,ProductTypeCode, " );
            sb.Append(" ProductGroupCode,ProductAmount,IsActive FROM Mas_Product ");
            ConnectDB db = new ConnectDB();
            dt = ConnectDB.GetData(sb.ToString(), "tblProductMain");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());

        }

        return dt;
    }
}
