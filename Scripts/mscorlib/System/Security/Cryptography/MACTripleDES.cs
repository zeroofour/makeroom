using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class MACTripleDES : KeyedHashAlgorithm
{
	private ICryptoTransform m_encryptor;

	private CryptoStream _cs;

	private TailStream _ts;

	private int m_bytesPerBlock;

	private TripleDES des;

	public override void Initialize()
	{
	}

	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
	{
	}

	protected override byte[] HashFinal()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
