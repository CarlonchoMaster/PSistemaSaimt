﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultarEspaciosXNivel.aspx.vb" Inherits="PresentacionWeb.ConsultarEspaciosXNivel" %>

<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
.button, .button:visited { /* botones genéricos */
  background: #222 url(../images/overlay.png) repeat-x;
  display: inline-block;
  padding: 5px 10px 6px;
  color: #FFF;
  text-decoration: none;
  -moz-border-radius: 6px;
  -webkit-border-radius: 6px;
  -moz-box-shadow: 0 1px 3px rgba(0,0,0,0.6);
  -webkit-box-shadow: 0 1px 3px rgba(0,0,0,0.6);
  text-shadow: 0 -1px 1px rgba(0,0,0,0.25);
  border-bottom: 1px solid rgba(0,0,0,0.25);
  position: relative;
  cursor:pointer
}
.button:hover { /* el efecto hover */
  background-color: #111
  color: #FFF;
}
.button:active{  /* el efecto click */
  top: 1px;
}

 /* botones pequeños */
.small.button, .small.button:visited {
  font-size: 11px ;
}

 /* botones medianos */
.button, .button:visited,.medium.button, .medium.button:visited {
  font-size: 13px;
  font-weight: bold;
  line-height: 1;
  text-shadow: 0 -1px 1px rgba(0,0,0,0.25);
}

 /* botones grandes */
.large.button, .large.button:visited {
  font-size:14px;
  padding: 8px 14px 9px;
}

 /* botones extra grandes */
.super.button, .super.button:visited {
  font-size: 34px;
  padding: 8px 14px 9px;
}
   
   .pink.button { background-color: #E22092; }
.pink.button:hover{ background-color: #C81E82; }

.green.button, .green.button:visited { background-color: #91BD09; }
.green.button:hover{ background-color: #749A02; }

.red.button, .red.button:visited { background-color: #E62727; }
.red.button:hover{ background-color: #CF2525; }

.orange.button, .orange.button:visited { background-color: #FF5C00; }
.orange.button:hover{ background-color: #D45500; }

.blue.button, .blue.button:visited { background-color: #2981E4; }
.blue.button:hover{ background-color: #2575CF; }

.yellow.button, .yellow.button:visited { background-color: #FFB515; }
.yellow.button:hover{ background-color: #FC9200; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
