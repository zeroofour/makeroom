using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal sealed class StoreImpl<T> : IStore<T>
{
	[CompilerGenerated]
	private sealed class _003CMirror_002DBouncyCastle_002DUtilities_002DCollections_002DIStore_003CT_003E_002DEnumerateMatches_003Ed__2 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public StoreImpl<T> _003C_003E4__this;

		private ISelector<T> selector;

		public ISelector<T> _003C_003E3__selector;

		private List<T>.Enumerator _003C_003E7__wrap1;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return default;
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
		public _003CMirror_002DBouncyCastle_002DUtilities_002DCollections_002DIStore_003CT_003E_002DEnumerateMatches_003Ed__2(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly List<T> m_contents;

	internal StoreImpl(IEnumerable<T> e)
	{
	}

	[IteratorStateMachine(typeof(StoreImpl<>._003CMirror_002DBouncyCastle_002DUtilities_002DCollections_002DIStore_003CT_003E_002DEnumerateMatches_003Ed__2))]
	IEnumerable<T> IStore<T>.EnumerateMatches(ISelector<T> selector)
	{
		return null;
	}
}
