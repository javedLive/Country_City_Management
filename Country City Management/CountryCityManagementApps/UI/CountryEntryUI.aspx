<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntryUI.aspx.cs" Inherits="CountryCityManagementApps.UI.CountryEntry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register Src="~/UserControl/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/UserControl/footer.ascx" TagPrefix="uc1" TagName="footer" %>



                        <uc1:header runat="server" ID="header" />
<script src="../Content/js/jquery-1.11.3.min.js"></script>

<div style="padding: 100px">
    <h2><asp:label runat="server" CssClass="label label-primary" ID="messageBoxLabel"></asp:label></h2>

    <form runat="server" CssClass="form">
        <p></p>
    
        <h3><asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /></h3>
    
    <script type="text/javascript">
    function HideLabel() {
        document.getElementById('<%= messageBoxLabel.ClientID %>').style.display = "none";
        }
        setTimeout("HideLabel();", 3000);
    </script>

        <h2>County Entry</h2>

        <div class="form-group">        
         <h3>Name: </h3>
         <asp:textbox runat="server" CssClass="form-control" ID="countryNameTextBox"></asp:textbox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="countryNameTextBox" ErrorMessage="Enter Country Name" ForeColor="Red">*</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">        
         <h3>About: </h3>
         <asp:textbox runat="server" CssClass="form-control" Rows="6" TextMode="MultiLine" ID="countryAboutTextBox" HtmlEncode="false" CausesValidation="True" ValidateRequestMode="Disabled" ViewStateMode="Disabled"></asp:textbox>
        
        </div>
        <div>
            <asp:button CssClass="btn btn-info" runat="server" text="Submit" ID="submitButton" OnClick="submitButton_Click" />
            
        </div>
        <br/>
        <div>
            <asp:gridview runat="server" HtmlEncode="false" CssClass="table table-hover table-striped"  Width="741px" ID="countryGridView" AutoGenerateColumns="False">
                <columns>
                                       
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
                    
                    <%--<asp:BoundField DataField="CountryAbout" HtmlEncode="false" />--%>
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
