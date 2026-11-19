using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks;

public class SteamScreenshots : SteamClientClass<SteamScreenshots>
{
	[CompilerGenerated]
	private static Action m_OnScreenshotRequested;

	[CompilerGenerated]
	private static Action<Screenshot> m_OnScreenshotReady;

	[CompilerGenerated]
	private static Action<Result> m_OnScreenshotFailed;

	internal static ISteamScreenshots Internal => null;

	public static bool Hooked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static event Action OnScreenshotRequested
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

	public static event Action<Screenshot> OnScreenshotReady
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

	public static event Action<Result> OnScreenshotFailed
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

	internal override bool InitializeInterface(bool server)
	{
		return false;
	}

	internal static void InstallEvents()
	{
	}

	public static Screenshot? WriteScreenshot(byte[] data, int width, int height)
	{
		return null;
	}

	public static Screenshot? AddScreenshot(string filename, string thumbnail, int width, int height)
	{
		return null;
	}

	public static void TriggerScreenshot()
	{
	}
}
