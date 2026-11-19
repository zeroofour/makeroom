using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Mirror.BouncyCastle.Utilities.IO;

public static class Streams
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCopyToAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int bufferSize;

		public Stream destination;

		public CancellationToken cancellationToken;

		public Stream source;

		private byte[] _003Cbuffer_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteAsyncCompletion_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task writeTask;

		public byte[] localBuffer;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static readonly int MaxStackAlloc;

	public static int DefaultBufferSize => 0;

	public static void CopyTo(Stream source, Stream destination)
	{
	}

	public static void CopyTo(Stream source, Stream destination, int bufferSize)
	{
	}

	public static Task CopyToAsync(Stream source, Stream destination)
	{
		return null;
	}

	public static Task CopyToAsync(Stream source, Stream destination, int bufferSize)
	{
		return null;
	}

	public static Task CopyToAsync(Stream source, Stream destination, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCopyToAsync_003Ed__8))]
	public static Task CopyToAsync(Stream source, Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	public static void Drain(Stream inStr)
	{
	}

	public static void PipeAll(Stream inStr, Stream outStr)
	{
	}

	public static void PipeAll(Stream inStr, Stream outStr, int bufferSize)
	{
	}

	public static long PipeAllLimited(Stream inStr, long limit, Stream outStr)
	{
		return 0L;
	}

	public static long PipeAllLimited(Stream inStr, long limit, Stream outStr, int bufferSize)
	{
		return 0L;
	}

	public static byte[] ReadAll(Stream inStr)
	{
		return null;
	}

	public static byte[] ReadAll(MemoryStream inStr)
	{
		return null;
	}

	public static byte[] ReadAllLimited(Stream inStr, int limit)
	{
		return null;
	}

	public static int ReadFully(Stream inStr, byte[] buf)
	{
		return 0;
	}

	public static int ReadFully(Stream inStr, byte[] buf, int off, int len)
	{
		return 0;
	}

	public static void ValidateBufferArguments(byte[] buffer, int offset, int count)
	{
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncCompletion_003Ed__20))]
	internal static Task WriteAsyncCompletion(Task writeTask, byte[] localBuffer)
	{
		return null;
	}

	internal static Task WriteAsyncDirect(Stream destination, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public static int WriteBufTo(MemoryStream buf, byte[] output, int offset)
	{
		return 0;
	}
}
