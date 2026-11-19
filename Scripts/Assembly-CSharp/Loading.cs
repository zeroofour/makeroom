using UnityEngine;

public class Loading : MonoBehaviour
{
	[HideInInspector]
	public string scene;

	private AsyncOperation async;

	private CanvasGroup canvasGroup;

	public static void LoadScene(string _scene)
	{
	}

	private void Awake()
	{
	}

	private void StartLoading()
	{
	}

	private void SceneLoaded(AsyncOperation asyncOperation)
	{
	}
}
