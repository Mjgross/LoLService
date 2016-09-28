<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="summoner.aspx.cs" Inherits="Webs.summoner" MasterPageFile="~/Site.Master"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<head>
    <link href="https://fonts.googleapis.com/css?family=Baloo+Tamma" rel="stylesheet1">
   <style>


        h1 {
            font-size: 48px;
            font-weight: normal;
            margin: 0px;
            padding: 0 30px;
            line-height: 100px;
        }

        p {
            font-size: 20px;
            color: #fff;
            background: #969696;
            padding: 0 30px;
            line-height: 50px;
        }

        #main {
            padding: 5px 30px;
        }

        .section {
            width: 21.7%;
            float: left;
            margin: 0 0 0 4%;
        }

            .section h2 {
                font-size: 13px;
                text-transform: uppercase;
                margin: 0;
                border-bottom: 1px solid silver;
                padding-bottom: 12px;
                margin-bottom: 8px;
            }

            .section.first {
                margin-left: 0;
            }

                .section.first h2 {
                    font-size: 24px;
                    text-transform: none;
                    margin-bottom: 25px;
                    border: none;
                }

                .section.first li {
                    border-top: 1px solid silver;
                    padding: 8px 0;
                }

            .section.last {
                margin-right: 0;
            }

        ul {
            list-style: none;
            padding: 0;
            margin: 0;
            line-height: 20px;
        }

        li {
            padding: 4px 0;
        }

        a {
            color: #267cb2;
            text-decoration: none;
        }

            a:hover {
                text-decoration: underline;
            }
    </style>
</head>
<body>
    <div class ="SummonerLayout">
       <div class ="SummonerHeader">
           <div class ="Championbar"> </div>
           <div class ="summonerIcon"> 
               <div class="sumIcon">
                   <img src= "http://cdn.idstatic.com/cms/live/39/blank_Transparent128x128.png" height ="128" width ="128" name="sumIcon" runat="server" />
               </div>
           </div>
           <div class="summonerInfo"></div>
           <div class ="summonerUpdate"> </div>
           <div class ="Champions">
               <div class ="ChampionIcon"></div>
               <div class ="Championselect"></div>
           </div>
       </div>
    </div>
</body>

</asp:Content>
