using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[ExecuteInEditMode]
public class PostProcessingVolumeTrigger : MonoBehaviour
{
	[Header("Target volume")]
	public PostProcessVolume volume;

	[Space]
	public float decreaseSpeed;

	private float currentWeight;

	private void OnEnable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Trigger()
	{
	}

	private void Update()
	{
	}
}
