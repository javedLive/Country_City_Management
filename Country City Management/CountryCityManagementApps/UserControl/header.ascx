<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="CountryCityManagementApps.UserControl.header" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../Content/css/bootstrap.min.css" rel="stylesheet" />

    <script src="../Content/js/jquery-1.11.3.min.js"></script>

  </head> 

<body>
   

<!--NAVBAR-->
<nav class="navbar navbar-inverse navbar-fixed-top" id="main-navbar" role="navigation">
  <div class="container"> 
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>

      
      <a href="../UI/home.aspx" class="navbar-brand">Counrty Application</a>
    </div><!--end navbar-header-->

    <div class="collapse navbar-collapse" id="navbar-collapse">
        <ul class="nav navbar-nav">
          <li><a href="../UI/CountrySearchUI.aspx">Country Search</a></li>
            

            <li><a href="../UI/CitySearchUI.aspx">City Search</a></li>

          <%--<li><a href="#section-country">City Search</a></li>--%>
             <li><a href="../UI/CountryEntryUI.aspx">Country Add</a></li>
         
          <li><a href="../UI/CityEntryUI.aspx">City Add</a></li>
          <li><a href="#section-contact">Contact</a></li>          
        </ul>
    </div><!--end collapse-->

  </div> <!--end container-->
    
   
</nav> 
    
     
