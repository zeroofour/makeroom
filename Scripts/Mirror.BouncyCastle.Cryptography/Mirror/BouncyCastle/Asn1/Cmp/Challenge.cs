using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class Challenge : Asn1Encodable
{
	public class Rand : Asn1Encodable
	{
		private readonly DerInteger m_intVal;

		private readonly GeneralName m_sender;

		public virtual DerInteger IntVal => null;

		public virtual GeneralName Sender => null;

		public static Rand GetInstance(object obj)
		{
			return null;
		}

		public static Rand GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
		{
			return null;
		}

		public Rand(DerInteger intVal, GeneralName sender)
		{
		}

		public Rand(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}

	private readonly AlgorithmIdentifier m_owf;

	private readonly Asn1OctetString m_witness;

	private readonly Asn1OctetString m_challenge;

	public virtual AlgorithmIdentifier Owf => null;

	public virtual Asn1OctetString Witness => null;

	public virtual Asn1OctetString ChallengeValue => null;

	public static Challenge GetInstance(object obj)
	{
		return null;
	}

	public static Challenge GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private Challenge(Asn1Sequence seq)
	{
	}

	public Challenge(byte[] witness, byte[] challenge)
	{
	}

	public Challenge(AlgorithmIdentifier owf, byte[] witness, byte[] challenge)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
