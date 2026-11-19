using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class SignatureDescription
{
	private string _strKey;

	private string _strDigest;

	private string _strFormatter;

	private string _strDeformatter;

	public string KeyAlgorithm
	{
		set
		{
		}
	}

	public string DigestAlgorithm
	{
		set
		{
		}
	}

	public string FormatterAlgorithm
	{
		set
		{
		}
	}

	public string DeformatterAlgorithm
	{
		set
		{
		}
	}
}
