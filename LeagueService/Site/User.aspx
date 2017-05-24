<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="User.aspx.cs" Inherits="Site.User" %>


<asp:content id="Content1" contentplaceholderid="MainContent" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
        <style>
            .tester {
                height : 2000px;
                width:100%;
            }

            .userImg{
                width:256px;
                height:256px;
                background:url(http://goo.gl/vyAs27) no-repeat scroll 0 0;
            }

            .userImgBorder{
                width:256px;
                height:256px;
                border:5px solid black;
            }

            .userName{
                width:50%;
            }

            .UserContainer{
                width:100%;
                height:400px;
                border: 5px solid black;
                padding: 10px;

            }
        </style>
    </head>
    <body>
        <form id="form2">
            <div>
                <div class="tester">
                    <div class="container">
                        <div class="userContainer">

                        
                        <div class="col-md-6">
                            <div class="userImgBorder">
                                <div class="userImg">
                                    img test
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                           <div class="userName">
                               TEST -- username
                           </div> 
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </body>
    </html>
</asp:content>
