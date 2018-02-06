using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductTypeForm : System.Web.UI.Page
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
            sb.Append(" SELECT *   FROM Mas_ProductType");
            sb.Append(" where ProductTypeCode ='" + ID + "'");
            dt = ConnectDB.GetData(sb.ToString(), "product");

            if (dt.Rows.Count != 0)
            {
                txtProductCode.Disabled = true;
                txtProductCode.Value = dt.Rows[0]["ProductTypeCode"].ToString();
                txtProductName.Value = dt.Rows[0]["ProductTypeName"].ToString();
                txtProductDetail.Value = dt.Rows[0]["ProductTypeDetail"].ToString();
                create_person.Value = dt.Rows[0]["CreateBy"].ToString();
                create_date.Value = dt.Rows[0]["CreateDate"].ToString();
                update_person.Value = dt.Rows[0]["UpdateBy"].ToString();
                update_date.Value = dt.Rows[0]["UpdateDate"].ToString();

                if (dt.Rows[0]["IsActive"].ToString() == "False")
                    active.Checked = false;
                else
                    active.Checked = true;
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
            sb.Append("INSERT INTO Mas_ProductType(ProductTypeCode,ProductTypeName,ProductTypeDetail,IsActive,");
            //sb.Append("CreateBy,CreateDate,UpdateBy,UpdateDate)");
            sb.Append("CreateDate,UpdateDate)  Output Inserted.ProductTypeCode ");
            sb.Append("VALUES(@ProductTypeCode,@ProductTypeName,@ProductTypeDetail,@IsActive,");
            //sb.Append("@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
            sb.Append("@CreateDate,@UpdateDate)");

            param.AddWithValue("@ProductTypeCode", txtProductCode.Value);
            param.AddWithValue("@ProductTypeName", txtProductName.Value);
            param.AddWithValue("@ProductTypeDetail", txtProductDetail.Value);
            if (active.Checked)
                param.AddWithValue("@IsActive", 1);
            else
                param.AddWithValue("@IsActive", 0);

            //param.AddWithValue("@CreateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@CreateDate", DateTime.Now);
            //param.AddWithValue("@UpdateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@UpdateDate", DateTime.Now);
            string row = ConnectDB.ExecuteDataReturnID(sb.ToString(), param);
            Response.Redirect("ProductTypeForm.aspx?action=E&ID=" + row);

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
                sb.Append("UPDATE Mas_ProductType set ");
                sb.Append("ProductTypeName=@ProductTypeName,");
                sb.Append("ProductTypeDetail=@ProductTypeDetail,");
                sb.Append("IsActive=@Active ");
                //sb.Append("UpdatePersonID=@UpdatePersonID,");
                //sb.Append("UpdateDateTime=@UpdateDateTime ");
                sb.Append("Where ProductTypeCode = @ProductTypeCode");


                SqlParameterCollection param = new SqlCommand().Parameters;
                param.AddWithValue("@ProductTypeName", txtProductName.Value);
                param.AddWithValue("@ProductTypeDetail", txtProductDetail.Value);
                if (active.Checked)
                    param.AddWithValue("@Active", 1);
                else
                    param.AddWithValue("@Active", 0);

                //param.AddWithValue("@UpdatePersonID", ucUserAuthen.UserAuthen.Current.UserID);
                param.AddWithValue("@UpdateDateTime", DateTime.Now);
                param.AddWithValue("@ProductTypeCode", ID);

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
    }
}