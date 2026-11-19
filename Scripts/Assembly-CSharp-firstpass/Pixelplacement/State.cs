using System.Collections;
using UnityEngine;

namespace Pixelplacement;

public class State : MonoBehaviour
{
	private StateMachine _stateMachine;

	public bool IsFirst => false;

	public bool IsLast => false;

	public StateMachine StateMachine => null;

	public void ChangeState(int childIndex)
	{
	}

	public void ChangeState(GameObject state)
	{
	}

	public void ChangeState(string state)
	{
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

	protected Coroutine StartCoroutineIfActive(IEnumerator coroutine)
	{
		return null;
	}
}
