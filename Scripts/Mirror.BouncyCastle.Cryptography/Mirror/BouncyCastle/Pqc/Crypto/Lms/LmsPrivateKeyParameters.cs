using System;
using System.Collections.Concurrent;
using System.IO;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsPrivateKeyParameters : LmsKeyParameters, ILmsContextBasedSigner
{
	private byte[] I;

	private LMSigParameters sigParameters;

	private LMOtsParameters otsParameters;

	private int maxQ;

	private byte[] masterSecret;

	private ConcurrentDictionary<int, byte[]> tCache;

	private int maxCacheR;

	private IDigest tDigest;

	private int q;

	private readonly bool m_isPlaceholder;

	private LmsPublicKeyParameters m_publicKey;

	public LMSigParameters SigParameters => null;

	public LMOtsParameters OtsParameters => null;

	private static LmsPublicKeyParameters DerivePublicKey(LmsPrivateKeyParameters privateKey)
	{
		return null;
	}

	public LmsPrivateKeyParameters(LMSigParameters lmsParameter, LMOtsParameters otsParameters, int q, byte[] I, int maxQ, byte[] masterSecret)
		: base(isPrivateKey: false)
	{
	}

	internal LmsPrivateKeyParameters(LMSigParameters lmsParameter, LMOtsParameters otsParameters, int q, byte[] I, int maxQ, byte[] masterSecret, bool isPlaceholder)
		: base(isPrivateKey: false)
	{
	}

	private LmsPrivateKeyParameters(LmsPrivateKeyParameters parent, int q, int maxQ)
		: base(isPrivateKey: false)
	{
	}

	public static LmsPrivateKeyParameters GetInstance(byte[] privEnc, byte[] pubEnc)
	{
		return null;
	}

	public static LmsPrivateKeyParameters GetInstance(object src)
	{
		return null;
	}

	internal static LmsPrivateKeyParameters Parse(BinaryReader binaryReader)
	{
		return null;
	}

	internal LMOtsPrivateKey GetCurrentOtsKey()
	{
		return null;
	}

	public int GetIndex()
	{
		return 0;
	}

	internal void IncIndex()
	{
	}

	public LmsContext GenerateLmsContext()
	{
		return null;
	}

	public byte[] GenerateSignature(LmsContext context)
	{
		return null;
	}

	internal LMOtsPrivateKey GetNextOtsPrivateKey()
	{
		return null;
	}

	public LmsPrivateKeyParameters ExtractKeyShard(int usageCount)
	{
		return null;
	}

	[Obsolete("Use 'SigParameters' instead")]
	public LMSigParameters GetSigParameters()
	{
		return null;
	}

	[Obsolete("Use 'OtsParameters' instead")]
	public LMOtsParameters GetOtsParameters()
	{
		return null;
	}

	public byte[] GetI()
	{
		return null;
	}

	public byte[] GetMasterSecret()
	{
		return null;
	}

	public long GetUsagesRemaining()
	{
		return 0L;
	}

	public LmsPublicKeyParameters GetPublicKey()
	{
		return null;
	}

	internal byte[] FindT(int r)
	{
		return null;
	}

	private byte[] CalcT(int r)
	{
		return null;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override byte[] GetEncoded()
	{
		return null;
	}
}
