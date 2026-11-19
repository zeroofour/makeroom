using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
	public static EventManager instance;

	public UnityEvent hintEvent;

	private void Awake()
	{
	}
}
