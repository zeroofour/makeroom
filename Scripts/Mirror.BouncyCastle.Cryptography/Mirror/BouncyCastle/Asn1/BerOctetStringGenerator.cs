using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

public class BerOctetStringGenerator : BerGenerator
{
	private class BufferedBerOctetStream : BaseOutputStream
	{
		private byte[] _buf;

		private int _off;

		private readonly Asn1OutputStream _derOut;

		internal BufferedBerOctetStream(Stream outStream, byte[] buf)
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

	public BerOctetStringGenerator(Stream outStream)
		: base(null)
	{
	}

	public BerOctetStringGenerator(Stream outStream, int tagNo, bool isExplicit)
		: base(null)
	{
	}

	public Stream GetOctetOutputStream()
	{
		return null;
	}

	public Stream GetOctetOutputStream(int bufSize)
	{
		return null;
	}

	public Stream GetOctetOutputStream(byte[] buf)
	{
		return null;
	}
}
