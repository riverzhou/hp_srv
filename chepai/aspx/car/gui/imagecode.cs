using System;
using System.Web;

public partial class imagecode: System.Web.UI.Page
{
	public void Imagecode()
	{
		string sid = Session.SessionID.ToString();
		string req = Request.QueryString.ToString();

		Console.WriteLine(sid);
		Console.WriteLine(req);

		string ack = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<XML><ERRORCODE>0</ERRORCODE><ERRORSTRING>正确！</ERRORSTRING><ERRORSTRING_EN>OK！</ERRORSTRING_EN><IMAGE_CONTENT>/zZ/u00GIaP9HW010G000G01003/sm1302WS7YCU6IWZ8ICjAoWmF6H1F3StF7jONKbaaO2Pbe+0Z8gWjER3eAhQhOgCoF/Bskxr////cy7////w/+Rz//Z/sm130IijBJmrF7P1GNRufOob+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZu+FZ/m00H200X07430I800X410n41/yG07m000GK10G410G400000000000420mG51WS82GeB/yG0jH000W430m840mK510G0005z0G8300GH1H8XCK464r5X1o9n53A1aQ488qAnmHLIqV0aCs9oWWaA5XSO6Heb9YSeAIeqDJOtE3awGqH5HaT8IKfJL5LMLrXPMcDaPMPdQ6bgStHrTdTuUNg3X8M6XuY9YfAJb9MMbvYPcgAZfAMcfwYfghApjBMsjxYvkiB3nCN6nyZ9ojBJrDNMrzZPsk7Yu+JbvkVewUhnylFqzVRt+Fdw/yG07m400m410G410G410G00000000420mG51WS82GeB/yG0jH400W4210G310S510G00G9t00420n441I4n1X91KGTXSHCYCe4854AHeR712ICpKl0LOdBH2XOaDE4byHSO6Hec9oWfAZKsDpWvEaD4HKP7I4bAKrHLLbTOMLfZP6LcPsXfQdDqTNPtU7bwWeE4XOQ7Y8cAafEKbPQNc9cQegEafQQdgAcgihEqjRQtkBcwmiF4nSR7oCdAqjFKrTRNsDdQukFavURdwEdgylFqzVRt+Fdw/ze030C1008H0n40Fm2tQsjkq5kMWY9CG99GSd0fyqDd2ocI680v07bWvEHZ0npIsxh7QMxiSAi6IVR0gd9D8JzhmnUHIjj5Z9NfytJhrFqxr9FScaDX6mPxSAW1oJRa3gFQdgbX9Tc58eMT5Eu2CSTFQehxpPTCHIZjAyOo0fpdAay3fL7HsycyS5bmo49axGvpWO/Mc7Sr8ex6TWqCKBBWvmWwy7qzwIHDFZc2kjif0EGGezAew56mdbTJ+w8AWdWaWZ/7zQkMt/8OlFy0TN+Gf0oH8BALmOue7N1oLK4PufkooCk1ReTkGSGvvuzgXjYGbwGS4IIu8/2dwN/g/m0M/m3PQJUjYMzR4XYi/CN/04PSOFy0omFjxKgGMafHaWYAbJ/op7gAaWQPc1dGAs3W3qugjPJnf34kIp1Mo4KiHpt0wKN2x/hv5WsbjvgZxF5ZQVu1xL6qTa9zdsUCbHym4MSTCT1KiDn3SkhGo1njESTHoErKjBRDm+vlcOTpoQ6zR6qOtZANQnOCLdvY/m2ZBZ1/vO7szgL8REMGR88Y1a4UM1pnxKzPoPtynFBL0G6OyDoAPPWxsV7okpilkEEQBYSR9/8vUYYYh4RLyaicbsYnAx4ekGe9umF/0Ar8kfosiKIoMJg4JO2n8pqzlQj6p/uzxN/hYFv2cQXP/RH77lsOosSP/m0zQadk9SNPZirkbGPCUuAJqoL/nhBqFQRnrV13HaOFVaSLUYqnqcZMMwUQ83/Li3WunWTVf+LJhfzl7TYM9IZ5MnjF0Fg1+FqzgOzYXfPaNLhXGcL9OFy0DdRpwdhLos/v35v/kh/8LPXWYjoiSA1Lmnn+LG26UBKPfaMDXAem2v6C03qD9YP5QW5RmCTeCikJZEEbHsTkye9ZdT1aumFfx+zMOBMH1CaXK6PdRvJd6SVIcBOIHi5IvPSWdWOzFUfQr8ajIPHza0ysLf2SuprFJWLHihR+pPsckfer38S3FFK4/ZzCrSM8shDBDAqsn6OPwZ7N7DHMbr5gRdpBTSnWyDXXpZ/2gHIqAkdHJIQgrm4T8cBFymnk1wVNgAiM6oQxaSngl6L070gcYcprmHM+xOM0Av9u8v/BDNbqvut0IvPIGUGCVrfIkRmQKMcxR5b8MMuSl8P5S72de1dfJBFXtN98LtLSdE0CSL6RERU1ziapWyy+tlLY64G5L1B4XYp7kUEQGfjMUjzZawAAAq82YYYW0eeee0AAAA02YYYW0eeee0AAAA02YYYW0eeee0//sG</IMAGE_CONTENT><IMAGE_HINT>请输入右侧图像中的数字。</IMAGE_HINT></XML>";

		//Response.Write(sid);
		//Response.Write("<br/>");
		//Response.Write(req);

		Response.Write(ack);
	}
}

