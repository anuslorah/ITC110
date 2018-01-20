<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza! Pizza! Pizza!</title>
    <link href="Pizzastyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Menu</h1>
        <h2>Pie size</h2>
        <asp:CheckBoxList ID="CheckBoxPie" runat="server"></asp:CheckBoxList>
        <h2>Toppings</h2>
        <asp:CheckBoxList ID="CheckBoxTopping" runat="server"></asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Submit order" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
