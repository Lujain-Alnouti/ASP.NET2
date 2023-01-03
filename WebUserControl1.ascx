<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Task1_2_1.WebUserControl1" %>

<style>
    .divv{
        width:150px;
        margin-left:20%;
        border:2px solid black;

    }
</style>
<div class="divv">
    <h4>Your Opinion</h4>
    <input id="excellent" type="radio" name="vo" runat="server"/>
    <asp:Label ID="Label1" runat="server" Text="Excellent"></asp:Label><br />
    <input id="verygood" type="radio" name="vo" runat="server"/>
    <asp:Label ID="Label2" runat="server" Text="Verygood"></asp:Label><br />
    <input id="good" type="radio" name="vo" runat="server"/>
    <asp:Label ID="Label3" runat="server" Text="Good"></asp:Label><br />
    <input id="poor" type="radio" name="vo" runat="server" />
    <asp:Label ID="Label4" runat="server" Text="Poor"></asp:Label><br />
    <input id="acceptable" type="radio" name="vo" runat="server"/>
    <asp:Label ID="Label5" runat="server" Text="Acceptable"></asp:Label><br />

    <br />
    <asp:Button ID="Button1" runat="server" Text="Voting" OnClick="Button1_Click" />
    <br />

</div>
