<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="second_try.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        Choose the payment method</p>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:RadioButton ID="rdcardpayment" runat="server" Text="Card Payment" AutoPostBack="True" />
        </p>
        <p>
            <asp:RadioButton ID="rdcashpayment" runat="server" Text="Cash On delivery" AutoPostBack="True" />
&nbsp;&nbsp;&nbsp; (Only for orders below R1000).</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnproceedtocheckout" runat="server" OnClick="Button1_Click" Text="Proceed to delivery" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
