using Mirror.BouncyCastle.Asn1.Mozilla;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Mozilla;

public sealed class SignedPublicKeyAndChallenge
{
	private readonly Mirror.BouncyCastle.Asn1.Mozilla.SignedPublicKeyAndChallenge m_spkac;

	public SignedPublicKeyAndChallenge(byte[] encoding)
	{
	}

	public SignedPublicKeyAndChallenge(Mirror.BouncyCastle.Asn1.Mozilla.SignedPublicKeyAndChallenge spkac)
	{
	}

	public AsymmetricKeyParameter GetPublicKey()
	{
		return null;
	}

	public bool IsSignatureValid(AsymmetricKeyParameter publicKey)
	{
		return false;
	}

	public bool IsSignatureValid(IVerifierFactoryProvider verifierProvider)
	{
		return false;
	}

	public Mirror.BouncyCastle.Asn1.Mozilla.SignedPublicKeyAndChallenge ToAsn1Structure()
	{
		return null;
	}

	public void Verify(AsymmetricKeyParameter publicKey)
	{
	}

	public void Verify(IVerifierFactoryProvider verifierProvider)
	{
	}

	private void CheckSignature(IVerifierFactory verifier)
	{
	}

	private bool CheckSignatureValid(IVerifierFactory verifier)
	{
		return false;
	}
}
