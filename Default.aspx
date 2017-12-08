<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Welcome to prac1."></asp:Label>
    
    </div>
        <p>
            <asp:Button ID="Btn_Calculate" runat="server" OnClick="Button1_Click" Text="Calculate" />
&nbsp;
            <asp:TextBox ID="Tb_Input_1" runat="server">0</asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <asp:TextBox ID="Tb_Input_2" runat="server">0</asp:TextBox>
&nbsp;
            <asp:Label ID="Label2" runat="server" Text="=Base10:"></asp:Label>
&nbsp;<asp:TextBox ID="Tb_Output_B10" runat="server" ReadOnly="True">0</asp:TextBox>
&nbsp;
            <asp:Label ID="Label3" runat="server" Text="=Base2:"></asp:Label>
&nbsp;<asp:TextBox ID="Tb_Output_B2" runat="server" ReadOnly="True">0</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_Count" runat="server" OnClick="Button2_Click" Text="Count" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Num of 0"></asp:Label>
&nbsp;<asp:TextBox ID="Tb_Output_Num0" runat="server" ReadOnly="True">0</asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Num of 1"></asp:Label>
&nbsp;<asp:TextBox ID="Tb_Output_Num1" runat="server" ReadOnly="True">0</asp:TextBox>
        </p>
    </form>
</body>
</html>
