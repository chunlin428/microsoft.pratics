<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossFieldValidationWithLocalType.aspx.cs" Inherits="_Default" %>

<%@ Register Namespace="Microsoft.Practices.EnterpriseLibrary.Validation.Integration.AspNet"
    TagPrefix="entlibvalidation" Assembly="Microsoft.Practices.EnterpriseLibrary.Validation.Integration.AspNet" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="NameText" runat="server" Text="0123456789012345" />
            <entlibvalidation:PropertyProxyValidator ID="NameValidator" runat="server"
                SourceTypeName="DomainModel.DomainObject" PropertyName="Name" ControlToValidate="NameText"
                SpecificationSource="Attributes" RulesetName="cross field" />
            <br />
            <asp:TextBox ID="SurNameText" runat="server" Text="0123456789012345" />
            <entlibvalidation:PropertyProxyValidator ID="SurNameValidator" runat="server"
                SourceTypeName="DomainModel.DomainObject" PropertyName="SurName" ControlToValidate="SurNameText"
                SpecificationSource="Attributes" RulesetName="cross field" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" /></div>
    </form>
</body>
</html>
