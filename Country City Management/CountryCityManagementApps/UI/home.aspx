<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="CountryCityManagementApps.UI.Home" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>



<%@ Register src="../UserControl/header.ascx" tagname="header" tagprefix="uc1" %>


<%@ Register src="../UserControl/footer.ascx" tagname="footer" tagprefix="uc2" %>


<form id="form1" runat="server">
    <uc1:header ID="header1" runat="server" />
    
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>
 
  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
        <img src="../Image/img3.jpg" />
      <div class="carousel-caption">
          <h3>Caption Text</h3>
      </div>
    </div>
    <div class="item">
        <img src="../Image/img1.jpg" />
      <div class="carousel-caption">
          <h3>Caption Text</h3>
      </div>
    </div>
    <div class="item">
        <img src="../Image/img2.jpg" />
      <%--<img src="http://placehold.it/1200x315" alt="...">--%>
      <div class="carousel-caption">
          <h3>Caption Text</h3>
      </div>
    </div>
  </div>
 
  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
  </a>
</div> <!-- Carousel -->
      
    <uc2:footer ID="footer1" runat="server" />
</form>


