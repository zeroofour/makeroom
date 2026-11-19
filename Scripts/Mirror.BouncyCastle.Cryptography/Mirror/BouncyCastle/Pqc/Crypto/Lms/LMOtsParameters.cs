using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LMOtsParameters
{
	public static LMOtsParameters sha256_n32_w1;

	public static LMOtsParameters sha256_n32_w2;

	public static LMOtsParameters sha256_n32_w4;

	public static LMOtsParameters sha256_n32_w8;

	public static LMOtsParameters sha256_n24_w1;

	public static LMOtsParameters sha256_n24_w2;

	public static LMOtsParameters sha256_n24_w4;

	public static LMOtsParameters sha256_n24_w8;

	public static LMOtsParameters shake256_n32_w1;

	public static LMOtsParameters shake256_n32_w2;

	public static LMOtsParameters shake256_n32_w4;

	public static LMOtsParameters shake256_n32_w8;

	public static LMOtsParameters shake256_n24_w1;

	public static LMOtsParameters shake256_n24_w2;

	public static LMOtsParameters shake256_n24_w4;

	public static LMOtsParameters shake256_n24_w8;

	private static Dictionary<int, LMOtsParameters> ParametersByID;

	private readonly int m_id;

	private readonly int m_n;

	private readonly int m_w;

	private readonly int m_p;

	private readonly int m_ls;

	private readonly uint m_sigLen;

	private readonly DerObjectIdentifier m_digestOid;

	public int ID => 0;

	public int N => 0;

	public int W => 0;

	public int P => 0;

	public int Ls => 0;

	public int SigLen => 0;

	public DerObjectIdentifier DigestOid => null;

	public static LMOtsParameters GetParametersByID(int id)
	{
		return null;
	}

	internal static LMOtsParameters ParseByID(BinaryReader binaryReader)
	{
		return null;
	}

	internal LMOtsParameters(int id, int n, int w, int p, int ls, uint sigLen, DerObjectIdentifier digestOid)
	{
	}
}
