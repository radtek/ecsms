﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewCalender.aspx.cs" Inherits="Calender_ViewCalender" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style=" font-size:12px; font-family:微软雅黑;">
    <form id="form1" runat="server">
    <div>
    <fieldset>
    <legend style="font-size:14px; font-weight:bold;">日程</legend>
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Calender/AddCalendar.aspx" Text="新建日程" />
    <asp:DataList ID="DataList1" runat="server" Width="100%" DataKeyField="id" 
            OnEditCommand="dlEdit" OnDeleteCommand="dlDel">
    <HeaderTemplate >
    <table style=" width:100%; border:solid 1px #EDEFEA; text-align:center;" >
    <tr  style=" background-color:#98CDFF;">    
    <th>编号</th>
    <th>日程标题</th>
    <th>日程时间</th>  
    <th>操作</th>
    </tr>    
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
    <td><%#Eval("id") %></td>
    <td><%#Eval("title") %></td> 
    <td><%#Convert.ToDateTime(Eval("todotime").ToString()).ToString("yyyy-MM-dd HH:mm:ss")%></td>
    <td>
    <asp:LinkButton ID="lbtnEdit" runat="server"  CommandName="Edit">[修改]</asp:LinkButton>
    <asp:LinkButton ID="lbtnDel" runat="server"  CommandName="Delete" OnClientClick="javascript:return confirm('你确定要删除么？')">[删除]</asp:LinkButton>
    </td>
    </tr>    
    </ItemTemplate>
    <AlternatingItemTemplate>
    <tr style=" background-color:#EDF6FD;">    
    <td><%#Eval("id") %></td>
    <td><%#Eval("title") %></td>
    <td><%#Convert.ToDateTime(Eval("todotime").ToString()).ToString("yyyy-MM-dd HH:mm:ss")%></td>
    <td>
    <asp:LinkButton ID="lbtnEdit" runat="server"  CommandName="Edit">[修改]</asp:LinkButton>
    <asp:LinkButton ID="lbtnDel" runat="server"  CommandName="Delete" OnClientClick="javascript:return confirm('你确定要删除么？')">[删除]</asp:LinkButton>
    </td>
    </tr> 
    </AlternatingItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    
    </asp:DataList>

    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" 
         PageSize="10"
         FirstPageText="首页"
         LastPageText="末页"
         NextPageText="下一页"
         PrevPageText="上一页" 
         Font-Size="12px"          
         OnPageChanging="AspNetPager1_PageChanging">
    </webdiyer:AspNetPager>
    </fieldset>
    </div>
    </form>
</body>
</html>
