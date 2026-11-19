using Edgegap;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.EdgegapLobby;

public class UILobbyCreate : MonoBehaviour
{
	public UILobbyList List;

	public Button CancelButton;

	public InputField LobbyName;

	public Text SlotCount;

	public Slider SlotSlider;

	public Button HostButton;

	public Button ServerButton;

	private EdgegapLobbyKcpTransport _transport => null;

	private void Awake()
	{
	}

	private void ValidateName()
	{
	}
}
