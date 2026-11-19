using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public abstract class ThreadedTransport : Transport
{
	private WorkerThread thread;

	private readonly ConcurrentQueue<ClientMainEvent> clientMainQueue;

	private readonly ConcurrentQueue<ServerMainEvent> serverMainQueue;

	private readonly ConcurrentQueue<ThreadEvent> threadQueue;

	private bool serverActive;

	private bool clientConnected;

	private const int MaxProcessingPerTick = 10000000;

	[Tooltip("Detect device sleep mode and automatically disconnect + hibernate the thread after 'sleepTimeout' seconds.\nFor example: on mobile / VR, we don't want to drain the battery after putting down the device.")]
	public bool sleepDetection;

	public float sleepTimeoutInSeconds;

	private Stopwatch sleepTimer;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnqueueClientMain(ClientMainEventType type, object param, int? channelId, TransportError? error)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnqueueServerMain(ServerMainEventType type, object param, int? connectionId, int? channelId, TransportError? error)
	{
	}

	private void EnqueueThread(ThreadEventType type, object param, int? channelId, int? connectionId)
	{
	}

	protected virtual void Awake()
	{
	}

	private void EnsureThread()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void ProcessThreadQueue()
	{
	}

	private bool ThreadTick()
	{
		return false;
	}

	protected void OnThreadedClientConnected()
	{
	}

	protected void OnThreadedClientSend(ArraySegment<byte> message, int channelId)
	{
	}

	protected void OnThreadedClientReceive(ArraySegment<byte> message, int channelId)
	{
	}

	protected void OnThreadedClientError(TransportError error, string reason)
	{
	}

	protected void OnThreadedClientDisconnected()
	{
	}

	protected void OnThreadedServerConnected(int connectionId, IPEndPoint endPoint)
	{
	}

	protected void OnThreadedServerSend(int connectionId, ArraySegment<byte> message, int channelId)
	{
	}

	protected void OnThreadedServerReceive(int connectionId, ArraySegment<byte> message, int channelId)
	{
	}

	protected void OnThreadedServerError(int connectionId, TransportError error, string reason)
	{
	}

	protected void OnThreadedServerDisconnected(int connectionId)
	{
	}

	protected abstract void ThreadedClientConnect(string address);

	protected abstract void ThreadedClientConnect(Uri address);

	protected abstract void ThreadedClientSend(ArraySegment<byte> message, int channelId);

	protected abstract void ThreadedClientDisconnect();

	protected abstract void ThreadedServerStart();

	protected abstract void ThreadedServerStop();

	protected abstract void ThreadedServerSend(int connectionId, ArraySegment<byte> message, int channelId);

	protected abstract void ThreadedServerDisconnect(int connectionId);

	protected abstract void ThreadedClientEarlyUpdate();

	protected abstract void ThreadedClientLateUpdate();

	protected abstract void ThreadedServerEarlyUpdate();

	protected abstract void ThreadedServerLateUpdate();

	protected abstract void ThreadedShutdown();

	public override void ClientEarlyUpdate()
	{
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	public override void ClientDisconnect()
	{
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void ServerLateUpdate()
	{
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override void ServerStart()
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId = 0)
	{
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override void ServerStop()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public override void Shutdown()
	{
	}
}
