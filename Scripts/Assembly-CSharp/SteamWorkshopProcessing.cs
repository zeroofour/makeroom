using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Ugc;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SteamWorkshopProcessing : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadWorkshop_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SteamWorkshopProcessing _003C_003E4__this;

		private TaskAwaiter<List<Item>> _003C_003Eu__1;

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

	[CompilerGenerated]
	private sealed class _003CProcessWorkshopItems_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamWorkshopProcessing _003C_003E4__this;

		private int _003C_index_003E5__2;

		private List<Item>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProcessWorkshopItems_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetAllSubscribedItems_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<Item>> _003C_003Et__builder;

		private List<Item> _003CallItems_003E5__2;

		private int _003Cpage_003E5__3;

		private TaskAwaiter<ResultPage?> _003C_003Eu__1;

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

	public static List<LibraryObject> workshopItems;

	[Header("Components")]
	public Text output;

	[Header("Events")]
	public UnityEvent onComplete;

	private List<Item> workshopEntries;

	public void PrepareWorkshop()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadWorkshop_003Ed__5))]
	private void LoadWorkshop()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWorkshopItems_003Ed__6))]
	private IEnumerator ProcessWorkshopItems()
	{
		return null;
	}

	public void Complete()
	{
	}

	public void PreloadCustomObject(string _name, string _id, DioramaData _data)
	{
	}

	[AsyncStateMachine(typeof(_003CGetAllSubscribedItems_003Ed__9))]
	private Task<List<Item>> GetAllSubscribedItems()
	{
		return null;
	}
}
