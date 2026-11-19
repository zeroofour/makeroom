namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal class Signature2
{
	internal class Proof2
	{
		internal byte[] seedInfo;

		internal int seedInfoLen;

		internal byte[] aux;

		internal byte[] C;

		internal byte[] input;

		internal byte[] msgs;

		internal Proof2(PicnicEngine engine)
		{
		}
	}

	internal byte[] salt;

	internal byte[] iSeedInfo;

	internal int iSeedInfoLen;

	internal byte[] cvInfo;

	internal int cvInfoLen;

	internal byte[] challengeHash;

	internal uint[] challengeC;

	internal uint[] challengeP;

	internal Proof2[] proofs;

	internal Signature2(PicnicEngine engine)
	{
	}
}
