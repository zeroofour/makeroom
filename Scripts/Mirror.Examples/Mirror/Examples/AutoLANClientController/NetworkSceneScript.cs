using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.AutoLANClientController;

public class NetworkSceneScript : NetworkBehaviour
{
	public Button clientButton;

	public Text textResult;

	public GameObject panelClient;

	public GameObject panelServer;

	private void Start()
	{
	}

	private void ClientButton()
	{
	}

	[Command(requiresAuthority = false)]
	public void CmdSendText(string _value)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdSendText__String(string _value)
	{
	}

	protected static void InvokeUserCode_CmdSendText__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkSceneScript()
	{
	}
}
