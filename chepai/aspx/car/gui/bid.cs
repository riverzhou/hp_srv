using System;
using System.Web;

public partial class bid: System.Web.UI.Page
{
	public void Bid()
	{
		string sid = Session.SessionID.ToString();
		string req = Request.QueryString.ToString();

		Console.WriteLine(sid);
		Console.WriteLine(req);

		string ack = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<XML><CLIENTNAME>张海翔</CLIENTNAME><PID>320502197603153054</PID><BIDNUMBER>52740378</BIDNUMBER><BIDCOUNT>1</BIDCOUNT><BIDAMOUNT>75200</BIDAMOUNT><BIDTIME>2015-04-18 10:34:09</BIDTIME><BIDTYPE>网络</BIDTYPE></XML>\r\n";

		//Response.Write(sid);
		//Response.Write("<br/>");
		//Response.Write(req);

		Response.Write(ack);
	}
}

