using System.Net;
using UnityEngine;

namespace Mirror.Discovery;

[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Discovery")]
public class NetworkDiscovery : NetworkDiscoveryBase<ServerRequest, ServerResponse>
{
	protected override ServerResponse ProcessRequest(ServerRequest request, IPEndPoint endpoint)
	{
		return default;
	}

	protected override ServerRequest GetRequest()
	{
		return default;
	}

	protected override void ProcessResponse(ServerResponse response, IPEndPoint endpoint)
	{
	}
}
