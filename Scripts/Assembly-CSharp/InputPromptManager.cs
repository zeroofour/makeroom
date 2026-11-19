using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputPromptManager : MonoBehaviour
{
	[CompilerGenerated]
	private Action<InputDeviceType> m_OnDeviceChanged;

	[Header("Properties")]
	public InputPromptCollection collection;

	public InputDeviceType overrideDevice;

	public static InputPromptManager instance { get; private set; }

	public InputDeviceType deviceType { get; private set; }

	public event Action<InputDeviceType> OnDeviceChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void SetDevice(InputDeviceType _device)
	{
	}

	public void SetOverrideDevice(InputDeviceType _device)
	{
	}

	public void ResetOverrideDevice()
	{
	}

	public void UpdateAllPromptSprites(InputDeviceType _device)
	{
	}
}
