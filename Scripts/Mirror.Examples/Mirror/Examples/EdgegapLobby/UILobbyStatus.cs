using Edgegap;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.EdgegapLobby;

public class UILobbyStatus : MonoBehaviour
{
	private enum Status
	{
		Offline = 0,
		Server = 1,
		Host = 2,
		Client = 3
	}

	public GameObject[] ShowDisconnected;

	public GameObject[] ShowServer;

	public GameObject[] ShowHost;

	public GameObject[] ShowClient;

	public Button StopServer;

	public Button StopHost;

	public Button StopClient;

	public Text StatusText;

	private Status _status;

	private EdgegapLobbyKcpTransport _transport;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Refresh()
	{
	}

	private void SetUI(GameObject[] gos, bool active)
	{
	}

	private Status GetStatus()
	{
		return Status.Offline;
	}
}
