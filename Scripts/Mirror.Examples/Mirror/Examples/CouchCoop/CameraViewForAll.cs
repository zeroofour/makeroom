using UnityEngine;

namespace Mirror.Examples.CouchCoop;

public class CameraViewForAll : MonoBehaviour
{
	public Transform cameraTransform;

	public float camSpeed;

	public float orthoSizeSpeed;

	public Camera mainCamera;

	public float cameraZ;

	public float cameraBufferX;

	public float cameraBufferY;

	public float minOrthographicSize;

	public float targetYPosition;

	private Vector2Int boundsMin;

	private Vector2Int boundsMax;

	private Vector3 targetCameraPosition;

	private float targetOrthographicSize;

	private void Update()
	{
	}

	private void CalculateBounds()
	{
	}

	private void CalculateTargetCameraPosAndSize()
	{
	}

	private void MoveCamera()
	{
	}
}
