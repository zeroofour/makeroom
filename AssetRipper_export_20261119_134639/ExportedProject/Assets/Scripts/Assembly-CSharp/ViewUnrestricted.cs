using UnityEngine;

public class ViewUnrestricted : MonoBehaviour
{
	[Header("Components")]
	public PlayerInput input;

	public Transform cameraTransform;

	private Vector3 targetPosition;

	private Vector3 targetRotation;

	private Vector3 velocity;

	private float cameraSpeed;

	public void UpdateCamera()
	{
	}

	public void SetInitial()
	{
	}

	private void Movement()
	{
	}

	private void Rotation()
	{
	}

	private void Look(Vector2 _axis, bool _cursor = true)
	{
	}
}
