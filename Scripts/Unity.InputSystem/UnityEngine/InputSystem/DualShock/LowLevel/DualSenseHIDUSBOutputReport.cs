using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout((LayoutKind)2, Pack = 1, Size = 56)]
internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo
{
	internal const int kSize = 56;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte reportId;

	[FieldOffset(9)]
	public DualSenseHIDOutputReportPayload payload;

	public static FourCC Type => default;

	public FourCC typeStatic => default;

	public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload)
	{
		return default;
	}
}
