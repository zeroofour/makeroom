using System.Security;

namespace System.Net;

public class NetworkCredential : ICredentials
{
	private string m_domain;

	private string m_userName;

	private SecureString m_password;

	public string UserName
	{
		set
		{
		}
	}

	public string Password
	{
		set
		{
		}
	}

	public string Domain
	{
		set
		{
		}
	}

	public NetworkCredential(string userName, string password, string domain)
	{
	}
}
