using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserForm : System.Web.UI.Page
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
            sb.Append(" SELECT * FROM Mas_User");
            sb.Append(" where ID ='" + ID + "'");
            dt = ConnectDB.GetData(sb.ToString(), "User");

            if (dt.Rows.Count != 0)
            {
                
                UserAccount.Disabled = true;
                UserAccount.Value = dt.Rows[0]["AccountName"].ToString();
                fname.Value = dt.Rows[0]["FirstName"].ToString();
                Lastname.Value = dt.Rows[0]["LastName"].ToString();
                Company_name.Value = dt.Rows[0]["CompanyName"].ToString();
                Address.Value = dt.Rows[0]["Address"].ToString();
                Password.Value = dt.Rows[0]["IsPassword"].ToString();
                UserTypeCode.Value = dt.Rows[0]["UserTypeCode"].ToString();
                Boothname.Value = dt.Rows[0]["BoothName"].ToString();
                UpdateDate.Value = dt.Rows[0]["UpdateDate"].ToString();
                CreateDate.Value = dt.Rows[0]["CreateDate"].ToString();
                

                if (dt.Rows[0]["IsActive"].ToString() == "False")
                    status.Checked = false;
                else
                    status.Checked = true;
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
            sb.Append("INSERT INTO Mas_User(FirstName,LastName,CompanyName,Address,");
            sb.Append("AccountName,IsPassword,UserTypeCode,BoothName,IsActive,");
            sb.Append("CreateDate,UpdateDate)  Output Inserted.ID ");
            sb.Append("VALUES(@FirstName,@LastName,@CompanyName,@Address,");
            sb.Append("@AccountName,@IsPassword,@UserTypeCode,@BoothName,@IsActive,");
            //sb.Append("@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
            sb.Append("@CreateDate,@UpdateDate)");

            param.AddWithValue("@FirstName", fname.Value);
            param.AddWithValue("@LastName", Lastname.Value);
            param.AddWithValue("@CompanyName", Company_name.Value);
            param.AddWithValue("@Address", Address.Value);
            param.AddWithValue("@AccountName", UserAccount.Value);
            param.AddWithValue("@IsPassword", Password.Value);
            param.AddWithValue("@UserTypeCode", UserTypeCode.Value);
            param.AddWithValue("@BoothName", Boothname.Value);
            if (status.Checked)
                param.AddWithValue("@IsActive", 1);
            else
                param.AddWithValue("@IsActive", 0);

            //param.AddWithValue("@CreateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@CreateDate", DateTime.Now);
            //param.AddWithValue("@UpdateBy", ucUserAuthen.UserAuthen.Current.UserID);
            param.AddWithValue("@UpdateDate", DateTime.Now);
            string row = ConnectDB.ExecuteDataReturnID(sb.ToString(), param);
            Response.Redirect("UserForm.aspx?action=E&ID=" + row);

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
                sb.Append("UPDATE Mas_User set ");
                sb.Append("FirstName=@FirstName,");
                sb.Append("LastName=@LastName,");
                sb.Append("CompanyName=@CompanyName,");
                sb.Append("Address=@Address,");
                sb.Append("IsPassword=@IsPassword,");
                sb.Append("UserTypeCode=@UserTypeCode,");
                sb.Append("BoothName=@BoothName,");
                sb.Append("IsActive=@IsActive, ");
                sb.Append("UpdateDate=@UpdateDate ");
                sb.Append("Where ID = @ID");
               

                SqlParameterCollection param = new SqlCommand().Parameters;
                param.AddWithValue("@FirstName", fname.Value);
                param.AddWithValue("@LastName", Lastname.Value);
                param.AddWithValue("@CompanyName", Company_name.Value);
                param.AddWithValue("@Address", Address.Value);
                param.AddWithValue("@IsPassword", Password.Value);
                param.AddWithValue("@UserTypeCode", UserTypeCode.Value);
                param.AddWithValue("@BoothName", Boothname.Value);
                if (status.Checked)
                    param.AddWithValue("@IsActive", 1);
                else
                    param.AddWithValue("@IsActive", 0);

                //param.AddWithValue("@UpdatePersonID", ucUserAuthen.UserAuthen.Current.UserID);
                param.AddWithValue("@UpdateDate", DateTime.Now);
                param.AddWithValue("@ID", ID);

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
        Response.Redirect("UserMain.aspx");
        
    }
    
}