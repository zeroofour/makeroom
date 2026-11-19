using System;
using UnityEngine;
using kcp2k;

namespace Edgegap;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/edgegap-transports/edgegap-relay")]
public class EdgegapKcpTransport : KcpTransport
{
	[Header("Relay")]
	public string relayAddress;

	public ushort relayGameServerPort;

	public ushort relayGameClientPort;

	public const int MaxPayload = 1187;

	[Header("Relay")]
	public bool relayGUI;

	public uint userId;

	public uint sessionId;

	internal static string ReParse(string cmd, string pattern, string defaultValue)
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnValidate()
	{
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override void ServerStart()
	{
	}

	private void OnGUIRelay()
	{
	}

	private void OnGUI()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
