using System.IO;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.IO.Pem;

namespace Mirror.BouncyCastle.OpenSsl;

public class PemWriter : Mirror.BouncyCastle.Utilities.IO.Pem.PemWriter
{
	public PemWriter(TextWriter writer)
		: base(null)
	{
	}

	public void WriteObject(object obj)
	{
	}

	public void WriteObject(object obj, string algorithm, char[] password, SecureRandom random)
	{
	}
}
