using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[DisallowMultipleComponent]
public abstract class InterestManagementBase : MonoBehaviour
{
	protected virtual void OnEnable()
	{
	}

	[ServerCallback]
	public virtual void ResetState()
	{
	}

	public abstract bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver);

	[ServerCallback]
	public virtual void SetHostVisibility(NetworkIdentity identity, bool visible)
	{
	}

	[ServerCallback]
	public virtual void OnSpawned(NetworkIdentity identity)
	{
	}

	[ServerCallback]
	public virtual void OnDestroyed(NetworkIdentity identity)
	{
	}

	public abstract void Rebuild(NetworkIdentity identity, bool initialize);

	protected void AddObserver(NetworkConnectionToClient connection, NetworkIdentity identity)
	{
	}

	protected void RemoveObserver(NetworkConnectionToClient connection, NetworkIdentity identity)
	{
	}
}
