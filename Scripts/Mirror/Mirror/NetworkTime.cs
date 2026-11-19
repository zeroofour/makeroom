using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public static class NetworkTime
{
	private const float DefaultPingInterval = 0.1f;

	public static float PingInterval;

	public const int PingWindowSize = 50;

	private static double lastPingTime;

	private static ExponentialMovingAverage _rtt;

	private static int PredictionErrorWindowSize;

	private static ExponentialMovingAverage _predictionErrorUnadjusted;

	public static double localTime
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0.0;
		}
	}

	public static double time
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0.0;
		}
	}

	public static double predictionErrorUnadjusted => 0.0;

	public static double predictionErrorAdjusted { get; private set; }

	public static double predictedTime
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0.0;
		}
	}

	public static double offset => 0.0;

	public static double rtt => 0.0;

	public static double rttVariance => 0.0;

	[RuntimeInitializeOnLoadMethod]
	public static void ResetStatics()
	{
	}

	internal static void UpdateClient()
	{
	}

	internal static void SendPing()
	{
	}

	internal static void OnServerPing(NetworkConnectionToClient conn, NetworkPingMessage message)
	{
	}

	internal static void OnClientPong(NetworkPongMessage message)
	{
	}

	internal static void OnClientPing(NetworkPingMessage message)
	{
	}

	internal static void OnServerPong(NetworkConnectionToClient conn, NetworkPongMessage message)
	{
	}

	internal static void EarlyUpdate()
	{
	}
}
