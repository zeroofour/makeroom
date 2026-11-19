using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Chat;

public class LoginUI : MonoBehaviour
{
	[SerializeField]
	[Header("UI Elements")]
	internal InputField networkAddressInput;

	[SerializeField]
	internal InputField usernameInput;

	[SerializeField]
	internal Button hostButton;

	[SerializeField]
	internal Button clientButton;

	[SerializeField]
	internal Text errorText;

	public static LoginUI instance;

	private string originalNetworkAddress;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleButtons(string username)
	{
	}
}
