using UnityEngine;

public class TransitionCircle : MonoBehaviour
{
	public Material material;

	public Canvas canvas;

	private GameObject target;

	public static TransitionCircle instance { get; private set; }

	public bool IsTransitioning { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ResetTarget()
	{
	}

	public void TransitionIn(float _time = 0.75f, GameObject _target = null)
	{
	}

	public void TransitionOut(float _time = 1f)
	{
	}
}
