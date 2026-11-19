using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public sealed class DerOtherInfo
{
	public sealed class Builder
	{
		private readonly AlgorithmIdentifier m_algorithmID;

		private readonly Asn1OctetString m_partyUInfo;

		private readonly Asn1OctetString m_partyVInfo;

		private Asn1TaggedObject m_suppPubInfo;

		private Asn1TaggedObject m_suppPrivInfo;

		public Builder(AlgorithmIdentifier algorithmID, byte[] partyUInfo, byte[] partyVInfo)
		{
		}

		public Builder WithSuppPubInfo(byte[] suppPubInfo)
		{
			return null;
		}

		public Builder WithSuppPrivInfo(byte[] suppPrivInfo)
		{
			return null;
		}

		public DerOtherInfo Build()
		{
			return null;
		}
	}

	private readonly DerSequence m_sequence;

	private DerOtherInfo(DerSequence sequence)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
