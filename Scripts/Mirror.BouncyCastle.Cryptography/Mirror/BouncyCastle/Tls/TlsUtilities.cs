using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsUtilities
{
	private static readonly byte[] DowngradeTlsV11;

	private static readonly byte[] DowngradeTlsV12;

	private static readonly IDictionary<string, SignatureAndHashAlgorithm> CertSigAlgOids;

	private static readonly IList<SignatureAndHashAlgorithm> DefaultSupportedSigAlgs;

	public static readonly byte[] EmptyBytes;

	public static readonly short[] EmptyShorts;

	public static readonly int[] EmptyInts;

	public static readonly long[] EmptyLongs;

	public static readonly string[] EmptyStrings;

	internal static short MinimumHashStrict;

	internal static short MinimumHashPreferred;

	private static void AddCertSigAlgOid(IDictionary<string, SignatureAndHashAlgorithm> d, DerObjectIdentifier oid, SignatureAndHashAlgorithm sigAndHash)
	{
	}

	private static void AddCertSigAlgOid(IDictionary<string, SignatureAndHashAlgorithm> d, DerObjectIdentifier oid, short hashAlgorithm, short signatureAlgorithm)
	{
	}

	private static IDictionary<string, SignatureAndHashAlgorithm> CreateCertSigAlgOids()
	{
		return null;
	}

	private static IList<SignatureAndHashAlgorithm> CreateDefaultSupportedSigAlgs()
	{
		return null;
	}

	public static void CheckUint8(short i)
	{
	}

	public static void CheckUint8(int i)
	{
	}

	public static void CheckUint8(long i)
	{
	}

	public static void CheckUint16(int i)
	{
	}

	public static void CheckUint16(long i)
	{
	}

	public static void CheckUint24(int i)
	{
	}

	public static void CheckUint24(long i)
	{
	}

	public static void CheckUint32(long i)
	{
	}

	public static void CheckUint48(long i)
	{
	}

	public static void CheckUint64(long i)
	{
	}

	public static bool IsValidUint8(short i)
	{
		return false;
	}

	public static bool IsValidUint8(int i)
	{
		return false;
	}

	public static bool IsValidUint8(long i)
	{
		return false;
	}

	public static bool IsValidUint16(int i)
	{
		return false;
	}

	public static bool IsValidUint16(long i)
	{
		return false;
	}

	public static bool IsValidUint24(int i)
	{
		return false;
	}

	public static bool IsValidUint24(long i)
	{
		return false;
	}

	public static bool IsValidUint32(long i)
	{
		return false;
	}

	public static bool IsValidUint48(long i)
	{
		return false;
	}

	public static bool IsValidUint64(long i)
	{
		return false;
	}

	public static bool IsSsl(TlsContext context)
	{
		return false;
	}

	public static bool IsTlsV10(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV10(TlsContext context)
	{
		return false;
	}

	public static bool IsTlsV11(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV11(TlsContext context)
	{
		return false;
	}

	public static bool IsTlsV12(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV12(TlsContext context)
	{
		return false;
	}

	public static bool IsTlsV13(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV13(TlsContext context)
	{
		return false;
	}

	public static void WriteUint8(short i, Stream output)
	{
	}

	public static void WriteUint8(int i, Stream output)
	{
	}

	public static void WriteUint8(short i, byte[] buf, int offset)
	{
	}

	public static void WriteUint8(int i, byte[] buf, int offset)
	{
	}

	public static void WriteUint16(int i, Stream output)
	{
	}

	public static void WriteUint16(int i, byte[] buf, int offset)
	{
	}

	public static void WriteUint24(int i, Stream output)
	{
	}

	public static void WriteUint24(int i, byte[] buf, int offset)
	{
	}

	public static void WriteUint32(long i, Stream output)
	{
	}

	public static void WriteUint32(long i, byte[] buf, int offset)
	{
	}

	public static void WriteUint48(long i, Stream output)
	{
	}

	public static void WriteUint48(long i, byte[] buf, int offset)
	{
	}

	public static void WriteUint64(long i, Stream output)
	{
	}

	public static void WriteUint64(long i, byte[] buf, int offset)
	{
	}

	public static void WriteOpaque8(byte[] buf, Stream output)
	{
	}

	public static void WriteOpaque8(byte[] data, byte[] buf, int off)
	{
	}

	public static void WriteOpaque16(byte[] buf, Stream output)
	{
	}

	public static void WriteOpaque16(byte[] data, byte[] buf, int off)
	{
	}

	public static void WriteOpaque24(byte[] buf, Stream output)
	{
	}

	public static void WriteOpaque24(byte[] data, byte[] buf, int off)
	{
	}

	public static void WriteUint8Array(short[] u8s, Stream output)
	{
	}

	public static void WriteUint8Array(short[] u8s, byte[] buf, int offset)
	{
	}

	public static void WriteUint8ArrayWithUint8Length(short[] u8s, Stream output)
	{
	}

	public static void WriteUint8ArrayWithUint8Length(short[] u8s, byte[] buf, int offset)
	{
	}

	public static void WriteUint16Array(int[] u16s, Stream output)
	{
	}

	public static void WriteUint16Array(int[] u16s, byte[] buf, int offset)
	{
	}

	public static void WriteUint16ArrayWithUint8Length(int[] u16s, byte[] buf, int offset)
	{
	}

	public static void WriteUint16ArrayWithUint16Length(int[] u16s, Stream output)
	{
	}

	public static void WriteUint16ArrayWithUint16Length(int[] u16s, byte[] buf, int offset)
	{
	}

	public static byte[] DecodeOpaque8(byte[] buf)
	{
		return null;
	}

	public static byte[] DecodeOpaque8(byte[] buf, int minLength)
	{
		return null;
	}

	public static byte[] DecodeOpaque16(byte[] buf)
	{
		return null;
	}

	public static byte[] DecodeOpaque16(byte[] buf, int minLength)
	{
		return null;
	}

	public static short DecodeUint8(byte[] buf)
	{
		return 0;
	}

	public static short[] DecodeUint8ArrayWithUint8Length(byte[] buf)
	{
		return null;
	}

	public static int DecodeUint16(byte[] buf)
	{
		return 0;
	}

	public static int[] DecodeUint16ArrayWithUint8Length(byte[] buf)
	{
		return null;
	}

	public static long DecodeUint32(byte[] buf)
	{
		return 0L;
	}

	public static byte[] EncodeOpaque8(byte[] buf)
	{
		return null;
	}

	public static byte[] EncodeOpaque16(byte[] buf)
	{
		return null;
	}

	public static byte[] EncodeOpaque24(byte[] buf)
	{
		return null;
	}

	public static byte[] EncodeUint8(short u8)
	{
		return null;
	}

	public static byte[] EncodeUint8ArrayWithUint8Length(short[] u8s)
	{
		return null;
	}

	public static byte[] EncodeUint16(int u16)
	{
		return null;
	}

	public static byte[] EncodeUint16ArrayWithUint8Length(int[] u16s)
	{
		return null;
	}

	public static byte[] EncodeUint16ArrayWithUint16Length(int[] u16s)
	{
		return null;
	}

	public static byte[] EncodeUint24(int u24)
	{
		return null;
	}

	public static byte[] EncodeUint32(long u32)
	{
		return null;
	}

	public static byte[] EncodeVersion(ProtocolVersion version)
	{
		return null;
	}

	public static int ReadInt32(byte[] buf, int offset)
	{
		return 0;
	}

	public static short ReadUint8(Stream input)
	{
		return 0;
	}

	public static short ReadUint8(byte[] buf, int offset)
	{
		return 0;
	}

	public static int ReadUint16(Stream input)
	{
		return 0;
	}

	public static int ReadUint16(byte[] buf, int offset)
	{
		return 0;
	}

	public static int ReadUint24(Stream input)
	{
		return 0;
	}

	public static int ReadUint24(byte[] buf, int offset)
	{
		return 0;
	}

	public static long ReadUint32(Stream input)
	{
		return 0L;
	}

	public static long ReadUint32(byte[] buf, int offset)
	{
		return 0L;
	}

	public static long ReadUint48(Stream input)
	{
		return 0L;
	}

	public static long ReadUint48(byte[] buf, int offset)
	{
		return 0L;
	}

	public static byte[] ReadAllOrNothing(int length, Stream input)
	{
		return null;
	}

	public static byte[] ReadFully(int length, Stream input)
	{
		return null;
	}

	public static void ReadFully(byte[] buf, Stream input)
	{
	}

	public static byte[] ReadOpaque8(Stream input)
	{
		return null;
	}

	public static byte[] ReadOpaque8(Stream input, int minLength)
	{
		return null;
	}

	public static byte[] ReadOpaque8(Stream input, int minLength, int maxLength)
	{
		return null;
	}

	public static byte[] ReadOpaque16(Stream input)
	{
		return null;
	}

	public static byte[] ReadOpaque16(Stream input, int minLength)
	{
		return null;
	}

	public static byte[] ReadOpaque24(Stream input)
	{
		return null;
	}

	public static byte[] ReadOpaque24(Stream input, int minLength)
	{
		return null;
	}

	public static short[] ReadUint8Array(int count, Stream input)
	{
		return null;
	}

	public static short[] ReadUint8ArrayWithUint8Length(Stream input, int minLength)
	{
		return null;
	}

	public static int[] ReadUint16Array(int count, Stream input)
	{
		return null;
	}

	public static ProtocolVersion ReadVersion(byte[] buf, int offset)
	{
		return null;
	}

	public static ProtocolVersion ReadVersion(Stream input)
	{
		return null;
	}

	public static Asn1Object ReadAsn1Object(byte[] encoding)
	{
		return null;
	}

	public static void RequireDerEncoding(Asn1Encodable asn1, byte[] encoding)
	{
	}

	public static void WriteGmtUnixTime(byte[] buf, int offset)
	{
	}

	public static void WriteVersion(ProtocolVersion version, Stream output)
	{
	}

	public static void WriteVersion(ProtocolVersion version, byte[] buf, int offset)
	{
	}

	public static void AddIfSupported(IList<SignatureAndHashAlgorithm> supportedAlgs, TlsCrypto crypto, SignatureAndHashAlgorithm alg)
	{
	}

	public static void AddIfSupported(IList<int> supportedGroups, TlsCrypto crypto, int namedGroup)
	{
	}

	public static void AddIfSupported(IList<int> supportedGroups, TlsCrypto crypto, int[] namedGroups)
	{
	}

	public static bool AddToSet<T>(IList<T> s, T i)
	{
		return false;
	}

	public static IList<SignatureAndHashAlgorithm> GetDefaultDssSignatureAlgorithms()
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetDefaultECDsaSignatureAlgorithms()
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetDefaultRsaSignatureAlgorithms()
	{
		return null;
	}

	public static SignatureAndHashAlgorithm GetDefaultSignatureAlgorithm(short signatureAlgorithm)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetDefaultSignatureAlgorithms(short signatureAlgorithm)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetDefaultSupportedSignatureAlgorithms(TlsContext context)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetSupportedSignatureAlgorithms(TlsContext context, IList<SignatureAndHashAlgorithm> candidates)
	{
		return null;
	}

	internal static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(ProtocolVersion negotiatedVersion, TlsCredentialedSigner credentialedSigner)
	{
		return null;
	}

	public static byte[] GetExtensionData(IDictionary<int, byte[]> extensions, int extensionType)
	{
		return null;
	}

	public static bool HasExpectedEmptyExtensionData(IDictionary<int, byte[]> extensions, int extensionType, short alertDescription)
	{
		return false;
	}

	public static TlsSession ImportSession(byte[] sessionID, SessionParameters sessionParameters)
	{
		return null;
	}

	internal static bool IsExtendedMasterSecretOptional(ProtocolVersion protocolVersion)
	{
		return false;
	}

	internal static bool IsExtendedMasterSecretOptional(ProtocolVersion[] protocolVersions)
	{
		return false;
	}

	public static bool IsNullOrContainsNull(object[] array)
	{
		return false;
	}

	public static bool IsNullOrEmpty<T>(T[] array)
	{
		return false;
	}

	public static bool IsNullOrEmpty(string s)
	{
		return false;
	}

	public static bool IsNullOrEmpty<T>(IList<T> v)
	{
		return false;
	}

	public static bool IsSignatureAlgorithmsExtensionAllowed(ProtocolVersion version)
	{
		return false;
	}

	public static short GetLegacyClientCertType(short signatureAlgorithm)
	{
		return 0;
	}

	public static short GetLegacySignatureAlgorithmClient(short clientCertificateType)
	{
		return 0;
	}

	public static short GetLegacySignatureAlgorithmClientCert(short clientCertificateType)
	{
		return 0;
	}

	public static short GetLegacySignatureAlgorithmServer(int keyExchangeAlgorithm)
	{
		return 0;
	}

	public static short GetLegacySignatureAlgorithmServerCert(int keyExchangeAlgorithm)
	{
		return 0;
	}

	public static IList<SignatureAndHashAlgorithm> GetLegacySupportedSignatureAlgorithms()
	{
		return null;
	}

	public static void EncodeSupportedSignatureAlgorithms(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, Stream output)
	{
	}

	public static IList<SignatureAndHashAlgorithm> ParseSupportedSignatureAlgorithms(Stream input)
	{
		return null;
	}

	public static void VerifySupportedSignatureAlgorithm(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
	{
	}

	internal static void VerifySupportedSignatureAlgorithm(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm, short alertDescription)
	{
	}

	public static bool ContainsSignatureAlgorithm(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
	{
		return false;
	}

	public static bool ContainsAnySignatureAlgorithm(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, short signatureAlgorithm)
	{
		return false;
	}

	public static TlsSecret Prf(SecurityParameters securityParameters, TlsSecret secret, string asciiLabel, byte[] seed, int length)
	{
		return null;
	}

	public static byte[] Clone(byte[] data)
	{
		return null;
	}

	public static string[] Clone(string[] s)
	{
		return null;
	}

	public static bool ConstantTimeAreEqual(int len, byte[] a, int aOff, byte[] b, int bOff)
	{
		return false;
	}

	public static byte[] CopyOfRangeExact(byte[] original, int from, int to)
	{
		return null;
	}

	internal static byte[] Concat(byte[] a, byte[] b)
	{
		return null;
	}

	internal static byte[] CalculateEndPointHash(TlsContext context, TlsCertificate certificate, byte[] enc)
	{
		return null;
	}

	internal static byte[] CalculateEndPointHash(TlsContext context, TlsCertificate certificate, byte[] enc, int encOff, int encLen)
	{
		return null;
	}

	public static byte[] CalculateExporterSeed(SecurityParameters securityParameters, byte[] context)
	{
		return null;
	}

	private static byte[] CalculateFinishedHmac(SecurityParameters securityParameters, TlsSecret baseKey, byte[] transcriptHash)
	{
		return null;
	}

	private static byte[] CalculateFinishedHmac(int prfCryptoHashAlgorithm, int prfHashLength, TlsSecret baseKey, byte[] transcriptHash)
	{
		return null;
	}

	internal static TlsSecret CalculateMasterSecret(TlsContext context, TlsSecret preMasterSecret)
	{
		return null;
	}

	internal static byte[] CalculatePskBinder(TlsCrypto crypto, bool isExternalPsk, int pskCryptoHashAlgorithm, TlsSecret earlySecret, byte[] transcriptHash)
	{
		return null;
	}

	internal static byte[] CalculateVerifyData(TlsContext context, TlsHandshakeHash handshakeHash, bool isServer)
	{
		return null;
	}

	internal static void Establish13PhaseSecrets(TlsContext context, TlsSecret pskEarlySecret, TlsSecret sharedSecret)
	{
	}

	private static void Establish13TrafficSecrets(TlsContext context, byte[] transcriptHash, TlsSecret phaseSecret, string clientLabel, string serverLabel, RecordStream recordStream)
	{
	}

	internal static void Establish13PhaseApplication(TlsContext context, byte[] serverFinishedTranscriptHash, RecordStream recordStream)
	{
	}

	internal static void Establish13PhaseEarly(TlsContext context, byte[] clientHelloTranscriptHash, RecordStream recordStream)
	{
	}

	internal static void Establish13PhaseHandshake(TlsContext context, byte[] serverHelloTranscriptHash, RecordStream recordStream)
	{
	}

	internal static void Update13TrafficSecretLocal(TlsContext context)
	{
	}

	internal static void Update13TrafficSecretPeer(TlsContext context)
	{
	}

	private static void Update13TrafficSecret(TlsContext context, bool forServer)
	{
	}

	private static TlsSecret Update13TrafficSecret(SecurityParameters securityParameters, TlsSecret secret)
	{
		return null;
	}

	public static DerObjectIdentifier GetOidForHashAlgorithm(short hashAlgorithm)
	{
		return null;
	}

	internal static int GetPrfAlgorithm(SecurityParameters securityParameters, int cipherSuite)
	{
		return 0;
	}

	internal static int GetPrfAlgorithm13(int cipherSuite)
	{
		return 0;
	}

	internal static int[] GetPrfAlgorithms13(int[] cipherSuites)
	{
		return null;
	}

	internal static byte[] CalculateSignatureHash(TlsContext context, SignatureAndHashAlgorithm algorithm, byte[] extraSignatureInput, DigestInputBuffer buf)
	{
		return null;
	}

	internal static void SendSignatureInput(TlsContext context, byte[] extraSignatureInput, DigestInputBuffer buf, Stream output)
	{
	}

	internal static DigitallySigned GenerateCertificateVerifyClient(TlsClientContext clientContext, TlsCredentialedSigner clientAuthSigner, SignatureAndHashAlgorithm clientAuthAlgorithm, TlsStreamSigner clientAuthStreamSigner, TlsHandshakeHash handshakeHash)
	{
		return null;
	}

	internal static DigitallySigned Generate13CertificateVerify(TlsContext context, TlsCredentialedSigner credentialedSigner, TlsHandshakeHash handshakeHash)
	{
		return null;
	}

	private static byte[] Generate13CertificateVerify(TlsCrypto crypto, TlsCredentialedSigner credentialedSigner, string contextString, TlsHandshakeHash handshakeHash, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		return null;
	}

	internal static void VerifyCertificateVerifyClient(TlsServerContext serverContext, CertificateRequest certificateRequest, DigitallySigned certificateVerify, TlsHandshakeHash handshakeHash)
	{
	}

	internal static void Verify13CertificateVerifyClient(TlsServerContext serverContext, TlsHandshakeHash handshakeHash, CertificateVerify certificateVerify)
	{
	}

	internal static void Verify13CertificateVerifyServer(TlsClientContext clientContext, TlsHandshakeHash handshakeHash, CertificateVerify certificateVerify)
	{
	}

	private static void Verify13CertificateVerify(IList<SignatureAndHashAlgorithm> supportedAlgorithms, string contextString, TlsHandshakeHash handshakeHash, TlsCertificate certificate, CertificateVerify certificateVerify)
	{
	}

	private static byte[] GetCertificateVerifyHeader(string contextString)
	{
		return null;
	}

	internal static void GenerateServerKeyExchangeSignature(TlsContext context, TlsCredentialedSigner credentials, byte[] extraSignatureInput, DigestInputBuffer digestBuffer)
	{
	}

	internal static void VerifyServerKeyExchangeSignature(TlsContext context, Stream signatureInput, TlsCertificate serverCertificate, byte[] extraSignatureInput, DigestInputBuffer digestBuffer)
	{
	}

	internal static void TrackHashAlgorithmClient(TlsHandshakeHash handshakeHash, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
	}

	internal static void TrackHashAlgorithms(TlsHandshakeHash handshakeHash, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms)
	{
	}

	public static bool HasSigningCapability(short clientCertificateType)
	{
		return false;
	}

	public static IList<T> VectorOfOne<T>(T obj)
	{
		return null;
	}

	public static int GetCipherType(int cipherSuite)
	{
		return 0;
	}

	public static int GetEncryptionAlgorithm(int cipherSuite)
	{
		return 0;
	}

	public static int GetEncryptionAlgorithmType(int encryptionAlgorithm)
	{
		return 0;
	}

	public static int GetKeyExchangeAlgorithm(int cipherSuite)
	{
		return 0;
	}

	public static IList<int> GetKeyExchangeAlgorithms(int[] cipherSuites)
	{
		return null;
	}

	public static int GetMacAlgorithm(int cipherSuite)
	{
		return 0;
	}

	public static ProtocolVersion GetMinimumVersion(int cipherSuite)
	{
		return null;
	}

	public static IList<int> GetNamedGroupRoles(int[] cipherSuites)
	{
		return null;
	}

	public static IList<int> GetNamedGroupRoles(IList<int> keyExchangeAlgorithms)
	{
		return null;
	}

	public static bool IsAeadCipherSuite(int cipherSuite)
	{
		return false;
	}

	public static bool IsBlockCipherSuite(int cipherSuite)
	{
		return false;
	}

	public static bool IsStreamCipherSuite(int cipherSuite)
	{
		return false;
	}

	public static bool IsValidCipherSuiteForSignatureAlgorithms(int cipherSuite, IList<short> sigAlgs)
	{
		return false;
	}

	internal static bool IsValidCipherSuiteSelection(int[] offeredCipherSuites, int cipherSuite)
	{
		return false;
	}

	internal static bool IsValidKeyShareSelection(ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, IDictionary<int, TlsAgreement> clientAgreements, int keyShareGroup)
	{
		return false;
	}

	internal static bool IsValidSignatureAlgorithmForServerKeyExchange(short signatureAlgorithm, int keyExchangeAlgorithm)
	{
		return false;
	}

	public static bool IsValidSignatureSchemeForServerKeyExchange(int signatureScheme, int keyExchangeAlgorithm)
	{
		return false;
	}

	public static bool IsValidVersionForCipherSuite(int cipherSuite, ProtocolVersion version)
	{
		return false;
	}

	public static SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(TlsContext context, IList<SignatureAndHashAlgorithm> sigHashAlgs, short signatureAlgorithm)
	{
		return null;
	}

	public static SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(ProtocolVersion negotiatedVersion, IList<SignatureAndHashAlgorithm> sigHashAlgs, short signatureAlgorithm)
	{
		return null;
	}

	public static IList<short> GetUsableSignatureAlgorithms(IList<SignatureAndHashAlgorithm> sigHashAlgs)
	{
		return null;
	}

	public static int GetCommonCipherSuite13(ProtocolVersion negotiatedVersion, int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
	{
		return 0;
	}

	public static int[] GetCommonCipherSuites(int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
	{
		return null;
	}

	public static int[] GetSupportedCipherSuites(TlsCrypto crypto, int[] suites)
	{
		return null;
	}

	public static int[] GetSupportedCipherSuites(TlsCrypto crypto, int[] suites, int suitesOff, int suitesCount)
	{
		return null;
	}

	public static bool IsSupportedCipherSuite(TlsCrypto crypto, int cipherSuite)
	{
		return false;
	}

	public static bool IsSupportedKeyExchange(TlsCrypto crypto, int keyExchangeAlgorithm)
	{
		return false;
	}

	internal static bool HasAnyRsaSigAlgs(TlsCrypto crypto)
	{
		return false;
	}

	internal static byte[] GetCurrentPrfHash(TlsHandshakeHash handshakeHash)
	{
		return null;
	}

	private static TlsHash CreateHash(TlsCrypto crypto, short hashAlgorithm)
	{
		return null;
	}

	private static TlsHash CreateHash(TlsCrypto crypto, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		return null;
	}

	private static TlsKeyExchange CreateKeyExchangeClient(TlsClient client, int keyExchange)
	{
		return null;
	}

	private static TlsKeyExchange CreateKeyExchangeServer(TlsServer server, int keyExchange)
	{
		return null;
	}

	internal static TlsKeyExchange InitKeyExchangeClient(TlsClientContext clientContext, TlsClient client)
	{
		return null;
	}

	internal static TlsKeyExchange InitKeyExchangeServer(TlsServerContext serverContext, TlsServer server)
	{
		return null;
	}

	internal static TlsCipher InitCipher(TlsContext context)
	{
		return null;
	}

	public static void CheckPeerSigAlgs(TlsContext context, TlsCertificate[] peerCertPath)
	{
	}

	private static void CheckSigAlgOfClientCerts(TlsContext context, TlsCertificate[] clientCertPath)
	{
	}

	private static void CheckSigAlgOfServerCerts(TlsContext context, TlsCertificate[] serverCertPath)
	{
	}

	internal static void CheckTlsFeatures(Certificate serverCertificate, IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions)
	{
	}

	internal static void ProcessClientCertificate(TlsServerContext serverContext, Certificate clientCertificate, TlsKeyExchange keyExchange, TlsServer server)
	{
	}

	internal static void ProcessServerCertificate(TlsClientContext clientContext, CertificateStatus serverCertificateStatus, TlsKeyExchange keyExchange, TlsAuthentication clientAuthentication, IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions)
	{
	}

	internal static SignatureAndHashAlgorithm GetCertSigAndHashAlg(TlsCertificate subjectCert, TlsCertificate issuerCert)
	{
		return null;
	}

	internal static CertificateRequest ValidateCertificateRequest(CertificateRequest certificateRequest, TlsKeyExchange keyExchange)
	{
		return null;
	}

	internal static CertificateRequest NormalizeCertificateRequest(CertificateRequest certificateRequest, short[] validClientCertificateTypes)
	{
		return null;
	}

	internal static bool Contains(int[] buf, int off, int len, int value)
	{
		return false;
	}

	internal static bool ContainsAll(short[] container, short[] elements)
	{
		return false;
	}

	internal static bool ContainsNot(short[] buf, int off, int len, short value)
	{
		return false;
	}

	internal static short[] RetainAll(short[] retainer, short[] elements)
	{
		return null;
	}

	internal static short[] Truncate(short[] a, int n)
	{
		return null;
	}

	internal static int[] Truncate(int[] a, int n)
	{
		return null;
	}

	internal static TlsCredentialedAgreement RequireAgreementCredentials(TlsCredentials credentials)
	{
		return null;
	}

	internal static TlsCredentialedDecryptor RequireDecryptorCredentials(TlsCredentials credentials)
	{
		return null;
	}

	internal static TlsCredentialedSigner RequireSignerCredentials(TlsCredentials credentials)
	{
		return null;
	}

	private static void CheckClientCertificateType(CertificateRequest certificateRequest, short clientCertificateType, short alertDescription)
	{
	}

	private static void CheckDowngradeMarker(byte[] randomBlock, byte[] downgradeMarker)
	{
	}

	internal static void CheckDowngradeMarker(ProtocolVersion version, byte[] randomBlock)
	{
	}

	internal static void WriteDowngradeMarker(ProtocolVersion version, byte[] randomBlock)
	{
	}

	internal static TlsAuthentication ReceiveServerCertificate(TlsClientContext clientContext, TlsClient client, MemoryStream buf, IDictionary<int, byte[]> serverExtensions)
	{
		return null;
	}

	internal static TlsAuthentication Receive13ServerCertificate(TlsClientContext clientContext, TlsClient client, MemoryStream buf, IDictionary<int, byte[]> serverExtensions)
	{
		return null;
	}

	internal static TlsAuthentication Skip13ServerCertificate(TlsClientContext clientContext)
	{
		return null;
	}

	public static bool ContainsNonAscii(byte[] bs)
	{
		return false;
	}

	public static bool ContainsNonAscii(string s)
	{
		return false;
	}

	internal static IDictionary<int, TlsAgreement> AddKeyShareToClientHello(TlsClientContext clientContext, TlsClient client, IDictionary<int, byte[]> clientExtensions)
	{
		return null;
	}

	internal static IDictionary<int, TlsAgreement> AddKeyShareToClientHelloRetry(TlsClientContext clientContext, IDictionary<int, byte[]> clientExtensions, int keyShareGroup)
	{
		return null;
	}

	private static void CollectKeyShares(TlsCrypto crypto, int[] supportedGroups, IList<int> keyShareGroups, IDictionary<int, TlsAgreement> clientAgreements, IList<KeyShareEntry> clientShares)
	{
	}

	internal static KeyShareEntry SelectKeyShare(IList<KeyShareEntry> clientShares, int keyShareGroup)
	{
		return null;
	}

	internal static KeyShareEntry SelectKeyShare(TlsCrypto crypto, ProtocolVersion negotiatedVersion, IList<KeyShareEntry> clientShares, int[] clientSupportedGroups, int[] serverSupportedGroups)
	{
		return null;
	}

	internal static int SelectKeyShareGroup(TlsCrypto crypto, ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, int[] serverSupportedGroups)
	{
		return 0;
	}

	internal static byte[] ReadEncryptedPms(TlsContext context, Stream input)
	{
		return null;
	}

	internal static void WriteEncryptedPms(TlsContext context, byte[] encryptedPms, Stream output)
	{
	}

	internal static byte[] GetSessionID(TlsSession tlsSession)
	{
		return null;
	}

	internal static void AdjustTranscriptForRetry(TlsHandshakeHash handshakeHash)
	{
	}

	internal static TlsCredentials EstablishClientCredentials(TlsAuthentication clientAuthentication, CertificateRequest certificateRequest)
	{
		return null;
	}

	internal static TlsCredentialedSigner Establish13ClientCredentials(TlsAuthentication clientAuthentication, CertificateRequest certificateRequest)
	{
		return null;
	}

	internal static void EstablishClientSigAlgs(SecurityParameters securityParameters, IDictionary<int, byte[]> clientExtensions)
	{
	}

	internal static TlsCredentials EstablishServerCredentials(TlsServer server)
	{
		return null;
	}

	internal static TlsCredentialedSigner Establish13ServerCredentials(TlsServer server)
	{
		return null;
	}

	internal static void EstablishServerSigAlgs(SecurityParameters securityParameters, CertificateRequest certificateRequest)
	{
	}

	internal static TlsCredentials ValidateCredentials(TlsCredentials credentials)
	{
		return null;
	}

	internal static TlsCredentialedSigner Validate13Credentials(TlsCredentials credentials)
	{
		return null;
	}

	internal static void NegotiatedCipherSuite(SecurityParameters securityParameters, int cipherSuite)
	{
	}

	internal static void NegotiatedVersion(SecurityParameters securityParameters)
	{
	}

	internal static void NegotiatedVersionDtlsClient(TlsClientContext clientContext, TlsClient client)
	{
	}

	internal static void NegotiatedVersionDtlsServer(TlsServerContext serverContext)
	{
	}

	internal static void NegotiatedVersionTlsClient(TlsClientContext clientContext, TlsClient client)
	{
	}

	internal static void NegotiatedVersionTlsServer(TlsServerContext serverContext)
	{
	}

	internal static TlsSecret DeriveSecret(SecurityParameters securityParameters, TlsSecret secret, string label, byte[] transcriptHash)
	{
		return null;
	}

	internal static TlsSecret DeriveSecret(int prfCryptoHashAlgorithm, int prfHashLength, TlsSecret secret, string label, byte[] transcriptHash)
	{
		return null;
	}

	internal static TlsSecret GetSessionMasterSecret(TlsCrypto crypto, TlsSecret masterSecret)
	{
		return null;
	}

	internal static bool IsPermittedExtensionType13(int handshakeType, int extensionType)
	{
		return false;
	}

	internal static void CheckExtensionData13(IDictionary<int, byte[]> extensions, int handshakeType, short alertDescription)
	{
	}

	public static TlsSecret GenerateEncryptedPreMasterSecret(TlsContext context, TlsEncryptor encryptor, Stream output)
	{
		return null;
	}

	public static bool IsTimeout(SocketException e)
	{
		return false;
	}

	internal static void AddPreSharedKeyToClientExtensions(TlsPsk[] psks, IDictionary<int, byte[]> clientExtensions)
	{
	}

	internal static OfferedPsks.BindersConfig AddPreSharedKeyToClientHello(TlsClientContext clientContext, TlsClient client, IDictionary<int, byte[]> clientExtensions, int[] offeredCipherSuites)
	{
		return null;
	}

	internal static OfferedPsks.BindersConfig AddPreSharedKeyToClientHelloRetry(TlsClientContext clientContext, OfferedPsks.BindersConfig clientBinders, IDictionary<int, byte[]> clientExtensions)
	{
		return null;
	}

	internal static OfferedPsks.SelectedConfig SelectPreSharedKey(TlsServerContext serverContext, TlsServer server, IDictionary<int, byte[]> clientHelloExtensions, HandshakeMessageInput clientHelloMessage, TlsHandshakeHash handshakeHash, bool afterHelloRetryRequest)
	{
		return null;
	}

	internal static TlsSecret GetPskEarlySecret(TlsCrypto crypto, TlsPsk psk)
	{
		return null;
	}

	internal static TlsSecret[] GetPskEarlySecrets(TlsCrypto crypto, TlsPsk[] psks)
	{
		return null;
	}

	internal static TlsPskExternal[] GetPskExternalsClient(TlsClient client, int[] offeredCipherSuites)
	{
		return null;
	}

	internal static IList<int> GetPskIndices(TlsPsk[] psks, int prfAlgorithm)
	{
		return null;
	}

	internal static short ProcessMaxFragmentLengthExtension(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	internal static short ProcessClientCertificateTypeExtension(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	internal static short ProcessClientCertificateTypeExtension13(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	internal static short ProcessServerCertificateTypeExtension(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	internal static short ProcessServerCertificateTypeExtension13(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	private static short ValidateCertificateType13(short certificateType, short alertDescription)
	{
		return 0;
	}

	internal static int GetHandshakeResendTimeMillis(TlsPeer tlsPeer)
	{
		return 0;
	}

	internal static void NotifyConnectionClosed(TlsPeer tlsPeer)
	{
	}

	internal static bool ShouldUseCompatibilityMode(TlsClient tlsClient)
	{
		return false;
	}
}
