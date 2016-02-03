<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountrySearchUI.aspx.cs" Inherits="CountryCityManagementApps.UI.CountrySearchUI" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register Src="~/UserControl/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/UserControl/footer.ascx" TagPrefix="uc1" TagName="footer" %>





<uc1:header runat="server" ID="header" />
<div style="padding: 100px">
    
     <form runat="server" CssClass="form">
        
         <asp:ScriptManager runat="server">
             
         </asp:ScriptManager>

              <h4><asp:label runat="server" text="Label" CssClass="label label-primary" >Country Search</asp:label></h4>
              
         <div class="col-xs-4">                
         <asp:textbox runat="server" placeholder="Country" CssClass="form-control" ID="countrySearchTextBox"></asp:textbox>
           
             <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server"
                 TargetControlID="countrySearchTextBox"
                 MinimumPrefixLength="1"
                 EnableCaching="true"
                 CompletionSetCount="1"
                 CompletionInterval="1000"
                 ServiceMethod="GetCompletionList"
                 >
                 
             </ajaxToolkit:AutoCompleteExtender>

           
             
           

           
        </div>
              
            <div>
                 <asp:button runat="server" text="Search" CssClass="btn btn-info btn-sm" ID="CountrySearchButton" OnClick="CountrySearchButton_Click"/>  
               
            </div>
        
                    
      
         <br/>
         <div style="width: 660px; height: 210px">
             
             <asp:gridview runat="server" HtmlEncode="false" CssClass="table table-hover table-striped" AutoGenerateColumns="False" ID="countrySearchGridView" Height="68px" Width="629px" AllowPaging="True" OnPageIndexChanging="countrySearchGridView_PageIndexChanging" PageSize="1">
              <Columns>
                  <asp:TemplateField HeaderText="#SL">
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
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
                  
                   <asp:TemplateField HeaderText="No of City">
                        <ItemTemplate>
                            <%#Eval("CityName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                  
                    <asp:TemplateField HeaderText="No of Dwellers">
                        <ItemTemplate>
                            <%#Eval("NoOfDwellers") %>
                        </ItemTemplate>
                    </asp:TemplateField>

              </Columns>
          </asp:gridview>
         </div>

     </form>

    </div>

    
<uc1:footer runat="server" ID="footer" />
