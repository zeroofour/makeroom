using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
public class MultiplexTransport : Transport, PortTransport
{
	public Transport[] transports;

	private Transport available;

	private readonly Dictionary<KeyValuePair<int, int>, int> originalToMultiplexedId;

	private readonly Dictionary<int, KeyValuePair<int, int>> multiplexedToOriginalId;

	private int nextMultiplexedId;

	private bool alreadyWarned;

	public ushort Port
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AddToLookup(int originalConnectionId, int transportIndex)
	{
		return 0;
	}

	public void RemoveFromLookup(int originalConnectionId, int transportIndex)
	{
	}

	public bool OriginalId(int multiplexId, out int originalConnectionId, out int transportIndex)
	{
		originalConnectionId = default;
		transportIndex = default;
		return false;
	}

	public int MultiplexId(int originalConnectionId, int transportIndex)
	{
		return 0;
	}

	public void Awake()
	{
	}

	public override void ClientEarlyUpdate()
	{
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void ClientLateUpdate()
	{
	}

	public override void ServerLateUpdate()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override bool Available()
	{
		return false;
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientDisconnect()
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	private void AddServerCallbacks()
	{
	}

	public override Uri ServerUri()
	{
		return null;
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ServerStart()
	{
	}

	public override void ServerStop()
	{
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override void Shutdown()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
