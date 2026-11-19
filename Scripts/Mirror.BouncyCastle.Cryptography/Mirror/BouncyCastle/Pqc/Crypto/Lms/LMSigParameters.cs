using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LMSigParameters
{
	public static LMSigParameters lms_sha256_n32_h5;

	public static LMSigParameters lms_sha256_n32_h10;

	public static LMSigParameters lms_sha256_n32_h15;

	public static LMSigParameters lms_sha256_n32_h20;

	public static LMSigParameters lms_sha256_n32_h25;

	public static LMSigParameters lms_sha256_n24_h5;

	public static LMSigParameters lms_sha256_n24_h10;

	public static LMSigParameters lms_sha256_n24_h15;

	public static LMSigParameters lms_sha256_n24_h20;

	public static LMSigParameters lms_sha256_n24_h25;

	public static LMSigParameters lms_shake256_n32_h5;

	public static LMSigParameters lms_shake256_n32_h10;

	public static LMSigParameters lms_shake256_n32_h15;

	public static LMSigParameters lms_shake256_n32_h20;

	public static LMSigParameters lms_shake256_n32_h25;

	public static LMSigParameters lms_shake256_n24_h5;

	public static LMSigParameters lms_shake256_n24_h10;

	public static LMSigParameters lms_shake256_n24_h15;

	public static LMSigParameters lms_shake256_n24_h20;

	public static LMSigParameters lms_shake256_n24_h25;

	private static Dictionary<int, LMSigParameters> ParametersByID;

	private readonly int m_id;

	private readonly int m_m;

	private readonly int m_h;

	private readonly DerObjectIdentifier m_digestOid;

	public DerObjectIdentifier DigestOid => null;

	public int H => 0;

	public int ID => 0;

	public int M => 0;

	public static LMSigParameters GetParametersByID(int id)
	{
		return null;
	}

	internal static LMSigParameters ParseByID(BinaryReader binaryReader)
	{
		return null;
	}

	internal LMSigParameters(int id, int m, int h, DerObjectIdentifier digestOid)
	{
	}
}
