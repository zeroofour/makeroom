using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Steamworks.Data;
using UnityEngine;

public class PromotionalWorkshopItems : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDownloadItem_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PromotionalWorkshopItems _003C_003E4__this;

		public PublishedFileId itemId;

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

	public ulong[] workshopItems;

	private HashSet<PublishedFileId> downloading;

	private void Awake()
	{
	}

	private void StartDownloading()
	{
	}

	public void DownloadAllItems()
	{
	}

	[AsyncStateMachine(typeof(_003CDownloadItem_003Ed__5))]
	private void DownloadItem(PublishedFileId itemId)
	{
	}
}
