using System;
using System.Collections.Generic;
using AOT;

namespace Mirror.SimpleWeb;

public class WebSocketClientWebGl : SimpleWebClient
{
	private static readonly Dictionary<int, WebSocketClientWebGl> instances;

	private int index;

	private Queue<byte[]> ConnectingSendQueue;

	[MonoPInvokeCallback(typeof(Action<int>))]
	private static void OpenCallback(int index)
	{
	}

	[MonoPInvokeCallback(typeof(Action<int>))]
	private static void CloseCallBack(int index)
	{
	}

	[MonoPInvokeCallback(typeof(Action<int, IntPtr, int>))]
	private static void MessageCallback(int index, IntPtr bufferPtr, int count)
	{
	}

	[MonoPInvokeCallback(typeof(Action<int>))]
	private static void ErrorCallback(int index)
	{
	}

	public bool CheckJsConnected()
	{
		return false;
	}

	internal WebSocketClientWebGl(int maxMessageSize, int maxMessagesPerTick)
		: base(0, 0)
	{
	}

	public override void Connect(Uri serverAddress)
	{
	}

	public override void Disconnect()
	{
	}

	public override void Send(ArraySegment<byte> segment)
	{
	}

	private void onOpen()
	{
	}

	private void onClose()
	{
	}

	private void onMessage(IntPtr bufferPtr, int count)
	{
	}

	private void onErr()
	{
	}
}
