using UnityEngine;

namespace Pixelplacement;

[RequireComponent(typeof(Initialization))]
public class DisplayObject : MonoBehaviour
{
	private bool _activated;

	public bool ActiveSelf
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Register()
	{
	}

	public void SetActive(bool value)
	{
	}

	public void Solo()
	{
	}

	public void HideAll()
	{
	}
}
