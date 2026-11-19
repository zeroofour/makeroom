using System;
using System.Diagnostics;
using System.Threading;

namespace Mirror;

public class WorkerThread
{
	private readonly Thread thread;

	protected bool active;

	private readonly Stopwatch watch;

	public Action Init;

	public Func<bool> Tick;

	public Action Cleanup;

	public bool IsAlive => false;

	public WorkerThread(string identifier)
	{
	}

	public void Start()
	{
	}

	public virtual void SignalStop()
	{
	}

	public bool StopBlocking(float timeout)
	{
		return false;
	}

	public void Interrupt()
	{
	}

	private void OnInit()
	{
	}

	private bool OnTick()
	{
		return false;
	}

	private void OnCleanup()
	{
	}

	public void Guard(string identifier)
	{
	}
}
