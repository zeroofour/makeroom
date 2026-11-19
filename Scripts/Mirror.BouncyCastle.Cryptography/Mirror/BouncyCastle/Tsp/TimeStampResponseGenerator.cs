using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tsp;

public class TimeStampResponseGenerator
{
	private class FailInfo : DerBitString
	{
		internal FailInfo(int failInfoValue)
			: base(0, 0)
		{
		}
	}

	private PkiStatus status;

	private Asn1EncodableVector statusStrings;

	private int failInfo;

	private TimeStampTokenGenerator tokenGenerator;

	private IList<string> acceptedAlgorithms;

	private IList<string> acceptedPolicies;

	private IList<string> acceptedExtensions;

	public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList<string> acceptedAlgorithms)
	{
	}

	public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList<string> acceptedAlgorithms, IList<string> acceptedPolicy)
	{
	}

	public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList<string> acceptedAlgorithms, IList<string> acceptedPolicies, IList<string> acceptedExtensions)
	{
	}

	private void AddStatusString(string statusString)
	{
	}

	private void SetFailInfoField(int field)
	{
	}

	private PkiStatusInfo GetPkiStatusInfo()
	{
		return null;
	}

	public TimeStampResponse Generate(TimeStampRequest request, BigInteger serialNumber, DateTime? genTime)
	{
		return null;
	}

	public TimeStampResponse GenerateGrantedResponse(TimeStampRequest request, BigInteger serialNumber, DateTime? genTime, string statusString, X509Extensions additionalExtensions)
	{
		return null;
	}

	public TimeStampResponse GenerateFailResponse(PkiStatus status, int failInfoField, string statusString)
	{
		return null;
	}
}
