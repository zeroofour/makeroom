namespace System.Security.Cryptography.X509Certificates;

public struct X509ChainStatus
{
	private X509ChainStatusFlags status = X509ChainStatusFlags.NoError;

	private string info = null;

	public X509ChainStatusFlags Status
	{
		get
		{
			return X509ChainStatusFlags.NoError;
		}
		set
		{
		}
	}

	public string StatusInformation
	{
		set
		{
		}
	}

	internal X509ChainStatus(X509ChainStatusFlags flag)
	{
	}

	internal static string GetInformation(X509ChainStatusFlags flags)
	{
		return null;
	}
}
