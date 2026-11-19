using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/Network Diagnostics Debugger")]
public class NetworkDiagnosticsDebugger : MonoBehaviour
{
	public bool logInMessages;

	public bool logOutMessages;

	private void OnInMessage(NetworkDiagnostics.MessageInfo msgInfo)
	{
	}

	private void OnOutMessage(NetworkDiagnostics.MessageInfo msgInfo)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
