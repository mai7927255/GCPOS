using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Currency_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public DataTable GetCurrency()
    {
        DataTable dt = new DataTable();
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT CurrencyCode,CurrencyName,ThaiBath,IsActive,CreateDate,CreateBy,UpdateDate,UpdateBy FROM Mas_Currency ");
            ConnectDB db = new ConnectDB();
            dt = ConnectDB.GetData(sb.ToString(), "tblCurrency");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());

        }

        return dt;
    }
}