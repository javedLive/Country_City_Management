<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntryUI.aspx.cs" Inherits="CountryCityManagementApps.UI.CityEntryUI" %>


<%@ Register src="../UserControl/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register Src="~/UserControl/footer.ascx" TagPrefix="uc1" TagName="footer" %>





    <uc1:header ID="header1" runat="server" />
    
    <div style="padding: 100px">
    <h2><asp:label runat="server" CssClass="label label-primary" ID="messageBoxLabel"></asp:label></h2>

    <form runat="server" CssClass="form">
        <p></p>

       <h3> <asp:ValidationSummary  ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <p></p>
        
        
        
        <script type="text/javascript">
    function HideLabel() {
        document.getElementById('<%= messageBoxLabel.ClientID %>').style.display = "none";
        }
        setTimeout("HideLabel();", 3000);
    </script>

        <h2>City EntryEntry</h2>

        <div class="form-group">        
        Name: </h3>
         <asp:textbox runat="server" CssClass="form-control" ID="cityNameTextBox"></asp:textbox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cityNameTextBox" ErrorMessage="Please Inter City Name" ForeColor="Red">*</asp:RequiredFieldValidator>
            
        </div>
        <div class="form-group">        
         <h3>About: out: </h3>
         <asp:textbox runat="server" CssClass="form-control" Rows="6" TextMode="MultiLine" ID="cityAboutTextBox" HtmlEncode="false" CausesValidation="True" ValidateRequestMode="Disabled" ViewStateMode="Disabled"></asp:textbox>        
        </div>
        <div class="form-group">        
         <h3>No of Dwellers: 
             <asp:Label runat="server" CssClass="label label-primary" Text="(Only Number Input)"></asp:Label>
            </h3>
         <asp:textbox runat="server" CssClass="form-control" ID="noOfDwellersTextBox" TextMode="Number"></asp:textbox>
           
          
            <br />
           
        </div>
        <div class="form-group">        
         <h3>Loaction: </h3>
         <asp:textbox runat="server" CssClass="form-control" ID="locationTextBox"></asp:textbox>
        </div>

        <div class="form-group">        
         <h3>Weather: </h3>
         <asp:textbox runat="server" CssClass="form-control" ID="weatherTextBox"></asp:textbox>
        </div>        
        <div class="form-group">
         <h3>Country: </h3>
            <asp:DropDownList ID="counrtyDropDownList" CssClass="form-control" runat="server">
        </asp:DropDownList>
        </div>
                      
        <div>
            <asp:button CssClass="btn btn-info" runat="server" text="Submit" ID="submitButton" OnClick="submitButton_Click" />
            
        </div>
        <br/>
        <div>
            <asp:gridview runat="server" HtmlEncode="false" CssClass="table table-hover table-striped" ID="cityWiseCountryGridView" AutoGenerateColumns="False" Width="904px" PageSize="5" AllowPaging="True" OnPageIndexChanging="cityWiseCountryGridView_PageIndexChanging">
              <Columns>
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

              </Columns>

            </asp:gridview>
        </div>

    </form>
</div>

    <uc1:footer runat="server" ID="footer" />




