<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Play!" />
        <br />
        <asp:Label ID="player1Label" runat="server"></asp:Label>
        <br />
        <asp:Label ID="player2Label" runat="server"></asp:Label>
        <br />
        <asp:Label ID="winLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
