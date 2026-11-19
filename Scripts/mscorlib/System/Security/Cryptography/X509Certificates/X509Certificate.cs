using System.Runtime.Serialization;

namespace System.Security.Cryptography.X509Certificates;

[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	private X509CertificateImpl impl;

	private byte[] lazyCertHash;

	private byte[] lazySerialNumber;

	private string lazyIssuer;

	private string lazySubject;

	private string lazyKeyAlgorithm;

	private byte[] lazyKeyAlgorithmParameters;

	private byte[] lazyPublicKey;

	private DateTime lazyNotBefore;

	private DateTime lazyNotAfter;

	internal const X509KeyStorageFlags KeyStorageFlagsAll = X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet;

	public string Issuer => null;

	public string Subject => null;

	internal X509CertificateImpl Impl => null;

	internal bool IsValid => false;

	public virtual void Reset()
	{
	}

	public X509Certificate()
	{
	}

	public X509Certificate(byte[] data)
	{
	}

	public X509Certificate(byte[] rawData, string password)
	{
	}

	public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
	{
	}

	internal X509Certificate(X509CertificateImpl impl)
	{
	}

	public X509Certificate(string fileName, string password)
	{
	}

	public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
	{
	}

	public X509Certificate(X509Certificate cert)
	{
	}

	public X509Certificate(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public virtual bool Equals(X509Certificate other)
	{
		return false;
	}

	public virtual byte[] Export(X509ContentType contentType, string password)
	{
		return null;
	}

	public virtual byte[] GetCertHash()
	{
		return null;
	}

	public virtual string GetCertHashString()
	{
		return null;
	}

	private byte[] GetRawCertHash()
	{
		return null;
	}

	public virtual string GetExpirationDateString()
	{
		return null;
	}

	public virtual byte[] GetRawCertData()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public virtual string GetKeyAlgorithm()
	{
		return null;
	}

	public virtual byte[] GetKeyAlgorithmParameters()
	{
		return null;
	}

	public virtual byte[] GetPublicKey()
	{
		return null;
	}

	public virtual byte[] GetSerialNumber()
	{
		return null;
	}

	public virtual string GetSerialNumberString()
	{
		return null;
	}

	private byte[] GetRawSerialNumber()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public virtual string ToString(bool fVerbose)
	{
		return null;
	}

	internal DateTime GetNotAfter()
	{
		return default;
	}

	internal DateTime GetNotBefore()
	{
		return default;
	}

	protected static string FormatDate(DateTime date)
	{
		return null;
	}

	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
	{
	}

	private void VerifyContentType(X509ContentType contentType)
	{
	}

	internal void ImportHandle(X509CertificateImpl impl)
	{
	}

	internal void ThrowIfInvalid()
	{
	}
}
