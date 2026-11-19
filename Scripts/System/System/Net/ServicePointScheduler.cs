using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Net;

internal class ServicePointScheduler
{
	private class ConnectionGroup
	{
		private readonly ServicePointScheduler Scheduler;

		private readonly string Name;

		private static int nextId;

		public readonly int ID;

		private LinkedList<WebConnection> connections;

		private LinkedList<WebOperation> queue;

		public ConnectionGroup(ServicePointScheduler scheduler, string name)
		{
		}
	}

	private class AsyncManualResetEvent
	{
		private TaskCompletionSource<bool> m_tcs;

		public void Set()
		{
		}

		public AsyncManualResetEvent(bool state)
		{
		}
	}

	private int maxIdleTime;

	private AsyncManualResetEvent schedulerEvent;

	private ConnectionGroup defaultGroup;

	private LinkedList<(ConnectionGroup, WebOperation)> operations;

	private LinkedList<(ConnectionGroup, WebConnection, Task)> idleConnections;

	private int connectionLimit;

	private DateTime idleSince;

	private static int nextId;

	public readonly int ID;

	private ServicePoint ServicePoint { set; }

	public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
	{
	}
}
