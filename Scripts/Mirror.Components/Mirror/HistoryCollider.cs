using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[AddComponentMenu("Network/ Lag Compensation/ History Collider")]
public class HistoryCollider : MonoBehaviour
{
	[Tooltip("The object's actual collider. We need to know where it is, and how large it is.")]
	[Header("Components")]
	public Collider actualCollider;

	[Tooltip("The helper collider that the history bounds are projected onto.\nNeeds to be added to a child GameObject to counter-rotate an axis aligned Bounding Box onto it.\nThis is only used by this component.")]
	public BoxCollider boundsCollider;

	[Header("History")]
	[Tooltip("Keep this many past bounds in the buffer. The larger this is, the further we can raycast into the past.\nMaximum time := historyAmount * captureInterval")]
	public int boundsLimit;

	[Tooltip("Gather N bounds at a time into a bucket for faster encapsulation. A factor of 2 will be twice as fast, etc.")]
	public int boundsPerBucket;

	[Tooltip("Capture bounds every 'captureInterval' seconds. Larger values will require fewer computations, but may not capture every small move.")]
	public float captureInterval;

	private double lastCaptureTime;

	[Header("Debug")]
	public Color historyColor;

	public Color currentColor;

	protected HistoryBounds history;

	protected virtual void Awake()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void CaptureBounds()
	{
	}

	protected virtual void ProjectBounds()
	{
	}

	protected virtual void OnDrawGizmos()
	{
	}
}
