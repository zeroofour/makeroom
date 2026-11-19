using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Tls;

public sealed class OcspStatusRequest
{
	private readonly IList<ResponderID> m_responderIDList;

	private readonly X509Extensions m_requestExtensions;

	public IList<ResponderID> ResponderIDList => null;

	public X509Extensions RequestExtensions => null;

	public OcspStatusRequest(IList<ResponderID> responderIDList, X509Extensions requestExtensions)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static OcspStatusRequest Parse(Stream input)
	{
		return null;
	}
}
