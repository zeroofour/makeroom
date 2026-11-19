using System;
using System.IO;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpCompressedDataGenerator : IStreamGenerator
{
	private readonly CompressionAlgorithmTag algorithm;

	private readonly int compression;

	private Stream dOut;

	private BcpgOutputStream pkOut;

	public PgpCompressedDataGenerator(CompressionAlgorithmTag algorithm)
	{
	}

	public PgpCompressedDataGenerator(CompressionAlgorithmTag algorithm, int compression)
	{
	}

	public Stream Open(Stream outStr)
	{
		return null;
	}

	public Stream Open(Stream outStr, byte[] buffer)
	{
		return null;
	}

	private void DoOpen()
	{
	}

	[Obsolete("Dispose any opened Stream directly")]
	public void Close()
	{
	}
}
