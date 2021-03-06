﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GiveLog.aspx.cs" Inherits="GiveLog" %>
<%@ Register assembly="ZLTextBox" namespace="BaseText" tagprefix="cc1" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <script type="text/javascript">
     function editRemark(id) {
         OpenWindow("EditGiveLogRemark.aspx?id="+id, 400, 300);
     }
     function OpenWindow(url, width, height) {
         window.open(url,
            "",
            "top=50, left=150,height=" + height + ", width=" + width + ",toolbar=no,menubar=no,scrollbars=yes,resizable=yes,location=no,status=no",
            "")
     }
 </script>
</head>
<body style=" font-size:12px; font-family:微软雅黑;">
    <form id="form1" runat="server">
    <div>
    <fieldset>
    <legend style="font-size:14px; font-weight:bold;">短信分配记录</legend>
        <table>
            <tr>
                <td align="right">
                    开始时间:</td>
                <td>
                    <cc1:ZLTextBox ID="txtStartDate" ToolTip="点击选择时间，支持到小时、分钟、秒" runat="server" InputType="date" 
                        IsDisplayTime="True" Width="120px"></cc1:ZLTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtStartDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    结束时间:<cc1:ZLTextBox ID="txtEndDate" ToolTip="点击选择时间，支持到小时、分钟、秒"  runat="server" InputType="date" 
                        IsDisplayTime="True" Width="120px"></cc1:ZLTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtEndDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    查询客户：<asp:TextBox ID="txtName" Width="120px" runat="server" ToolTip="可按客户账号或姓名查询，清空则查询全部用户记录"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnQuery" runat="server" ToolTip="请尽量减小时间段，以免查询对服务器产生较大压力。" Text="查询" onclick="btnQuery_Click" /> 
                    <asp:Button ID="btnExport" runat="server" Text="导出" onclick="btnExport_Click" />
                </td>
            </tr>
 
                   
 
        </table><br />
        共有分配记录【<asp:Label ID="lblCount" runat="server" Text="0"></asp:Label>】条<hr />
 <asp:DataList ID="DataList1" runat="server" Width="100%">
    <HeaderTemplate >
    <table style=" width:100%; border:solid 1px #EDEFEA; text-align:center;" >
    <tr  style=" background-color:#98CDFF;">    
    <th>账号</th>
    <th>短信类型</th>
    <th>操作类型</th>
    <th>增减条数</th>
    <th>充后余额</th>
    <th>充值备注</th> 
    <th>分配人</th>
    <th>操作时间</th> 
    </tr>    
    </HeaderTemplate>
    <ItemTemplate>
    <tr>    
    <td><%#Eval("account") %></td>
    <td><%#Public.GetProNameByLetter( Eval("smstype").ToString())%></td>
    <td><%#Eval("acttype").ToString()=="add"?"充值":"扣值"%></td>
    <td><%#Eval("smscount")%></td>
    <td><%#Eval("leavenum") %></td>
    <td onclick="editRemark(<%#Eval("id") %>)" style=" cursor:pointer;" title="点击可修改备注"><%#Eval("remark") %></td>
    <td><%#Public.GetUserAccount(int.Parse(Eval("fromuserid").ToString()))%></td>
     
    <td><%#Convert.ToDateTime(Eval("opertime").ToString()).ToString("yyyy-MM-dd HH:mm:ss")%></td>
    
    </tr>    
    </ItemTemplate>    
    <AlternatingItemTemplate>
    <tr style=" background-color:#EDF6FD;">    
    <td><%#Eval("account") %></td>
    <td><%#Public.GetProNameByLetter( Eval("smstype").ToString())%></td>
    <td><%#Eval("acttype").ToString()=="add"?"充值":"扣值"%></td>
    <td><%#Eval("smscount")%></td>
    <td><%#Eval("leavenum") %></td>
    <td onclick="editRemark(<%#Eval("id") %>)" style=" cursor:pointer;" title="点击可修改备注"><%#Eval("remark") %></td>
    <td><%#Public.GetUserAccount(int.Parse(Eval("fromuserid").ToString()))%></td>
    <td><%#Convert.ToDateTime(Eval("opertime").ToString()).ToString("yyyy-MM-dd HH:mm:ss")%></td>
    
    </tr> 
    </AlternatingItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>    
    </asp:DataList>

    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" 
         PageSize="20"
         FirstPageText="首页"
         LastPageText="末页"
         NextPageText="下一页"
         PrevPageText="上一页" 
         Font-Size="12px"          
         OnPageChanging="AspNetPager1_PageChanging">
    </webdiyer:AspNetPager>
        <br />
        <br />
    
    </fieldset>
    </div>
    </form>
</body>
</html>
