using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public DataTable GetUserMain()
    {
        DataTable dt = new DataTable();
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ID,FirstName,LastName ,AccountName,IsActive,UserTypeCode  FROM Mas_User ");
            ConnectDB db = new ConnectDB();
            dt = ConnectDB.GetData(sb.ToString(), "tbluserMain");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());

        }

        return dt;
    }
}