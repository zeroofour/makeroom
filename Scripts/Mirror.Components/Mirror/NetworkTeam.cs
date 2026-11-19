using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[AddComponentMenu("Network/ Interest Management/ Team/Network Team")]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
public class NetworkTeam : NetworkBehaviour
{
	[SerializeField]
	[Tooltip("Set teamId on Server at runtime to the same value on all networked objects that belong to a given team")]
	private string _teamId;

	[Tooltip("When enabled this object is visible to all clients. Typically this would be true for player objects")]
	public bool forceShown;

	public string teamId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool Weaved()
	{
		return false;
	}
}
