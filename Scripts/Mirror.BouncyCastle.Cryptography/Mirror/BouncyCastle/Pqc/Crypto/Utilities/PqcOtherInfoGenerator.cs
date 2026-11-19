using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Utilities;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Utilities;

public abstract class PqcOtherInfoGenerator
{
	public sealed class PartyU : PqcOtherInfoGenerator
	{
		private AsymmetricCipherKeyPair m_aKp;

		private IEncapsulatedSecretExtractor m_encSE;

		public PartyU(IKemParameters kemParams, AlgorithmIdentifier algorithmID, byte[] partyUInfo, byte[] partyVInfo, SecureRandom random)
			: base(null, null, null, null)
		{
		}

		public PqcOtherInfoGenerator WithSuppPubInfo(byte[] suppPubInfo)
		{
			return null;
		}

		public byte[] GetSuppPrivInfoPartA()
		{
			return null;
		}

		public DerOtherInfo Generate(byte[] suppPrivInfoPartB)
		{
			return null;
		}
	}

	public sealed class PartyV : PqcOtherInfoGenerator
	{
		private IEncapsulatedSecretGenerator m_encSG;

		public PartyV(IKemParameters kemParams, AlgorithmIdentifier algorithmID, byte[] partyUInfo, byte[] partyVInfo, SecureRandom random)
			: base(null, null, null, null)
		{
		}

		public PqcOtherInfoGenerator WithSuppPubInfo(byte[] suppPubInfo)
		{
			return null;
		}

		public byte[] GetSuppPrivInfoPartB(byte[] suppPrivInfoPartA)
		{
			return null;
		}

		public DerOtherInfo Generate()
		{
			return null;
		}
	}

	protected readonly DerOtherInfo.Builder m_otherInfoBuilder;

	protected readonly SecureRandom m_random;

	protected bool m_used;

	internal PqcOtherInfoGenerator(AlgorithmIdentifier algorithmID, byte[] partyUInfo, byte[] partyVInfo, SecureRandom random)
	{
	}

	private static byte[] GetEncoded(AsymmetricKeyParameter pubKey)
	{
		return null;
	}

	private static AsymmetricKeyParameter GetPublicKey(byte[] enc)
	{
		return null;
	}
}
