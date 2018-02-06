using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class CurrencyForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
            return;
        string ID = Request.QueryString["ID"];
        string action = Request.QueryString["action"];

        if (action == "A")
        {
            //GenModelDetail();
        }
        else if (action == "E" && !string.IsNullOrEmpty(ID))
        {
            EditData(ID);
        }
        else
        {
            registrationForm.Visible = false;

        }
    }

    public void EditData(string ID)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            DataTable dt = new DataTable();
            sb.Append(" SELECT * FROM Mas_Currency");
            sb.Append(" where CurrencyCode ='" + ID + "'");
            dt = ConnectDB.GetData(sb.ToString(), "Currency");

            if (dt.Rows.Count != 0)
            {
                cu_code.Disabled = true;
                cu_code.Value = dt.Rows[0]["CurrencyCode"].ToString();
                cu_name.Value = dt.Rows[0]["CurrencyName"].ToString();
                cu_rate.Value = dt.Rows[0]["ThaiBath"].ToString();
                cu_createby.Value = dt.Rows[0]["CreateBy"].ToString();
                cu_updateby.Value = dt.Rows[0]["UpdateBy"].ToString();
                cu_updatedate.Value = dt.Rows[0]["UpdateDate"].ToString();
                cu_createdate.Value = dt.Rows[0]["CreateDate"].ToString();

                if (dt.Rows[0]["IsActive"].ToString() == "False")
                    cu_active.Checked = false;
                else
                    cu_active.Checked = true;
            }
            else
            {
                registrationForm.Visible = false;
            }


        }
        catch (Exception ex)
        {
            registrationForm.Visible = false;
            Response.Write(ex.Message.ToString());
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            SqlParameterCollection param = new SqlCommand().Parameters;
            sb.Append("INSERT INTO Mas_Currency(CurrencyCode,CurrencyName,ThaiBath,IsActive,CreateBy,UpdateBy,");
            sb.Append("CreateDate,UpdateDate)  Output Inserted.CurrencyCode ");
            sb.Append("VALUES(@CurrencyCode,@CurrencyName,@ThaiBath,@IsActive,@CreateBy,@UpdateBy,");
            sb.Append("@CreateDate,@UpdateDate)");

            param.AddWithValue("@CurrencyCode", cu_code.Value);
            param.AddWithValue("@CurrencyName", cu_name.Value);
            param.AddWithValue("@ThaiBath", cu_rate.Value);
            param.AddWithValue("@CreateBy", cu_createby.Value);
            param.AddWithValue("@UpdateBy", cu_updateby.Value);


            if (cu_active.Checked)
                param.AddWithValue("@IsActive", 1);
            else
                param.AddWithValue("@IsActive", 0);



            param.AddWithValue("@CreateDate", DateTime.Now);
            param.AddWithValue("@UpdateDate", DateTime.Now);
            string row = ConnectDB.ExecuteDataReturnID(sb.ToString(), param);
            Response.Redirect("CurrencyForm.aspx?action=E&ID=" + row);

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
            registrationForm.Visible = false;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            string ID = Request.QueryString["ID"];
            if (!string.IsNullOrEmpty(ID))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Mas_Currency set ");
                // sb.Append("CurrencyCode=@CurrencyCode,");
                sb.Append("CurrencyName=@CurrencyName,");
                sb.Append("ThaiBath=@ThaiBath,");
                sb.Append("CreateBy=@CreateBy,");
                sb.Append("UpdateBy=@UpdateBy,");
                sb.Append("CreateDate=@CreateDate,");
                sb.Append("UpdateDate=@UpdateDate,");
                sb.Append("IsActive=@IsActive");
                sb.Append(" Where CurrencyCode = @CurrencyCode");


                SqlParameterCollection param = new SqlCommand().Parameters;
                //   param.AddWithValue("@CurrencyCode", cu_code.Value);
                param.AddWithValue("@CurrencyName", cu_name.Value);
                param.AddWithValue("@ThaiBath", cu_rate.Value);
                param.AddWithValue("@CreateBy", cu_createby.Value);
                param.AddWithValue("@UpdateBy", cu_updateby.Value);

                if (cu_active.Checked)
                    param.AddWithValue("@IsActive", 1);
                else
                    param.AddWithValue("@IsActive", 0);

                //param.AddWithValue("@UpdatePersonID", ucUserAuthen.UserAuthen.Current.UserID);
                param.AddWithValue("@UpdateDate", DateTime.Now);
                param.AddWithValue("@CreateDate", DateTime.Now);
                param.AddWithValue("@CurrencyCode", ID);

                //ConnectDB db = new ConnectDB();
                ConnectDB.ExecuteData(sb.ToString(), param);

            }
            else
            {
                registrationForm.Visible = false;
            }


        }
        catch (Exception ex)
        {
            //registrationForm.Visible = false;
            Response.Write(ex.Message.ToString());
        }
        // Response.Redirect("Currency_Main.aspx");

    }
}