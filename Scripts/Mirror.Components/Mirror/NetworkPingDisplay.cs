using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-ping-display")]
[AddComponentMenu("Network/Network Ping Display")]
public class NetworkPingDisplay : MonoBehaviour
{
	public Color color;

	public int padding;

	public int width;

	public int height;

	private void OnGUI()
	{
	}
}
