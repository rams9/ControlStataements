<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Conditional.aspx.cs" Inherits="Conditional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <h1>Switch Example</h1>
        <h5>Enter 1 to 5</h5>
        <span>Lucky Number</span>
    <asp:TextBox ID="enterLucky" runat="server"></asp:TextBox>
        <asp:Button ID="btnStatus" runat="server" Text="Status" OnClick="btnStatus_Click" />
        <h3 id="userStatus" runat="server"></h3>


    </div>
        <div>
            <h1>Conditional Statements</h1>
            <asp:DropDownList ID="ddlTaxInfo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTaxInfo_SelectedIndexChanged">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
                <asp:ListItem Value="1">1 - 20k</asp:ListItem>
                <asp:ListItem Value="2">20k - 40k</asp:ListItem>
                <asp:ListItem Value="3">40k - 60k</asp:ListItem>
                <asp:ListItem Value="4">60k - 100k</asp:ListItem>
                <asp:ListItem Value="5">Above 100k</asp:ListItem>

            </asp:DropDownList>
            <h3 id="txtPercentage" runat="server"></h3>
        </div>
        <h1>For Loop Example</h1>
        <span>Enter Number</span>
        <asp:TextBox ID="mTable" runat="server"></asp:TextBox>
        <asp:Button ID="getTable" runat="server" Text="GetTable" OnClick="getTable_Click" />
        <div id="forLoop1" runat="server"></div>

        <h1>While Loop Example</h1>
        
        <span>Enter Number 1 to 100</span>
        <asp:TextBox ID="txtWhile" runat="server"></asp:TextBox>
        <asp:Button ID="btnPrint" runat="server" Text="Print Numbers" OnClick="btnPrint_Click"  />
        <div id="whileLoop1" runat="server"></div>
        <h2>Foreach</h2>
        <div id="aForEach" runat="server"></div>
        <h1>Operators</h1>
        <h1>
            Type Catsing
        </h1>
        <h3>Implicit conversion</h3>
      <p>// Implicit conversion. num long can</p>  
<p>  // hold any value an int can hold, and more!</p>  
<p>  int num = 2147483647;</p>  
<p>  long bigNum = num;</p>  

        <h3>Explicit conversion</h3>
       <p>double x = 1234.7;</p> 
       <p> int a;</p>
       <p> // Cast double to int.</p>
       <p> a = (int)x;</p>
        <p>// Output: 1234</p>
    </form>
</body>
</html>
