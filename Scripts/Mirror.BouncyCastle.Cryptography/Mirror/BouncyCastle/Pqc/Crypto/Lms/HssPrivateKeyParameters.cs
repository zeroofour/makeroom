using System;
using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public class HssPrivateKeyParameters : LmsKeyParameters, ILmsContextBasedSigner
{
	private readonly int m_level;

	private readonly bool m_isShard;

	private IList<LmsPrivateKeyParameters> m_keys;

	private IList<LmsSignature> m_sig;

	private readonly long m_indexLimit;

	private long m_index;

	private HssPublicKeyParameters m_publicKey;

	[Obsolete("Use 'Level' instead")]
	public int L => 0;

	public int Level => 0;

	public long IndexLimit => 0L;

	public HssPrivateKeyParameters(int l, IList<LmsPrivateKeyParameters> keys, IList<LmsSignature> sig, long index, long indexLimit)
		: base(isPrivateKey: false)
	{
	}

	private HssPrivateKeyParameters(int l, IList<LmsPrivateKeyParameters> keys, IList<LmsSignature> sig, long index, long indexLimit, bool isShard)
		: base(isPrivateKey: false)
	{
	}

	public static HssPrivateKeyParameters GetInstance(byte[] privEnc, byte[] pubEnc)
	{
		return null;
	}

	public static HssPrivateKeyParameters GetInstance(object src)
	{
		return null;
	}

	internal static HssPrivateKeyParameters Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public long GetIndex()
	{
		return 0L;
	}

	public LmsParameters[] GetLmsParameters()
	{
		return null;
	}

	internal void IncIndex()
	{
	}

	private static HssPrivateKeyParameters MakeCopy(HssPrivateKeyParameters privateKeyParameters)
	{
		return null;
	}

	protected void UpdateHierarchy(IList<LmsPrivateKeyParameters> newKeys, IList<LmsSignature> newSig)
	{
	}

	public bool IsShard()
	{
		return false;
	}

	public long GetUsagesRemaining()
	{
		return 0L;
	}

	internal LmsPrivateKeyParameters GetRootKey()
	{
		return null;
	}

	public HssPrivateKeyParameters ExtractKeyShard(int usageCount)
	{
		return null;
	}

	public IList<LmsPrivateKeyParameters> GetKeys()
	{
		return null;
	}

	internal IList<LmsSignature> GetSig()
	{
		return null;
	}

	private void ResetKeyToIndex()
	{
	}

	public HssPublicKeyParameters GetPublicKey()
	{
		return null;
	}

	internal void ReplaceConsumedKey(int d)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	protected object Clone()
	{
		return null;
	}

	public LmsContext GenerateLmsContext()
	{
		return null;
	}

	public byte[] GenerateSignature(LmsContext context)
	{
		return null;
	}

	private static bool CompareLists<T>(IList<T> arr1, IList<T> arr2)
	{
		return false;
	}
}
