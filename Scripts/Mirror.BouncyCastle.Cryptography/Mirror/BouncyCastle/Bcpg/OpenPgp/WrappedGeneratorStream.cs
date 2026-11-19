using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

internal sealed class WrappedGeneratorStream : FilterStream
{
	private readonly IStreamGenerator m_generator;

	internal WrappedGeneratorStream(IStreamGenerator generator, Stream s)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
