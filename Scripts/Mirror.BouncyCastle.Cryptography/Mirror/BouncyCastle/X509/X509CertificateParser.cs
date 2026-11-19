using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.X509;

public class X509CertificateParser
{
	[CompilerGenerated]
	private sealed class _003CParseCertificates_003Ed__11 : IEnumerable<X509Certificate>, IEnumerable, IEnumerator<X509Certificate>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private X509Certificate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public X509CertificateParser _003C_003E4__this;

		private Stream inStream;

		public Stream _003C_003E3__inStream;

		X509Certificate IEnumerator<X509Certificate>.Current
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
		public _003CParseCertificates_003Ed__11(int _003C_003E1__state)
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
		IEnumerator<X509Certificate> IEnumerable<X509Certificate>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private static readonly PemParser PemCertParser;

	private Asn1Set sData;

	private int sDataObjectCount;

	private Stream currentStream;

	private X509Certificate ReadDerCertificate(Asn1InputStream dIn)
	{
		return null;
	}

	private X509Certificate ReadPemCertificate(Stream inStream)
	{
		return null;
	}

	private X509Certificate GetCertificate()
	{
		return null;
	}

	public X509Certificate ReadCertificate(byte[] input)
	{
		return null;
	}

	public IList<X509Certificate> ReadCertificates(byte[] input)
	{
		return null;
	}

	public X509Certificate ReadCertificate(Stream inStream)
	{
		return null;
	}

	public IList<X509Certificate> ReadCertificates(Stream inStream)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CParseCertificates_003Ed__11))]
	public IEnumerable<X509Certificate> ParseCertificates(Stream inStream)
	{
		return null;
	}
}
