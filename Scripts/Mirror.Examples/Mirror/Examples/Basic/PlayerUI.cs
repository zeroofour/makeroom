using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Basic;

public class PlayerUI : MonoBehaviour
{
	[Header("Player Components")]
	public Image image;

	[Header("Child Text Objects")]
	public Text playerNameText;

	public Text playerDataText;

	public void SetLocalPlayer()
	{
	}

	public void OnPlayerNumberChanged(byte newPlayerNumber)
	{
	}

	public void OnPlayerColorChanged(Color32 newPlayerColor)
	{
	}

	public void OnPlayerDataChanged(ushort newPlayerData)
	{
	}
}
