using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Ugc;
using UnityEngine;

public class PromotionalWorkshopExport : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDownloadWorkshopItems_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PromotionalWorkshopExport _003C_003E4__this;

		public IEnumerable<ulong> workshopIds;

		private TaskAwaiter _003C_003Eu__1;

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
	private struct _003CSubscribeToItems_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IEnumerable<ulong> workshopIds;

		private TaskAwaiter<ResultPage?> _003C_003Eu__1;

		private IEnumerator<Item> _003C_003E7__wrap1;

		private Item _003C_item_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__2;

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
	private struct _003CDownloadItems_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IEnumerable<ulong> workshopIds;

		private TaskAwaiter<ResultPage?> _003C_003Eu__1;

		private IEnumerator<Item> _003C_003E7__wrap1;

		private Item _003C_item_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

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

	public ulong[] workshop;

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CDownloadWorkshopItems_003Ed__2))]
	public void DownloadWorkshopItems(IEnumerable<ulong> workshopIds)
	{
	}

	[AsyncStateMachine(typeof(_003CSubscribeToItems_003Ed__3))]
	public Task SubscribeToItems(IEnumerable<ulong> workshopIds)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDownloadItems_003Ed__4))]
	public Task DownloadItems(IEnumerable<ulong> workshopIds)
	{
		return null;
	}
}
