using System;

namespace Mono.Security.Interface;

public class MonoTlsConnectionInfo
{
	[CLSCompliant(false)]
	public CipherSuiteCode CipherSuiteCode { get; set; }

	public TlsProtocols ProtocolVersion { get; set; }

	public string PeerDomainName { set; }

	public override string ToString()
	{
		return null;
	}
}
