using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;
using Steamworks.Ugc;
using UnityEngine;
using UnityEngine.UI;

public class ModeSteamWorkshop : Mode
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CUpload_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ModeSteamWorkshop _003C_003E4__this;

		private TaskAwaiter<PublishedFileId?> _003C_003Eu__1;

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
	private struct _003CUploadSteamWorkshop_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<PublishedFileId?> _003C_003Et__builder;

		public ModeSteamWorkshop _003C_003E4__this;

		private string _003C_category_003E5__2;

		private TaskAwaiter<PublishResult> _003C_003Eu__1;

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

	[Header("Components")]
	public ComponentInput inputName;

	public Switcher switcherTag;

	public Text uploadButtonText;

	[Header("Properties")]
	public GameMode gameMode;

	public static ModeSteamWorkshop instance { get; private set; }

	private void Awake()
	{
	}

	public void Prepare()
	{
	}

	[AsyncStateMachine(typeof(_003CUpload_003Ed__10))]
	public void Upload()
	{
	}

	[AsyncStateMachine(typeof(_003CUploadSteamWorkshop_003Ed__11))]
	public Task<PublishedFileId?> UploadSteamWorkshop()
	{
		return null;
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}
}
