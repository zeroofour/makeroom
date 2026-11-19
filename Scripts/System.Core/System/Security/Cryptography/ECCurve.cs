using System.Diagnostics;

namespace System.Security.Cryptography;

[DebuggerDisplay("ECCurve: {Oid}")]
public struct ECCurve
{
	public enum ECCurveType
	{
		Implicit = 0,
		PrimeShortWeierstrass = 1,
		PrimeTwistedEdwards = 2,
		PrimeMontgomery = 3,
		Characteristic2 = 4,
		Named = 5
	}

	public byte[] A;

	public byte[] B;

	public ECPoint G;

	public byte[] Order;

	public byte[] Cofactor;

	public byte[] Seed;

	public ECCurveType CurveType;

	public HashAlgorithmName? Hash;

	public byte[] Polynomial;

	public byte[] Prime;

	private Oid _oid;

	public Oid Oid => null;

	public bool IsNamed => false;
}
