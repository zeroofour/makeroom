using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class CspParameters
{
	public int ProviderType;

	public string ProviderName;

	public string KeyContainerName;

	public int KeyNumber;

	private int m_flags;

	public CspProviderFlags Flags
	{
		get
		{
			return CspProviderFlags.NoFlags;
		}
		set
		{
		}
	}

	public CspParameters()
	{
	}

	public CspParameters(int dwTypeIn)
	{
	}

	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
	{
	}

	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
	{
	}
}
