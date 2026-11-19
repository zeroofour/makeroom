using System.Collections.Generic;
using Edgegap;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.EdgegapLobby;

public class UILobbyList : MonoBehaviour
{
	public UILobbyCreate Create;

	public GameObject EntryPrefab;

	public Transform LobbyContent;

	public GameObject Loading;

	public Button RefreshButton;

	public InputField SearchInput;

	public Button CreateButton;

	public Text Error;

	private List<UILobbyEntry> _entries;

	private EdgegapLobbyKcpTransport _transport => null;

	private void Awake()
	{
	}

	public void Start()
	{
	}

	private void Refresh()
	{
	}

	public void Join(LobbyBrief lobby)
	{
	}

	public void SetLobbies(LobbyBrief[] lobbies)
	{
	}
}
