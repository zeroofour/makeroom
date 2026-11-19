using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.TopDownShooter;

public class CanvasHUD : MonoBehaviour
{
	public CanvasTopDown canvasTopDown;

	[SerializeField]
	private GameObject startButtonsGroup;

	[SerializeField]
	private GameObject statusLabelsGroup;

	[SerializeField]
	private Button startHostButton;

	[SerializeField]
	private Button startServerOnlyButton;

	[SerializeField]
	private Button startClientButton;

	[SerializeField]
	private Button mainStopButton;

	[SerializeField]
	private Text statusText;

	[SerializeField]
	private InputField inputNetworkAddress;

	[SerializeField]
	private InputField inputPort;

	private void Start()
	{
	}

	private void RegisterListeners()
	{
	}

	private void CheckWebGLPlayer()
	{
	}

	private void RefreshHUD()
	{
	}

	private void StartButtons()
	{
	}

	private void StatusLabelsAndStopButtons()
	{
	}

	private void ShowConnectingStatus()
	{
	}

	private void OnClickStartHostButton()
	{
	}

	private void OnClickStartServerButton()
	{
	}

	private void OnClickStartClientButton()
	{
	}

	private void OnClickMainStopButton()
	{
	}

	private void OnNetworkAddressChange()
	{
	}

	private void OnPortChange()
	{
	}

	private void SetPort(string _port)
	{
	}

	private void GetPort()
	{
	}

	private void Update()
	{
	}

	private void Reset()
	{
	}
}
