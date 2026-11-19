using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[AddComponentMenu("Network/ Interest Management/ Distance/Distance Custom Range")]
[DisallowMultipleComponent]
public class DistanceInterestManagementCustomRange : NetworkBehaviour
{
	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange;

	public override bool Weaved()
	{
		return false;
	}
}
