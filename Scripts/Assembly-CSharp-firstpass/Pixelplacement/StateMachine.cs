using UnityEngine;
using UnityEngine.Events;

namespace Pixelplacement;

[RequireComponent(typeof(Initialization))]
public class StateMachine : MonoBehaviour
{
	public GameObject defaultState;

	public GameObject currentState;

	public bool _unityEventsFolded;

	[Tooltip("Should log messages be thrown during usage?")]
	public bool verbose;

	[Tooltip("Can States within this StateMachine be reentered?")]
	public bool allowReentry;

	[Tooltip("Return to default state on disable?")]
	public bool returnToDefaultOnDisable;

	public GameObjectEvent OnStateExited;

	public GameObjectEvent OnStateEntered;

	public UnityEvent OnFirstStateEntered;

	public UnityEvent OnFirstStateExited;

	public UnityEvent OnLastStateEntered;

	public UnityEvent OnLastStateExited;

	private bool _initialized;

	private bool _atFirst;

	private bool _atLast;

	public bool CleanSetup { get; private set; }

	public bool AtFirst
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool AtLast
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public GameObject Next(bool exitIfLast = false)
	{
		return null;
	}

	public GameObject Previous(bool exitIfFirst = false)
	{
		return null;
	}

	public void Exit()
	{
	}

	public GameObject ChangeState(int childIndex)
	{
		return null;
	}

	public GameObject ChangeState(GameObject state)
	{
		return null;
	}

	public GameObject ChangeState(string state)
	{
		return null;
	}

	public void Initialize()
	{
	}

	public void StartMachine()
	{
	}

	private void Enter(GameObject state)
	{
	}

	private void Log(string message)
	{
	}
}
