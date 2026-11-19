using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSecretKeyRingBundle
{
	[CompilerGenerated]
	private sealed class _003CGetKeyRings_003Ed__11 : IEnumerable<PgpSecretKeyRing>, IEnumerable, IEnumerator<PgpSecretKeyRing>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PgpSecretKeyRing _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private bool ignoreCase;

		public bool _003C_003E3__ignoreCase;

		public PgpSecretKeyRingBundle _003C_003E4__this;

		private bool matchPartial;

		public bool _003C_003E3__matchPartial;

		private string userID;

		public string _003C_003E3__userID;

		private CompareInfo _003CcompareInfo_003E5__2;

		private CompareOptions _003CcompareOptions_003E5__3;

		private IEnumerator<PgpSecretKeyRing> _003C_003E7__wrap3;

		private PgpSecretKeyRing _003CsecRing_003E5__5;

		private IEnumerator<string> _003C_003E7__wrap5;

		PgpSecretKeyRing IEnumerator<PgpSecretKeyRing>.Current
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
		public _003CGetKeyRings_003Ed__11(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<PgpSecretKeyRing> IEnumerable<PgpSecretKeyRing>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly IDictionary<long, PgpSecretKeyRing> m_secretRings;

	private readonly IList<long> m_order;

	public int Count => 0;

	private ICollection<PgpSecretKeyRing> KeyRings => null;

	private PgpSecretKeyRingBundle(IDictionary<long, PgpSecretKeyRing> secretRings, IList<long> order)
	{
	}

	public PgpSecretKeyRingBundle(byte[] encoding)
	{
	}

	public PgpSecretKeyRingBundle(Stream inputStream)
	{
	}

	public PgpSecretKeyRingBundle(IEnumerable<PgpObject> e)
	{
	}

	public IEnumerable<PgpSecretKeyRing> GetKeyRings()
	{
		return null;
	}

	public IEnumerable<PgpSecretKeyRing> GetKeyRings(string userId)
	{
		return null;
	}

	public IEnumerable<PgpSecretKeyRing> GetKeyRings(string userId, bool matchPartial)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetKeyRings_003Ed__11))]
	public IEnumerable<PgpSecretKeyRing> GetKeyRings(string userID, bool matchPartial, bool ignoreCase)
	{
		return null;
	}

	public PgpSecretKey GetSecretKey(long keyId)
	{
		return null;
	}

	public PgpSecretKeyRing GetSecretKeyRing(long keyId)
	{
		return null;
	}

	public bool Contains(long keyID)
	{
		return false;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public void Encode(Stream outStr)
	{
	}

	public static PgpSecretKeyRingBundle AddSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
	{
		return null;
	}

	public static PgpSecretKeyRingBundle RemoveSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
	{
		return null;
	}
}
