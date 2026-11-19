namespace System.Security.Cryptography.X509Certificates;

[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData
{
	private const X500DistinguishedNameFlags AllFlags = X500DistinguishedNameFlags.Reversed | X500DistinguishedNameFlags.UseSemicolons | X500DistinguishedNameFlags.DoNotUsePlusSign | X500DistinguishedNameFlags.DoNotUseQuotes | X500DistinguishedNameFlags.UseCommas | X500DistinguishedNameFlags.UseNewLines | X500DistinguishedNameFlags.UseUTF8Encoding | X500DistinguishedNameFlags.UseT61Encoding | X500DistinguishedNameFlags.ForceUTF8Encoding;

	private string name;

	private byte[] canonEncoding;

	public string Name => null;

	public X500DistinguishedName(byte[] encodedDistinguishedName)
	{
	}

	public X500DistinguishedName(string distinguishedName)
	{
	}

	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag)
	{
	}

	public string Decode(X500DistinguishedNameFlags flag)
	{
		return null;
	}

	public override string Format(bool multiLine)
	{
		return null;
	}

	private static string GetSeparator(X500DistinguishedNameFlags flag)
	{
		return null;
	}

	private void DecodeRawData()
	{
	}

	private static string Canonize(string s)
	{
		return null;
	}

	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
	{
		return false;
	}
}
