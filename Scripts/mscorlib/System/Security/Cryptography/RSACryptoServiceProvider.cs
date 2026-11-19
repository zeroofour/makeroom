using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class RSACryptoServiceProvider : RSA
{
	private static CspProviderFlags s_UseMachineKeyStore;

	private KeyPairPersistence store;

	private bool persistKey;

	private bool persisted;

	private bool privateKeyExportable;

	private bool m_disposed;

	private RSAManaged rsa;

	public static bool UseMachineKeyStore => false;

	public override int KeySize => 0;

	[ComVisible(false)]
	public bool PublicOnly => false;

	public RSACryptoServiceProvider()
	{
	}

	public RSACryptoServiceProvider(CspParameters parameters)
	{
	}

	public RSACryptoServiceProvider(int dwKeySize)
	{
	}

	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
	{
	}

	private void Common(int dwKeySize, bool parameters)
	{
	}

	private void Common(CspParameters p)
	{
	}

	~RSACryptoServiceProvider()
	{
	}

	public override byte[] EncryptValue(byte[] rgb)
	{
		return null;
	}

	public override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		return default;
	}

	public override void ImportParameters(RSAParameters parameters)
	{
	}

	private string GetHashNameFromOID(string oid)
	{
		return null;
	}

	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void OnKeyGenerated(object sender, EventArgs e)
	{
	}
}
