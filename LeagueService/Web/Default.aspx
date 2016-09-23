<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    
    <div id="header">
        <h1><center>League Stat Comparer</center></h1>
        <p></p>
    </div>

    <div id="main">
        <div class="section first">
            <h2>Search for Summoner info:</h2>
            <ul>
                <li>
                <input id="user1Info" value="Enter Summoner Info..." size="24" name ="user1Info" runat="server" /> 
                <input id="user1Submit" height="60" value="Submit" type="submit" runat="server" onserverclick="btnUser1" /> 
                    <input type="checkbox" id="toggle_update1" runat="server">/input>             
                </li>         
            </ul>
        </div>
    </div>

</asp:Content>
