using Edgegap;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.EdgegapLobby;

public class UILobbyEntry : MonoBehaviour
{
	public Button JoinButton;

	public Text Name;

	public Text PlayerCount;

	private LobbyBrief _lobby;

	private UILobbyList _list;

	private void Awake()
	{
	}

	public void Init(UILobbyList list, LobbyBrief lobby, bool active = true)
	{
	}
}
