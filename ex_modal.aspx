<%@ Page Language="C#"  MasterPageFile="~/FrontEnd.Master" AutoEventWireup="true" CodeFile="ex_modal.aspx.cs" Inherits="ex_modal" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <script type="text/javascript">
        function showModal() {
            $('#myModal').modal()
        }

    </script>


    <section>
        <br />
        <br />

  <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
  Launch demo modal 1
</button>

          <button type="button" class="btn btn-primary" onclick="showModal();">
  Launch demo modal 2
</button>
     <br />
        <br />
        <br />
        <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog modal-lg">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">หัวข้อ</h4>
        </div>
        <div class="modal-body">
  
        </div>
        <div class="modal-footer">
            
          <button type="button" class="btn btn-default" data-dismiss="modal">ปิด</button>
        </div>
      </div>
      
    </div>
  </div>

    </section>


</asp:Content>