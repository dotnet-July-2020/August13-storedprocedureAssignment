<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connectedobjects1.aspx.cs" Inherits="sqlwebapp.connectedobjects1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="227px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="294px">
            </asp:GridView>
            <br />
            <br />
            EMPID<asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
            <br />
            <br />
            EMPNAME<asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
            <br />
            <br />
            EMPSALARY<asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="update" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
