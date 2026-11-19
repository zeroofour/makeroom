using System;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LMOtsPrivateKey
{
	private readonly LMOtsParameters m_parameters;

	private readonly byte[] m_I;

	private readonly int m_q;

	private readonly byte[] m_masterSecret;

	public LMOtsParameters Parameters => null;

	public int Q => 0;

	[Obsolete("Use 'GetI' instead")]
	public byte[] I => null;

	[Obsolete("Use 'GetMasterSecret' instead")]
	public byte[] MasterSecret => null;

	public LMOtsPrivateKey(LMOtsParameters parameters, byte[] i, int q, byte[] masterSecret)
	{
	}

	public LmsContext GetSignatureContext(LMSigParameters sigParams, byte[][] path)
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

	internal SeedDerive GetDerivationFunction()
	{
		return null;
	}
}
