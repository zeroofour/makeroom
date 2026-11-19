using System;
using Mirror.BouncyCastle.Asn1.Tsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tsp;

public class TimeStampTokenInfo
{
	private TstInfo tstInfo;

	private DateTime genTime;

	public bool IsOrdered => false;

	public Accuracy Accuracy => null;

	public DateTime GenTime => default;

	public GenTimeAccuracy GenTimeAccuracy => null;

	public string Policy => null;

	public BigInteger SerialNumber => null;

	public GeneralName Tsa => null;

	public BigInteger Nonce => null;

	public AlgorithmIdentifier HashAlgorithm => null;

	public string MessageImprintAlgOid => null;

	public TstInfo TstInfo => null;

	private static TstInfo ParseTstInfo(byte[] tstInfoEncoding)
	{
		return null;
	}

	public TimeStampTokenInfo(byte[] tstInfoEncoding)
	{
	}

	public TimeStampTokenInfo(TstInfo tstInfo)
	{
	}

	public byte[] GetMessageImprintDigest()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
