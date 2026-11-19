using System;
using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[AddComponentMenu("Network/ Interest Management/ Match/Network Match")]
[DisallowMultipleComponent]
public class NetworkMatch : NetworkBehaviour
{
	private Guid _matchId;

	[SerializeField]
	[Tooltip("Match ID is shown here on server for debugging purposes.")]
	[ReadOnly]
	private string MatchID;

	public Guid matchId
	{
		get
		{
			return default;
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
