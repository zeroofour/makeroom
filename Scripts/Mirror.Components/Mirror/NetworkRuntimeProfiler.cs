using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Mirror;

public class NetworkRuntimeProfiler : MonoBehaviour
{
	[Serializable]
	public class Sorter : IComparer<Stat>
	{
		public SortBy Order;

		public int Compare(Stat a, Stat b)
		{
			return 0;
		}
	}

	public enum SortBy
	{
		RecentBytes = 0,
		RecentCount = 1,
		TotalBytes = 2,
		TotalCount = 3
	}

	public class Stat
	{
		public string Name;

		public long TotalCount;

		public long TotalBytes;

		public long RecentCount;

		public long RecentBytes;

		public void ResetRecent()
		{
		}

		public void Add(int count, int bytes)
		{
		}
	}

	private class MessageStats
	{
		public readonly Dictionary<Type, Stat> MessageByType;

		public readonly Dictionary<ushort, Stat> RpcByHash;

		public void Record(NetworkDiagnostics.MessageInfo info)
		{
		}

		private void RecordRpc(ushort hash, NetworkDiagnostics.MessageInfo info)
		{
		}

		public void ResetRecent()
		{
		}
	}

	public enum OutputType
	{
		UnityLog = 0,
		StdOut = 1,
		File = 2
	}

	[Tooltip("How many seconds to accumulate 'recent' stats for, this is also the output interval")]
	public float RecentDuration;

	public Sorter Sort;

	public OutputType Output;

	[Tooltip("If Output is set to 'File', where to the path of that file")]
	public string OutputFilePath;

	private readonly MessageStats inStats;

	private readonly MessageStats outStats;

	private readonly StringBuilder printBuilder;

	private float elapsedSinceReset;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void HandleMessageOut(NetworkDiagnostics.MessageInfo info)
	{
	}

	private void HandleMessageIn(NetworkDiagnostics.MessageInfo info)
	{
	}

	private void LateUpdate()
	{
	}

	private void Print()
	{
	}

	private static string FormatBytes(long bytes)
	{
		return null;
	}

	private string FormatCount(long count)
	{
		return null;
	}
}
