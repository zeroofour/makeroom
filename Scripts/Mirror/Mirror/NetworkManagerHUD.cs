using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Manager HUD")]
[RequireComponent(typeof(NetworkManager))]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-manager-hud")]
public class NetworkManagerHUD : MonoBehaviour
{
	private NetworkManager manager;

	public int offsetX;

	public int offsetY;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void StartButtons()
	{
	}

	private void StatusLabels()
	{
	}

	private void StopButtons()
	{
	}
}
