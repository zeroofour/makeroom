namespace System.Security.Cryptography;

public struct ECParameters
{
	public ECPoint Q;

	public byte[] D;

	public ECCurve Curve;
}
