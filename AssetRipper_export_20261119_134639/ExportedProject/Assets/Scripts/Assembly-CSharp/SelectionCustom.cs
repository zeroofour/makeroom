using UnityEngine;

public class SelectionCustom : MonoBehaviour
{
	public class Bounds
	{
		public Vector3 position;

		public Vector3 size;

		public Bounds(Vector3 _position, Vector3 _size)
		{
		}
	}

	public GameObject[] gameObjects;

	public Vector3 position;

	public Vector3 size;

	private bool customSize;

	public bool GetCustomSize()
	{
		return false;
	}

	public void Set(GameObject[] _gameObjects)
	{
	}

	public void Set(Bounds _bounds)
	{
	}
}
