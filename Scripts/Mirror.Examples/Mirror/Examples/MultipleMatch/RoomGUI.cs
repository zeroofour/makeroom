using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

public class RoomGUI : MonoBehaviour
{
	public GameObject playerList;

	public GameObject playerPrefab;

	public GameObject cancelButton;

	public GameObject leaveButton;

	public Button startButton;

	public bool owner;

	[ClientCallback]
	public void RefreshRoomPlayers(PlayerInfo[] playerInfos)
	{
	}

	[ClientCallback]
	public void SetOwner(bool owner)
	{
	}
}
