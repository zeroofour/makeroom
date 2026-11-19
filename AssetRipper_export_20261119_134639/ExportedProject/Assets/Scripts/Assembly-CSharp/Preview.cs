using UnityEngine;

public class Preview : MonoBehaviour
{
	public Transform container;

	public CanvasGroup canvasGroup;

	[Header("Types")]
	public GameObject typeObject;

	[Header("Rendering")]
	public Camera previewCamera;

	private Vector3 velocity;

	private GameObject target;

	public static Preview instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Show(GameObject _object)
	{
	}

	public void Show(GameObject _object, LibraryObject _model)
	{
	}

	public void Hide()
	{
	}

	public void UpdatePosition(bool _instant = false)
	{
	}
}
