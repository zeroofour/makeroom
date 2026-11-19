using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class DSACryptoServiceProvider : DSA
{
	private KeyPairPersistence store;

	private bool persistKey;

	private bool persisted;

	private bool privateKeyExportable;

	private bool m_disposed;

	private DSAManaged dsa;

	private static bool useMachineKeyStore;

	public override int KeySize => 0;

	[ComVisible(false)]
	public bool PublicOnly => false;

	public DSACryptoServiceProvider()
	{
	}

	public DSACryptoServiceProvider(int dwKeySize)
	{
	}

	private void Common(int dwKeySize, bool parameters)
	{
	}

	~DSACryptoServiceProvider()
	{
	}

	public override DSAParameters ExportParameters(bool includePrivateParameters)
	{
		return default;
	}

	public override void ImportParameters(DSAParameters parameters)
	{
	}

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
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
