using UnityEngine;

namespace Mirror;

public class RemoteStatistics : NetworkBehaviour
{
	protected NetworkStatistics NetworkStatistics;

	[Tooltip("Send stats every 'interval' seconds to client.")]
	public float sendInterval;

	private double lastSendTime;

	[Header("GUI")]
	public bool showGui;

	public KeyCode hotKey;

	private Rect windowRect;

	[Header("Authentication")]
	public string passwordFile;

	protected bool serverAuthenticated;

	protected bool clientAuthenticated;

	protected string serverPassword;

	protected string clientPassword;

	private Stats stats;

	private void LoadPassword()
	{
	}

	protected override void OnValidate()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	[TargetRpc]
	private void TargetRpcSync(Stats v)
	{
	}

	[Command]
	public void CmdAuthenticate(string v)
	{
	}

	private void UpdateServer()
	{
	}

	private void UpdateClient()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void GUILayout_TextAndValue(string text, string value)
	{
	}

	private void GUILayout_ProgressBar(double ratio, int width)
	{
	}

	private void GUILayout_TextAndProgressBar(string text, double ratio, int progressbarWidth, string caption, int captionWidth, Color captionColor)
	{
	}

	private void GUI_Authenticate()
	{
	}

	private void GUI_General(int connections, double uptime, int configuredTickRate, int actualTickRate)
	{
	}

	private void GUI_Traffic(long serverSentBytesPerSecond, long serverReceivedBytesPerSecond)
	{
	}

	private void GUI_Cpu(float serverTickInterval, double fullUpdateAvg, double serverEarlyAvg, double serverLateAvg, double transportEarlyAvg, double transportLateAvg)
	{
	}

	private void GUI_Notice()
	{
	}

	private void OnWindow(int windowID)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_TargetRpcSync__Stats(Stats v)
	{
	}

	protected static void InvokeUserCode_TargetRpcSync__Stats(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdAuthenticate__String(string v)
	{
	}

	protected static void InvokeUserCode_CmdAuthenticate__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static RemoteStatistics()
	{
	}
}
