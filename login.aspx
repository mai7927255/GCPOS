<%@ Page Language="C#"  MasterPageFile="~/FrontEnd.Master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

		<div class="container">
            <div class="col-md-6">		<div class="form-signin">
        <h2 class="form-signin-heading">Please sign in</h2>
            <label for="inputEmail" class="sr-only">Email address</label>
                <asp:TextBox ID="UserEmail" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
            <label for="inputPassword" class="sr-only">Password</label>
             <asp:TextBox ID="UserPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        <div class="checkbox">
          <label>
            <input type="checkbox" value="remember-me"> Remember me
          </label>
        </div>
                <asp:Button CssClass="btn btn-lg btn-primary btn-block" Text="Sign in" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
      </div>
                </div>

		</div>
<br />
<br />
<br />
<br />
    <br />
<br />
<br />
<br />
    <br />
<br />
<br />
<br />
    <br />
<br />
<br />
<br />
    <br />
</asp:Content>