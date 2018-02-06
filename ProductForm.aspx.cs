using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductForm : System.Web.UI.Page
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
            Product_form.Visible = false;

        }
    }

    public void EditData(string ID)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            DataTable dt = new DataTable();
            sb.Append(" SELECT * FROM Mas_Product");
            sb.Append(" where ProductCode ='" + ID + "'");
            dt = ConnectDB.GetData(sb.ToString(), "Product");

            if (dt.Rows.Count != 0)
            {

                pd_code.Disabled = true;
                pd_code.Value = dt.Rows[0]["ProductCode"].ToString();
                pd_urent.Value = dt.Rows[0]["Urent"].ToString();
                pd_thainame.Value = dt.Rows[0]["ProductDetailTH"].ToString();
                pd_engname.Value = dt.Rows[0]["ProductDetailEN"].ToString();
                pd_size.Value = dt.Rows[0]["ProductSize"].ToString();
                pd_color.Value = dt.Rows[0]["ProductColor"].ToString();
                pd_type.Value = dt.Rows[0]["ProductTypeCode"].ToString();
                pd_group.Value = dt.Rows[0]["ProductGroupCode"].ToString();
                pd_amount.Value = dt.Rows[0]["ProductAmount"].ToString();

                update_date.Value = dt.Rows[0]["UpdateDate"].ToString();
                create_date.Value = dt.Rows[0]["CreateDate"].ToString();
                updateby.Value = dt.Rows[0]["UpdateBy"].ToString();
                createby.Value = dt.Rows[0]["CreateBy"].ToString();



                if (dt.Rows[0]["IsActive"].ToString() == "False")
                    status.Checked = false;
                else
                    status.Checked = true;
            }
            else
            {
                Product_form.Visible = false;
            }


        }
        catch (Exception ex)
        {
            Product_form.Visible = false;
            Response.Write(ex.Message.ToString());
        }
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            SqlParameterCollection param = new SqlCommand().Parameters;
            sb.Append("INSERT INTO Mas_Product(ProductCode,Urent,ProductDetailTH,ProductDetailEN,");
            sb.Append("ProductSize,ProductColor,ProductTypeCode,ProductGroupCode,ProductAmount,IsActive,CreateBy,UpdateBy,");
            sb.Append("CreateDate,UpdateDate)  Output Inserted.ProductCode ");
            sb.Append("VALUES (@ProductCode,@Urent,@ProductDetailTH,@ProductDetailEN,");
            sb.Append("@ProductSize,@ProductColor,@ProductTypeCode,@ProductGroupCode,@ProductAmount,@IsActive,@CreateBy,@UpdateBy,");
            sb.Append("@CreateDate,@UpdateDate)");

            param.AddWithValue("@ProductCode", pd_code.Value);
            param.AddWithValue("@Urent", pd_urent.Value);
            param.AddWithValue("@ProductDetailTH", pd_thainame.Value);
            param.AddWithValue("@ProductDetailEN", pd_engname.Value);
            param.AddWithValue("@ProductSize", pd_size.Value);
            param.AddWithValue("@ProductColor", pd_color.Value);
            param.AddWithValue("@ProductTypeCode", pd_type.Value);
            param.AddWithValue("@ProductGroupCode", pd_group.Value);
            param.AddWithValue("@ProductAmount", pd_amount.Value);
            param.AddWithValue("@CreateBy", createby.Value);
            param.AddWithValue("@UpdateBy", updateby.Value);

            if (status.Checked)
                param.AddWithValue("@IsActive", 1);
            else
                param.AddWithValue("@IsActive", 0);

            //param.AddWithValue("@CreateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@CreateDate", DateTime.Now);
            //param.AddWithValue("@UpdateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@UpdateDate", DateTime.Now);
            string row = ConnectDB.ExecuteDataReturnID(sb.ToString(), param);
            Response.Redirect("ProductForm.aspx?action=E&ID=" + row);

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
            Product_form.Visible = false;
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
                sb.Append("UPDATE Mas_Product set ");
               // sb.Append("ProductCode=@ProductCode,");
                sb.Append("Urent=@Urent,");
                sb.Append("ProductDetailTH=@ProductDetailTH,");
                sb.Append("ProductDetailEN=@ProductDetailEN,");
                sb.Append("ProductSize=@ProductSize,");
                sb.Append("ProductColor=@ProductColor,");
                sb.Append("ProductTypeCode=@ProductTypeCode,");
                sb.Append("ProductGroupCode=@ProductGroupCode,");
                sb.Append("ProductAmount=@ProductAmount,");
                sb.Append("CreateBy=@CreateBy,");
                sb.Append("UpdateBy=@UpdateBy,");
                sb.Append("CreateDate=@CreateDate,");
                sb.Append("UpdateDate=@UpdateDate,");
                sb.Append("IsActive=@IsActive ");
                sb.Append("Where ProductCode = @ProductCode");
               

                SqlParameterCollection param = new SqlCommand().Parameters;
               // param.AddWithValue("@ProductCode", pd_code.Value);
                param.AddWithValue("@Urent", pd_urent.Value);
                param.AddWithValue("@ProductDetailTH", pd_thainame.Value);
                param.AddWithValue("@ProductDetailEN", pd_engname.Value);
                param.AddWithValue("@ProductSize", pd_size.Value);
                param.AddWithValue("@ProductColor", pd_color.Value);
                param.AddWithValue("@ProductTypeCode", pd_type.Value);
                param.AddWithValue("@ProductGroupCode", pd_group.Value);
                param.AddWithValue("@ProductAmount", pd_amount.Value);
                param.AddWithValue("@CreateBy", createby.Value);
                param.AddWithValue("@UpdateBy", updateby.Value);

                if (status.Checked)
                    param.AddWithValue("@IsActive", 1);
                else
                    param.AddWithValue("@IsActive", 0);

                //param.AddWithValue("@UpdatePersonID", ucUserAuthen.UserAuthen.Current.UserID);
               
                param.AddWithValue("@UpdateDate", DateTime.Now);
                param.AddWithValue("@CreateDate", DateTime.Now);
                param.AddWithValue("@ProductCode", ID);

                //ConnectDB db = new ConnectDB();
                ConnectDB.ExecuteData(sb.ToString(), param);

            }
            else
            {
                Product_form.Visible = false;
            }


        }
        catch (Exception ex)
        {
            //registrationForm.Visible = false;
            Response.Write(ex.Message.ToString());
        }
        Response.Redirect("ProductMain.aspx");

    }
}