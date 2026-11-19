using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Cms;

public class CmsCompressedDataStreamGenerator
{
	private class CmsCompressedOutputStream : BaseOutputStream
	{
		private Stream _out;

		private BerSequenceGenerator _sGen;

		private BerSequenceGenerator _cGen;

		private BerSequenceGenerator _eiGen;

		private BerOctetStringGenerator _octGen;

		internal CmsCompressedOutputStream(Stream outStream, BerSequenceGenerator sGen, BerSequenceGenerator cGen, BerSequenceGenerator eiGen, BerOctetStringGenerator octGen)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	public static readonly string ZLib;

	private int _bufferSize;

	public void SetBufferSize(int bufferSize)
	{
	}

	public Stream Open(Stream outStream)
	{
		return null;
	}

	public Stream Open(Stream outStream, string compressionOid)
	{
		return null;
	}

	public Stream Open(Stream outStream, string contentOid, string compressionOid)
	{
		return null;
	}
}
