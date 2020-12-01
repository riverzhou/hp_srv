using System;
using System.Web;

public partial class login: System.Web.UI.Page
{
	public void Login()
	{
		string sid = Session.SessionID.ToString();
		string req = Request.QueryString.ToString();

		Console.WriteLine(sid);
		Console.WriteLine(req);

		string ack = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n<XML><CLIENTNAME>张海翔</CLIENTNAME><PID>320502197603153054</PID></XML>";

		//Response.Write(sid);
		//Response.Write("<br/>");
		//Response.Write(req);

		Response.Write(ack);
	}
}

