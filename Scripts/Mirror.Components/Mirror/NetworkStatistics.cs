using System;
using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-statistics")]
[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Statistics")]
public class NetworkStatistics : MonoBehaviour
{
	private double intervalStartTime;

	[HideInInspector]
	public int clientIntervalReceivedPackets;

	[HideInInspector]
	public long clientIntervalReceivedBytes;

	[HideInInspector]
	public int clientIntervalSentPackets;

	[HideInInspector]
	public long clientIntervalSentBytes;

	[HideInInspector]
	public int clientReceivedPacketsPerSecond;

	[HideInInspector]
	public long clientReceivedBytesPerSecond;

	[HideInInspector]
	public int clientSentPacketsPerSecond;

	[HideInInspector]
	public long clientSentBytesPerSecond;

	[HideInInspector]
	public int serverIntervalReceivedPackets;

	[HideInInspector]
	public long serverIntervalReceivedBytes;

	[HideInInspector]
	public int serverIntervalSentPackets;

	[HideInInspector]
	public long serverIntervalSentBytes;

	[HideInInspector]
	public int serverReceivedPacketsPerSecond;

	[HideInInspector]
	public long serverReceivedBytesPerSecond;

	[HideInInspector]
	public int serverSentPacketsPerSecond;

	[HideInInspector]
	public long serverSentBytesPerSecond;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClientReceive(ArraySegment<byte> data, int channelId)
	{
	}

	private void OnClientSend(ArraySegment<byte> data, int channelId)
	{
	}

	private void OnServerReceive(int connectionId, ArraySegment<byte> data, int channelId)
	{
	}

	private void OnServerSend(int connectionId, ArraySegment<byte> data, int channelId)
	{
	}

	private void Update()
	{
	}

	private void UpdateClient()
	{
	}

	private void UpdateServer()
	{
	}

	private void OnGUI()
	{
	}

	private void OnClientGUI()
	{
	}

	private void OnServerGUI()
	{
	}
}
