using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

public class PlayerGUI : MonoBehaviour
{
	public Text playerName;

	[ClientCallback]
	public void SetPlayerInfo(PlayerInfo info)
	{
	}
}
