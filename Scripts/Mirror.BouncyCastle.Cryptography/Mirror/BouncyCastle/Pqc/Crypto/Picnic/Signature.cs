namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal class Signature
{
	internal class Proof
	{
		internal readonly byte[] seed1;

		internal readonly byte[] seed2;

		internal readonly uint[] inputShare;

		internal readonly byte[] communicatedBits;

		internal readonly byte[] view3Commitment;

		internal readonly byte[] view3UnruhG;

		internal Proof(PicnicEngine engine)
		{
		}
	}

	internal readonly byte[] challengeBits;

	internal readonly byte[] salt;

	internal readonly Proof[] proofs;

	internal Signature(PicnicEngine engine)
	{
	}
}
