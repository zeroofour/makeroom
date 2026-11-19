using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerInput : MonoBehaviour
{
	private InputDefinition inputDefinition;

	private InputDevice inputDevice;

	private string inputMap;

	private bool active;

	private static float nextRepeatTime;

	private static float initialDelay;

	private static float repeatRate;

	public static PlayerInput instance { get; private set; }

	private void Awake()
	{
	}

	public InputDevice GetDevice()
	{
		return null;
	}

	public void SetDevice(InputDevice _device)
	{
	}

	public void SetDevices(InputDevice[] _devices)
	{
	}

	public void SetKeyboardMouse()
	{
	}

	public void SetGamepad(int _index = 0)
	{
	}

	public void SetAllDevices()
	{
	}

	public InputDevice GetGamepad()
	{
		return null;
	}

	public ReadOnlyArray<InputDevice>? GetDevices()
	{
		return null;
	}

	public void ResetButton(string _action)
	{
	}

	public bool GetButton(string _action)
	{
		return false;
	}

	public bool GetButtonDown(string _action)
	{
		return false;
	}

	public bool GetButtonUp(string _action)
	{
		return false;
	}

	public bool GetButtonRepeat(string _action)
	{
		return false;
	}

	public float GetAxis(string _action)
	{
		return 0f;
	}

	public Vector2 GetVectorAxis(string _action)
	{
		return default;
	}

	public Vector3 GetVector3Axis(string _action)
	{
		return default;
	}

	public string GenerateAction(string _action)
	{
		return null;
	}

	public void SetActionMap(string _name)
	{
	}

	public void Activate()
	{
	}
}
