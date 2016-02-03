<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CitySearchUI.aspx.cs" Inherits="CountryCityManagementApps.UI.CitySearchUI" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register Src="~/UserControl/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/UserControl/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<head>
    <style type="text/css">
        .table-striped {}
    </style>
</head>



<uc1:header runat="server" ID="header" />

<div style="padding: 100px" class="container">
    
     <form runat="server" CssClass="form">
         
         <asp:scriptmanager runat="server">
             
         </asp:scriptmanager>

    <div class="form-group">
        <asp:label runat="server" CssClass="label label-primary" text="Label">City Search</asp:label>        
    </div>
    <div class="form-group">
        
        <asp:radiobutton runat="server" ID="cityNameRadioButton" GroupName="ser" Text="CityName"></asp:radiobutton>
        <asp:textbox runat="server" CssClass="form-control" ID="citySearchTextBox"></asp:textbox>
        
        <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server"
            TargetControlID="citySearchTextBox"
            MinimumPrefixLength="1"
             EnableCaching="true"
                 CompletionSetCount="1"
                 CompletionInterval="1000"
            
            ServiceMethod="GetCompletionListCity">
            
        </ajaxToolkit:AutoCompleteExtender>


    </div>
    <div class="form-group">
        <asp:radiobutton runat="server" ID="countryNameRadioButton" GroupName="ser" Text="CountryName"></asp:radiobutton>
        <asp:dropdownlist runat="server" CssClass="form-control" ID="allCountryNameDropDownList"></asp:dropdownlist>
        <br/>
        <asp:button runat="server" CssClass="btn btn-info" text="Search" ID="allSearchButton" OnClick="allSearchButton_Click" />
    </div>
         
         <div>
             <asp:gridview runat="server"  HtmlDecode="false" CssClass="table table-hover table-striped"  ID="citySearchGirdView" AutoGenerateColumns="False" Height="100px" Width="826px" AllowPaging="True" OnPageIndexChanging="citySearchGirdView_PageIndexChanging" PageSize="2">
                 <columns>
                                       
                    <asp:TemplateField HeaderText="#SL">
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City Name">
                        <ItemTemplate>
                            <%#Eval("CityName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <%--<asp:BoundField DataField="CountryAbout" HtmlEncode="false" />--%>
                    <asp:TemplateField HeaderText="City About">
                        <ItemTemplate>
                            <%#Eval("CityAbout") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="No of Dwellers">
                        <ItemTemplate>
                            <%#Eval("NoOfDwellers") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     
                     <asp:TemplateField HeaderText="Location">
                        <ItemTemplate>
                            <%#Eval("Location") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     
                     <asp:TemplateField HeaderText="Weather">
                        <ItemTemplate>
                            <%#Eval("Weather") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     
                       <asp:TemplateField HeaderText="Country Name">
                        <ItemTemplate>
                            <%#Eval("CountryName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     
                       <asp:TemplateField HeaderText="Country About">
                        <ItemTemplate>
                            <%#Eval("CountryAbout") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                </columns>
             </asp:gridview>
         </div>
    </form>
    </div>
<uc1:footer runat="server" ID="footer" />
