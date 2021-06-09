<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginform.aspx.cs" Inherits="hallbooking.loginform" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hall Booking System</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="bootstrap.min.css" rel="stylesheet" />

     
</head>
<body>
    <form id="form1" runat="server">
    

        <section class="cover">
    
            <div>
                <div class="elements">
                    <div class="intro">
                        <asp:Label ID="Label1" style="color:black;text-decoration:underline;" runat="server" Text="<b>WELCOME</b>"></asp:Label>
                        
                        
                        <asp:TextBox ID="TextBox1" CssClass="txt1 txtstyle" style="border:3px inset red;color:black;" placeholder="Username" runat="server"></asp:TextBox>
                        
                        
                        <asp:TextBox ID="TextBox2" CssClass="txt2 txtstyle" style="border:3px inset red;color:black; " placeholder="Password" TextMode="Password"  runat="server"></asp:TextBox>
                         &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                        <asp:Label ID="msg" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="Large"/>
                        <br />
                        <br />
                        <asp:Label ID="Label3"  runat="server" Text="<b>LOGIN AS:<b/>" style="margin-left: 3vw;color:black;
                                                                                    background-color:white;
                                                                                    font-size:30px;
                                                                                    
                                                                                    font-family: fantasy;
                                                                                    text-shadow: black 0px 40px 40px;"></asp:Label>
                         <asp:DropDownList id="DropDownList1" runat="server" style="margin:3px;box-shadow: black 0px 40px 100px;color:black;background-color:white;margin-left:3vw; font-size:x-large;display:inline-block;"  >   
                               
                           <asp:ListItem value="user" selected="True">  
                              User  
                           </asp:ListItem>  
                           <asp:ListItem value="admin" >  
                              Admin  
                           </asp:ListItem>
                           <asp:ListItem value="chef" >  
                              Developer  
                           </asp:ListItem>
                        </asp:DropDownList>  
                        
                        
                       
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>




