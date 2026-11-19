using System.Net;
using Mirror.Discovery;
using UnityEngine;

namespace Mirror.Examples.AutoLANClientController;

[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Discovery")]
public class AutoLANNetworkDiscovery : NetworkDiscoveryBase<ServerRequest, ServerResponse>
{
	public CanvasHUD canvasHUD;

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
