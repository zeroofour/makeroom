using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKeyRingBundle
{
	[CompilerGenerated]
	private sealed class _003CGetKeyRings_003Ed__11 : IEnumerable<PgpPublicKeyRing>, IEnumerable, IEnumerator<PgpPublicKeyRing>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PgpPublicKeyRing _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private bool ignoreCase;

		public bool _003C_003E3__ignoreCase;

		public PgpPublicKeyRingBundle _003C_003E4__this;

		private bool matchPartial;

		public bool _003C_003E3__matchPartial;

		private string userID;

		public string _003C_003E3__userID;

		private CompareInfo _003CcompareInfo_003E5__2;

		private CompareOptions _003CcompareOptions_003E5__3;

		private IEnumerator<PgpPublicKeyRing> _003C_003E7__wrap3;

		private PgpPublicKeyRing _003CpubRing_003E5__5;

		private IEnumerator<string> _003C_003E7__wrap5;

		PgpPublicKeyRing IEnumerator<PgpPublicKeyRing>.Current
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
		IEnumerator<PgpPublicKeyRing> IEnumerable<PgpPublicKeyRing>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly IDictionary<long, PgpPublicKeyRing> m_pubRings;

	private readonly IList<long> m_order;

	public int Count => 0;

	private ICollection<PgpPublicKeyRing> KeyRings => null;

	private PgpPublicKeyRingBundle(IDictionary<long, PgpPublicKeyRing> pubRings, IList<long> order)
	{
	}

	public PgpPublicKeyRingBundle(byte[] encoding)
	{
	}

	public PgpPublicKeyRingBundle(Stream inputStream)
	{
	}

	public PgpPublicKeyRingBundle(IEnumerable<PgpObject> e)
	{
	}

	public IEnumerable<PgpPublicKeyRing> GetKeyRings()
	{
		return null;
	}

	public IEnumerable<PgpPublicKeyRing> GetKeyRings(string userId)
	{
		return null;
	}

	public IEnumerable<PgpPublicKeyRing> GetKeyRings(string userId, bool matchPartial)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetKeyRings_003Ed__11))]
	public IEnumerable<PgpPublicKeyRing> GetKeyRings(string userID, bool matchPartial, bool ignoreCase)
	{
		return null;
	}

	public PgpPublicKey GetPublicKey(long keyId)
	{
		return null;
	}

	public PgpPublicKeyRing GetPublicKeyRing(long keyId)
	{
		return null;
	}

	public PgpPublicKey GetPublicKey(byte[] fingerprint)
	{
		return null;
	}

	public PgpPublicKeyRing GetPublicKeyRing(byte[] fingerprint)
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

	public static PgpPublicKeyRingBundle AddPublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
	{
		return null;
	}

	public static PgpPublicKeyRingBundle RemovePublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
	{
		return null;
	}
}
