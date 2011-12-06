<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Agent_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html;charset=gb2312" />
	<title>���ű�ƽ̨--��ĵ�������</title>
	<meta content="���ű�������ţ�֣�ݶ���ƽ̨��֣�ݶ���Ⱥ����֣�ݶ���Ⱥ�������֣�ݶ���Ⱥ����˾��֣�ݶ���Ⱥ��ҵ��֣�ݶ���Ⱥ�����" name="keywords">
	<meta content="��ҵ����Ⱥ����ѡƷ��,�ƶ���ͨ����ֱ�����أ���ǶCRM�ͻ�����ϵͳ��5���ȶ������ѷ����������ҵ����ʹ�����ޣ���ӭ������ã�0371-66222261��name="description">
	<meta name="robots" content="index, follow" />
	<meta name="googlebot" content="index, follow" />
	
	<link href="css/style_100106.css" rel="stylesheet" type="text/css" />
	
<script type="text/javascript">
<!--
    var gIEVersion = ""; //���������
    var gVersionNum = 0; //������汾��
    
    function checklogin() {
        if (document.getElementById("iptUser").value == "") {
            document.getElementById("error_div").innerHTML = "�����������û���";
            document.getElementById("iptUser").focus();
            return false;
        }
        if (document.getElementById("iptPwd").value == "") {
            document.getElementById("error_div").innerHTML = "��������������";
            document.getElementById("iptPwd").focus();
            return false;
        }
    }
    
    
    function fCheck() {
        var bOk = false;
        var s = "";
        var fm = document.form;
        s = fm.style.value;

        fm.user.value = fTrim(fm.user.value); //Trim the input value.
        if (!fCheckCookie()) {
            return false;
        }
        if (fm.user.value == "") {
            document.getElementById("error_div").innerHTML = "����������û���";
            fm.user.focus();
            return false;
        }

        if (fm.password.value.length == "") {
            document.getElementById("error_div").innerHTML = "�������������";
            fm.password.focus();
            return false;
        }
    }

    function fTrim(str) {
        return str.replace(/(^\s*)|(\s*$)/g, "");
    }

    function fGetIEVersion() {
        var IEAppName = window.navigator.appName; 					//�õ���ǰ���������.
        var IEversion = window.navigator.appVersion; 				//�õ���ǰ������İ汾˵��
        if (IEAppName.indexOf("Microsoft") < 0) {
            gIEVersion = IEAppName;
            return 0;
        }
        var isOpera = window.navigator.userAgent.indexOf("Opera") > -1;
        if (isOpera) {
            gIEVersion = "Opera";
            return 0;
        }

        var k = IEversion.indexOf("MSIE"); 				//����IE�İ汾��
        if (k >= 0) {
            k += 4;
            var j = IEversion.indexOf(";", k);
            if (j < 0) {
                j = IEversion.length - 1;
            }
            IEversion = IEversion.substring(k, j) * 1; 			//�õ�IE�İ汾�ţ��������ֻ�
            gIEVersion = "MSIE: " + IEversion;
            if (IEversion >= 6) {										//����汾��6.0���ϣ�
                return 6;
            } else if (IEversion >= 5.5 && IEversion < 6) {
                return 5.5;
            } else if (IEversion >= 5 && IEversion < 5.5) {
                return 5;
            }
            else {
                return 0;
            }
        } else {
            gIEVersion = window.navigator.appVersion;
            return 0;
        }
    }
    gVersionNum = fGetIEVersion();

    function Cookie(document, name, domain) {
        this.$document = document;
        this.$name = name;
        this.$expiration = new Date(2099, 12, 31);
        this.$domain = domain;
        this.data = null;
    }
    Cookie.prototype.store = function() {
        var cookieval = "";
        if (this.data != null) {
            for (var i = 0; i < this.data.length; i++) {
                cookieval += this.data[i].join(":") + "&";
            }
        }
        if (cookieval != "" && cookieval.charAt(cookieval.length - 1) == "&")
            cookieval = cookieval.substring(0, cookieval.length - 1);
        var cookie = this.$name + "=" + cookieval + ";expires=" + this.$expiration.toGMTString() + ";domain=" + this.$domain;
        window.document.cookie = cookie;
        var cookie = "NETEASE_SSN=" + document.getElementsByName("user")[0].value + ";expires=" + this.$expiration.toGMTString() + ";domain=" + this.$domain;
        window.document.cookie = cookie;
    }
    Cookie.prototype.load = function() {
        var allcookies = this.$document.cookie;
        if (allcookies == "") return false;
        var start = allcookies.indexOf(this.$name + "=");
        if (start == -1) return false;
        start += this.$name.length + 1;
        var end = allcookies.indexOf(";", start);
        if (end == -1) end = allcookies.length;
        var cookieval = allcookies.substring(start, end);
        var a = cookieval.split("&");
        for (var i = 0; i < a.length; i++)
            a[i] = a[i].split(':');
        //�û���:���:��ȫ
        this.data = a;
        return true;
    }
    Cookie.prototype.setVals = function(a, flag) {
        if (this.data == null) {
            if (flag) {
                this.data = [];
                this.data[0] = a;
            }
        }
        else {
            this.data[0][0] = a[0];
            if (flag)
                return;
            else
                this.data = null;
        }
    }


    //*** For Login UserName.
    function fInitUser() {
        var fm = window.document.form;
        var name = "";
        if (visitordata.data != null) {
            name = visitordata.data[0][0];
            //fm.remUser.checked = true;
            fm.autocomplete = "on";
        } else {
            fm.autocomplete = "off";
            //fm.remUser.checked = getCookie("ntes_mail_noremember")!="true";
        }


        if (name != "") {
            fm.user.value = name;
            fm.password.focus();
        } else {
            fm.user.focus();
        }
    }
    function fCheckCookie() {
        var secure = document.getElementsByName("secure");
        var cookieEnabled = (navigator.cookieEnabled) ? true : false;
        if (typeof navigator.cookieEnabled == "undefined" && !cookieEnabled) {
            document.cookie = "testcookie";
            cookieEnabled = (document.cookie == "testcookie") ? true : false;
            document.cookie = "";
        }
        if (secure.length > 0) {
            if (secure[0].checked && !cookieEnabled) {
                window.alert("���ã�������������ý�ֹʹ��cookie������¼����ʱѡ���ˡ���ǿ��ȫ�ԡ�ѡ���ѡ��Ҫ�����������cookie���á�\n\n������ѡ�����µ�����һ��������¼����:\n1:�������������������cookie���ã������µ�¼��\n2:���ߵ�¼ʱȡ��ѡ�С���ǿ��ȫ�ԡ�ѡ��������ĵ�¼��ȫ�Խ��ή�͡�");
                return false;
            }
        }
        return true;
    }
    function fSetLogType() {
        var logType = getCookie("logType");
        var login_select = document.getElementById("login_select");
        if (logType == "dm" || logType == "dm3") {
            login_select.selectedIndex = 1;
        } else if (logType == "js3") {
            login_select.selectedIndex = 2;
        } else if (logType == "jy" || logType == "jy3") {
            login_select.selectedIndex = 3;
        } else {
            login_select.selectedIndex = 0;
        }
    }
    function getCookie(name) {
        var search = name + "="
        if (document.cookie.length > 0) {
            offset = document.cookie.indexOf(search)
            if (offset != -1) {
                offset += search.length
                end = document.cookie.indexOf(";", offset)
                if (end == -1) end = document.cookie.length
                return unescape(document.cookie.substring(offset, end))
            }
            else return ""
        }
    }
    function saveLoginType() {
        var login_select = document.getElementById("login_select");
        var sType = "";
        switch (login_select.selectedIndex) {
            case 0:
                sType = "df";
                break;
            case 1:
                sType = "dm3";
                break;
            case 2:
                sType = "js3";
                break;
            case 3:
                sType = "jy3";
                break;
            default:
                sType = "dm3";
        }
        document.cookie = "logType=" + sType + ";expires=" + (new Date(2099, 12, 31)).toGMTString() + ";domain=126.com";
    }
    var gAppName, gVersion;
    function fVoidIE5() {
        fGetUserAgen();
        if (gAppName == "msie" && gVersion < 6) {
            var obj = document.getElementById("secure");
            obj.checked = false;
            obj.disabled = true;
        }
    }
    function fGetUserAgen() {
        var sUserAgent = window.navigator.userAgent;
        var sAppName = "";
        var sVersion = "";
        if (sUserAgent.indexOf("MSIE") > -1) {
            sAppName = "msie";
            sVersion = sUserAgent.replace(/.+MSIE/gi, "").replace(/;.+/gi, "") - 0;
        } else if (sUserAgent.toUpperCase().indexOf("FIREFOX") > -1) {
            sAppName = "firefox";
            sVersion = sUserAgent.replace(/.+Firefox\//gi, "").replace(/\(.*\)/g, "") - 0;
        } else if (sUserAgent.toUpperCase().indexOf("NETSCAPE") > -1) {
            sAppName = "netscape";
            sVersion = sUserAgent.replace(/.+NETSCAPE\//gi, "").replace(/\(.*\)/g, "") - 0;
        }
        gAppName = sAppName; // ���������
        gVersion = sVersion; // �汾��
    } 
    function $(id) { return document.getElementById(id);}
    


 

 
 
//-->
</SCRIPT>
</head>
<body style=" margin:0px 0px 0px 0px; font-size:12px; font-family:΢���ź�;">
    <form id="form1" runat="server" >
    <div class="page" id="divPage">
	<div class="head">
		<a href="javascript:;" title="�������ű�Ϊ�������ҳ" onClick="this.style.behavior='url(#default#homepage)';this.setHomePage('http://www.ecsms.com.cn');">��Ϊ��ҳ</a> | <a href="http://www.chinamobile.com" target="_blank">�й��ƶ�</a> | <a href="http://www.chinaunicom.com.cn" target="_blank">�й���ͨ</a> | <a href="http://http://www.chinatelecom.com.cn" target="_blank">�й�����</a> | <a href="http://www.ecsms.com.cn" target="_blank">����</a>
	    </div>
	<div class="content">
		<div class="logo">
			<img src="Img/logo.gif" alt="���ű�" width="150" height="46" />
		</div>
		<div class="login">
			<h3>��½</h3> 

				<div class="fi">
					<label class="lb">�û���</label>
					<input id="iptUser" name="user" runat="server" type="text" class="ipt-t no-ime" onfocus="this.className+=' ipt-t-focus'" onblur="this.className='ipt-t no-ime'" tabindex="1" />
			  </div>
			  <div class="fi">
					<label class="lb">�ܡ���</label>
					<input id="iptPwd" type="password" runat="server" class="ipt-t" onfocus="this.className+=' ipt-t-focus'" onblur="this.className='ipt-t no-ime'" name="password" tabindex="2" maxlength="20" />
			    </div>
				<div class="fi">
					<label class="lb">�á���</label>
                    <asp:DropDownList ID="ddlRole" runat="server" TabIndex="4">
                    <asp:ListItem Text="�����û�" Value="2"></asp:ListItem>
                    <asp:ListItem Text="�����û�" Selected="True" Value="3"></asp:ListItem>
                    </asp:DropDownList>
				  
				</div>
            	<div class="fi">
            	<table>
            	<tr>
            	<td><label class="lb">��֤��</label></td>
            	<td><asp:TextBox ID="txtCode" Width="80px" TabIndex="5" class="ipt-t" onfocus="this.className+=' ipt-t-focus'" onblur="this.className='ipt-t no-ime'" runat="server"></asp:TextBox></td>
            	<td>&nbsp;&nbsp;<asp:Image ID="imgValCode" Width="60px" ImageUrl="~/ValeCode.aspx"  runat="server" /><span style=" color:Gray;">�����ִ�Сд</span> 	<label class="ssl" for="secure"></label></td>
            	</tr>
            	</table>                
				
				
		        
		        </div>
				<div class="fi fi-btn">
					<asp:Button Text="�ǡ�¼" TabIndex="6"  
					style=" background-color:#DFEBE1; width:100px; height:30px; text-align:center; font-size:16px; cursor:pointer;" 
                    onclick="btnLogin_Click"  OnClientClick="return checklogin()" runat="server"/>
					
					<span class="err" id="error_div"></span>
                    
				</div>
				<div class="fi fi-nolb">
				<div style=" visibility:hidden;">
				 </div>
				</div>

			<div class="reg">
				<span>��û�����ű��˺ţ�</span>
				<a tabindex="8" class="btn" href="agreement.aspx" id="lnkReg">���ע��</a>
			</div>
		</div>
		<div class="intro" id="divIntro">

			<div class="introtxt introtxt-1">
				<ul>
					<li>��˾�ж�����ţ�һ�������ʻ��������ɹ���</li>
					<li>��CRM���ͻ�����ϵͳ������ͻ���Ա���ɱ�ݣ�</li>
					<li>�ͻ�������Ⱥ����Ϣ���֪ͨ...���ű����ɰ����㶨��</li>
				</ul>
			</div>

			<div class="introtxt introtxt-2"><div id="autoLoginDiv"></div>
				<ul>
					<br>
					<br>
					<li>��ҿͻ������������ȶ�����Ʒ�ʱ��ϣ�</li>
					<li>ȫ�����Ǳ�ݸ�Ч��������ҵ�ƶ���Ϣ����</li>
				</ul>
			</div>

			<div class="introtxt introtxt-3">
				<ul>
                                    <br>
					<li>��˾�ж�����ţ�һ�������ʻ��������ɹ���</li>
					<li>��CRM���ͻ�����ϵͳ������ͻ���Ա���ɱ�ݣ�</li>
					<li>�ͻ�������Ⱥ����Ϣ���֪ͨ...���ű����ɰ����㶨��</li>
				</ul>
			</div>

			<div class="introtxt introtxt-4">
				<ul>
					<br>
					<br>
					<li>��ҿͻ������������ȶ�����Ʒ�ʱ��ϣ�</li>
					<li>ȫ�����Ǳ�ݸ�Ч��������ҵ�ƶ���Ϣ����</li>
				</ul>
			</div>

			<div class="introtxt introtxt-5">
				<ul>
                                        <br>
					<li>��˾�ж�����ţ�һ�������ʻ��������ɹ���</li>
					<li>��CRM���ͻ�����ϵͳ������ͻ���Ա���ɱ�ݣ�</li>
					<li>�ͻ�������Ⱥ����Ϣ���֪ͨ...���ű����ɰ����㶨��</li>
				</ul>
			</div>

			<div class="introtxt introtxt-6">
				<ul>
					<br>
					<br>
					<li>��ҿͻ������������ȶ�����Ʒ�ʱ��ϣ�</li>
					<li>ȫ�����Ǳ�ݸ�Ч��������ҵ�ƶ���Ϣ����</li>
				</ul>
			</div>

			<div class="introtxt introtxt-7">
				<ul>
                                        <br>
					<li>��˾�ж�����ţ�һ�������ʻ��������ɹ���</li>
					<li>��CRM���ͻ�����ϵͳ������ͻ���Ա���ɱ�ݣ�</li>
					<li>�ͻ�������Ⱥ����Ϣ���֪ͨ...���ű����ɰ����㶨��</li>
				</ul>
			</div>
		</div>
  </div>
	<div class="footer">
		<div class="zxdt">
			<h3>�����Ϣ</h3>
			<ul>
				<li><a href="http://www.cmca.org.cn" target="_blank">�й��ƶ�ͨ�����ϻ�</a>
				</li>
				<li><a href="http://www.ec.com.cn" target="_blank">�й����ʵ���������</a>
				</li>
				<li><a href="http://www.12114.org.cn" target="_blank">12114��Ϣ��ַ</a>
				</li>
			</ul>
			<span class="end"></span>
		</div>
		<div class="copyright">
			<div class="inner">
				<div align="center"><span class="footertxt"><a href="javascript:;" title="�������ű�ƽ̨Ϊ�������ҳ" onClick="this.style.behavior='url(#default#homepage)';this.setHomePage('http://www.ecsms.com.cn');">��Ϊ��ҳ</a><a href="http://www.ecsms.com.cn" target="_blank">�������ű�</a><a href="http://www.ecsms.com.cn" target="_blank">�ٷ���վ</a><a href="http://www.ecsms.com.cn" target="_blank">�ٱ�Υ����Ϣ</a><a href="http://www.ecsms.com.cn" target="_blank">�ͻ�����</a><br/>
                      <span>���ű���Ȩ���� &copy; 2010-2012</span></span></div><script src="http://s20.cnzz.com/stat.php?id=3084216&web_id=3084216&show=pic1" language="JavaScript"></script>
			</div>
		</div>
	</div>
</div>
<script type="text/javascript">
    var bgimg = [];
    bgimg[0] = "1"; /* logo1 */
    bgimg[1] = "2"; /* logo2 */
    bgimg[2] = "3"; /* logo3 */
    bgimg[3] = "4"; /* logo4 */
    bgimg[4] = "5"; /* logo5 */
    bgimg[5] = "6"; /* logo6 */
    bgimg[6] = "7"; /* logo7 */

    $("divIntro").className = "intro intro-" + bgimg[Math.floor(bgimg.length * Math.random())];

    window.onresize = function() {
        var minh = 720;
        var minw = 960;
        $("divPage").style.height = document.documentElement.offsetHeight < minh ? minh + "px" : "100%";
        $("divPage").style.width = document.documentElement.offsetWidth < minw ? minw + "px" : "auto";
    }

    window.onresize();

    if ($("iptUser").value == "") {
        $("iptUser").focus();
    } else {
        $("iptPwd").focus();
    }

</script>
    </form>
</body>
 
</html>
