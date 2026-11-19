using Steamworks.Data;

namespace Steamworks;

public struct Controller
{
	internal InputHandle_t Handle = default;

	public ulong Id => 0uL;

	public InputType InputType => InputType.Unknown;

	public string ActionSet
	{
		set
		{
		}
	}

	internal Controller(InputHandle_t inputHandle_t)
	{
	}

	public void DeactivateLayer(string layer)
	{
	}

	public void ActivateLayer(string layer)
	{
	}

	public void ClearLayers()
	{
	}

	public DigitalState GetDigitalState(string actionName)
	{
		return default;
	}

	public AnalogState GetAnalogState(string actionName)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(Controller a, Controller b)
	{
		return false;
	}

	public static bool operator !=(Controller a, Controller b)
	{
		return false;
	}

	public override bool Equals(object p)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(Controller p)
	{
		return false;
	}
}
