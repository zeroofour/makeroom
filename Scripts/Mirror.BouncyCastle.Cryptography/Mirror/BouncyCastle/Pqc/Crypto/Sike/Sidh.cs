namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

internal sealed class Sidh
{
	private readonly SikeEngine engine;

	internal Sidh(SikeEngine engine)
	{
	}

	internal void init_basis(ulong[] gen, ulong[][] XP, ulong[][] XQ, ulong[][] XR)
	{
	}

	internal void EphemeralKeyGeneration_B(byte[] sk, byte[] pk)
	{
	}

	internal void EphemeralKeyGeneration_A(byte[] ephemeralsk, byte[] ct)
	{
	}

	internal void EphemeralSecretAgreement_A(byte[] ephemeralsk, byte[] pk, byte[] jinvariant)
	{
	}

	internal void EphemeralSecretAgreement_B(byte[] sk, byte[] ct, byte[] jinvariant_)
	{
	}
}
