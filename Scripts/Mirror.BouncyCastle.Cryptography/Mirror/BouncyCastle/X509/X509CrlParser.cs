using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.X509;

public class X509CrlParser
{
	[CompilerGenerated]
	private sealed class _003CParseCrls_003Ed__13 : IEnumerable<X509Crl>, IEnumerable, IEnumerator<X509Crl>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private X509Crl _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public X509CrlParser _003C_003E4__this;

		private Stream inStream;

		public Stream _003C_003E3__inStream;

		X509Crl IEnumerator<X509Crl>.Current
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
		public _003CParseCrls_003Ed__13(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<X509Crl> IEnumerable<X509Crl>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private static readonly PemParser PemCrlParser;

	private Asn1Set sCrlData;

	private int sCrlDataObjectCount;

	private Stream currentCrlStream;

	public X509CrlParser()
	{
	}

	[Obsolete("Will be removed")]
	public X509CrlParser(bool lazyAsn1)
	{
	}

	private X509Crl ReadDerCrl(Asn1InputStream dIn)
	{
		return null;
	}

	private X509Crl ReadPemCrl(Stream inStream)
	{
		return null;
	}

	private X509Crl GetCrl()
	{
		return null;
	}

	public X509Crl ReadCrl(byte[] input)
	{
		return null;
	}

	public IList<X509Crl> ReadCrls(byte[] input)
	{
		return null;
	}

	public X509Crl ReadCrl(Stream inStream)
	{
		return null;
	}

	public IList<X509Crl> ReadCrls(Stream inStream)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CParseCrls_003Ed__13))]
	public IEnumerable<X509Crl> ParseCrls(Stream inStream)
	{
		return null;
	}
}
