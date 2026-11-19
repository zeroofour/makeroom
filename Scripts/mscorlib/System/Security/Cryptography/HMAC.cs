using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class HMAC : KeyedHashAlgorithm
{
	private int blockSizeValue;

	internal string m_hashName;

	internal HashAlgorithm m_hash1;

	internal HashAlgorithm m_hash2;

	private byte[] m_inner;

	private byte[] m_outer;

	private bool m_hashing;

	protected int BlockSizeValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override byte[] Key
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void UpdateIOPadBuffers()
	{
	}

	internal void InitializeKey(byte[] key)
	{
	}

	public static HMAC Create()
	{
		return null;
	}

	public override void Initialize()
	{
	}

	protected override void HashCore(byte[] rgb, int ib, int cb)
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
