<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="FirstJQM.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
    <script src="jquery-1.11.3.min.js"></script>
    <link href="jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <script src="jquery.mobile-1.4.5.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div data-role="page" >

      <div data-role="header">
         <h3>碁峰資訊</h3>
      </div>

      <div data-role="content">
          <div data-role="collapsible-set">
            <div data-role="collapsible">
              <h3>Java 8基礎必修課</h3>
              <div style="text-align:center">
                  <p><img src="images/AEL015400.jpg" 
                      style="max-width:70%" /></p>
                  <p>作者：蔡文龍、何嘉益、張志成</p>
                  <p>單價：530</p>
              </div>
            </div>
            <div data-role="collapsible">
              <h3>Visual C# 2017基礎必修課</h3>
              <div style="text-align:center">
                  <p><img src="images/AEL019400.jpg" 
                      style="max-width:70%" /></p>
                  <p>作者：蔡文龍、歐志信、何嘉益、張志成</p>
                  <p>單價：530</p>
              </div>
            </div>
            <div data-role="collapsible">
              <h3>Visual C# 2017程式設計經典</h3>
              <div style="text-align:center">
                  <p><img src="images/AEL014300.jpg" 
                      style="max-width:70%" /></p>
                  <p>作者：蔡文龍</p>
                  <p>單價：650</p>
              </div>
            </div>
            <div data-role="collapsible">
              <h3>Visual Basic 2017程式設計經典</h3>
              <div style="text-align:center">
                  <p><img src="images/AEL014700.jpg" 
                      style="max-width:70%" /></p>
                  <p>作者：蔡文龍</p>
                  <p>單價：650</p>
              </div>
            </div>
         </div>
      </div>

      <div data-role="footer" data-position="fixed">
        <h3>碁峰版權所有</h3>
      </div>

    </div>
    </form>
</body>
</html>
