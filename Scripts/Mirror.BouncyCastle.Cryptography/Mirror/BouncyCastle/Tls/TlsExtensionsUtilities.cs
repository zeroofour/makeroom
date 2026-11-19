using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Tls;

public static class TlsExtensionsUtilities
{
	public static IDictionary<int, byte[]> EnsureExtensionsInitialised(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static void AddAlpnExtensionClient(IDictionary<int, byte[]> extensions, IList<ProtocolName> protocolNameList)
	{
	}

	public static void AddAlpnExtensionServer(IDictionary<int, byte[]> extensions, ProtocolName protocolName)
	{
	}

	public static void AddCertificateAuthoritiesExtension(IDictionary<int, byte[]> extensions, IList<X509Name> authorities)
	{
	}

	public static void AddClientCertificateTypeExtensionClient(IDictionary<int, byte[]> extensions, short[] certificateTypes)
	{
	}

	public static void AddClientCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions, short certificateType)
	{
	}

	public static void AddClientCertificateUrlExtension(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddCompressCertificateExtension(IDictionary<int, byte[]> extensions, int[] algorithms)
	{
	}

	public static void AddConnectionIDExtension(IDictionary<int, byte[]> extensions, byte[] connectionID)
	{
	}

	public static void AddCookieExtension(IDictionary<int, byte[]> extensions, byte[] cookie)
	{
	}

	public static void AddEarlyDataIndication(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddEarlyDataMaxSize(IDictionary<int, byte[]> extensions, long maxSize)
	{
	}

	public static void AddEmptyExtensionData(IDictionary<int, byte[]> extensions, int extType)
	{
	}

	public static void AddEncryptThenMacExtension(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddExtendedMasterSecretExtension(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddHeartbeatExtension(IDictionary<int, byte[]> extensions, HeartbeatExtension heartbeatExtension)
	{
	}

	public static void AddKeyShareClientHello(IDictionary<int, byte[]> extensions, IList<KeyShareEntry> clientShares)
	{
	}

	public static void AddKeyShareHelloRetryRequest(IDictionary<int, byte[]> extensions, int namedGroup)
	{
	}

	public static void AddKeyShareServerHello(IDictionary<int, byte[]> extensions, KeyShareEntry serverShare)
	{
	}

	public static void AddMaxFragmentLengthExtension(IDictionary<int, byte[]> extensions, short maxFragmentLength)
	{
	}

	public static void AddOidFiltersExtension(IDictionary<int, byte[]> extensions, IDictionary<DerObjectIdentifier, byte[]> filters)
	{
	}

	public static void AddPaddingExtension(IDictionary<int, byte[]> extensions, int dataLength)
	{
	}

	public static void AddPostHandshakeAuthExtension(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddPreSharedKeyClientHello(IDictionary<int, byte[]> extensions, OfferedPsks offeredPsks)
	{
	}

	public static void AddPreSharedKeyServerHello(IDictionary<int, byte[]> extensions, int selectedIdentity)
	{
	}

	public static void AddPskKeyExchangeModesExtension(IDictionary<int, byte[]> extensions, short[] modes)
	{
	}

	public static void AddRecordSizeLimitExtension(IDictionary<int, byte[]> extensions, int recordSizeLimit)
	{
	}

	public static void AddServerCertificateTypeExtensionClient(IDictionary<int, byte[]> extensions, short[] certificateTypes)
	{
	}

	public static void AddServerCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions, short certificateType)
	{
	}

	public static void AddServerNameExtensionClient(IDictionary<int, byte[]> extensions, IList<ServerName> serverNameList)
	{
	}

	public static void AddServerNameExtensionServer(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddSignatureAlgorithmsExtension(IDictionary<int, byte[]> extensions, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms)
	{
	}

	public static void AddSignatureAlgorithmsCertExtension(IDictionary<int, byte[]> extensions, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms)
	{
	}

	public static void AddStatusRequestExtension(IDictionary<int, byte[]> extensions, CertificateStatusRequest statusRequest)
	{
	}

	public static void AddStatusRequestV2Extension(IDictionary<int, byte[]> extensions, IList<CertificateStatusRequestItemV2> statusRequestV2)
	{
	}

	public static void AddSupportedGroupsExtension(IDictionary<int, byte[]> extensions, IList<int> namedGroups)
	{
	}

	public static void AddSupportedPointFormatsExtension(IDictionary<int, byte[]> extensions, short[] ecPointFormats)
	{
	}

	public static void AddSupportedVersionsExtensionClient(IDictionary<int, byte[]> extensions, ProtocolVersion[] versions)
	{
	}

	public static void AddSupportedVersionsExtensionServer(IDictionary<int, byte[]> extensions, ProtocolVersion selectedVersion)
	{
	}

	public static void AddTruncatedHmacExtension(IDictionary<int, byte[]> extensions)
	{
	}

	public static void AddTrustedCAKeysExtensionClient(IDictionary<int, byte[]> extensions, IList<TrustedAuthority> trustedAuthoritiesList)
	{
	}

	public static void AddTrustedCAKeysExtensionServer(IDictionary<int, byte[]> extensions)
	{
	}

	public static IList<ProtocolName> GetAlpnExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static ProtocolName GetAlpnExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<X509Name> GetCertificateAuthoritiesExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static short[] GetClientCertificateTypeExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static short GetClientCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	[Obsolete("Use version without 'defaultValue' instead")]
	public static short GetClientCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions, short defaultValue)
	{
		return 0;
	}

	public static int[] GetCompressCertificateExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static byte[] GetConnectionIDExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static byte[] GetCookieExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static long GetEarlyDataMaxSize(IDictionary<int, byte[]> extensions)
	{
		return 0L;
	}

	public static HeartbeatExtension GetHeartbeatExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<KeyShareEntry> GetKeyShareClientHello(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static int GetKeyShareHelloRetryRequest(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	public static KeyShareEntry GetKeyShareServerHello(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static short GetMaxFragmentLengthExtension(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	public static IDictionary<DerObjectIdentifier, byte[]> GetOidFiltersExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static int GetPaddingExtension(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	public static OfferedPsks GetPreSharedKeyClientHello(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static int GetPreSharedKeyServerHello(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	public static short[] GetPskKeyExchangeModesExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static int GetRecordSizeLimitExtension(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	public static short[] GetServerCertificateTypeExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static short GetServerCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return 0;
	}

	[Obsolete("Use version without 'defaultValue' instead")]
	public static short GetServerCertificateTypeExtensionServer(IDictionary<int, byte[]> extensions, short defaultValue)
	{
		return 0;
	}

	public static IList<ServerName> GetServerNameExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetSignatureAlgorithmsExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> GetSignatureAlgorithmsCertExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static CertificateStatusRequest GetStatusRequestExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<CertificateStatusRequestItemV2> GetStatusRequestV2Extension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static int[] GetSupportedGroupsExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static short[] GetSupportedPointFormatsExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static ProtocolVersion[] GetSupportedVersionsExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static ProtocolVersion GetSupportedVersionsExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static IList<TrustedAuthority> GetTrustedCAKeysExtensionClient(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static bool HasClientCertificateUrlExtension(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasEarlyDataIndication(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasEncryptThenMacExtension(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasExtendedMasterSecretExtension(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasServerNameExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasPostHandshakeAuthExtension(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasTruncatedHmacExtension(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static bool HasTrustedCAKeysExtensionServer(IDictionary<int, byte[]> extensions)
	{
		return false;
	}

	public static byte[] CreateAlpnExtensionClient(IList<ProtocolName> protocolNameList)
	{
		return null;
	}

	public static byte[] CreateAlpnExtensionServer(ProtocolName protocolName)
	{
		return null;
	}

	public static byte[] CreateCertificateAuthoritiesExtension(IList<X509Name> authorities)
	{
		return null;
	}

	public static byte[] CreateCertificateTypeExtensionClient(short[] certificateTypes)
	{
		return null;
	}

	public static byte[] CreateCertificateTypeExtensionServer(short certificateType)
	{
		return null;
	}

	public static byte[] CreateClientCertificateUrlExtension()
	{
		return null;
	}

	public static byte[] CreateCompressCertificateExtension(int[] algorithms)
	{
		return null;
	}

	public static byte[] CreateConnectionIDExtension(byte[] connectionID)
	{
		return null;
	}

	public static byte[] CreateCookieExtension(byte[] cookie)
	{
		return null;
	}

	public static byte[] CreateEarlyDataIndication()
	{
		return null;
	}

	public static byte[] CreateEarlyDataMaxSize(long maxSize)
	{
		return null;
	}

	public static byte[] CreateEmptyExtensionData()
	{
		return null;
	}

	public static byte[] CreateEncryptThenMacExtension()
	{
		return null;
	}

	public static byte[] CreateExtendedMasterSecretExtension()
	{
		return null;
	}

	public static byte[] CreateHeartbeatExtension(HeartbeatExtension heartbeatExtension)
	{
		return null;
	}

	public static byte[] CreateKeyShareClientHello(IList<KeyShareEntry> clientShares)
	{
		return null;
	}

	public static byte[] CreateKeyShareHelloRetryRequest(int namedGroup)
	{
		return null;
	}

	public static byte[] CreateKeyShareServerHello(KeyShareEntry serverShare)
	{
		return null;
	}

	public static byte[] CreateMaxFragmentLengthExtension(short maxFragmentLength)
	{
		return null;
	}

	public static byte[] CreateOidFiltersExtension(IDictionary<DerObjectIdentifier, byte[]> filters)
	{
		return null;
	}

	public static byte[] CreatePaddingExtension(int dataLength)
	{
		return null;
	}

	public static byte[] CreatePostHandshakeAuthExtension()
	{
		return null;
	}

	public static byte[] CreatePreSharedKeyClientHello(OfferedPsks offeredPsks)
	{
		return null;
	}

	public static byte[] CreatePreSharedKeyServerHello(int selectedIdentity)
	{
		return null;
	}

	public static byte[] CreatePskKeyExchangeModesExtension(short[] modes)
	{
		return null;
	}

	public static byte[] CreateRecordSizeLimitExtension(int recordSizeLimit)
	{
		return null;
	}

	public static byte[] CreateServerNameExtensionClient(IList<ServerName> serverNameList)
	{
		return null;
	}

	public static byte[] CreateServerNameExtensionServer()
	{
		return null;
	}

	public static byte[] CreateSignatureAlgorithmsExtension(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms)
	{
		return null;
	}

	public static byte[] CreateSignatureAlgorithmsCertExtension(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms)
	{
		return null;
	}

	public static byte[] CreateStatusRequestExtension(CertificateStatusRequest statusRequest)
	{
		return null;
	}

	public static byte[] CreateStatusRequestV2Extension(IList<CertificateStatusRequestItemV2> statusRequestV2)
	{
		return null;
	}

	public static byte[] CreateSupportedGroupsExtension(IList<int> namedGroups)
	{
		return null;
	}

	public static byte[] CreateSupportedPointFormatsExtension(short[] ecPointFormats)
	{
		return null;
	}

	public static byte[] CreateSupportedVersionsExtensionClient(ProtocolVersion[] versions)
	{
		return null;
	}

	public static byte[] CreateSupportedVersionsExtensionServer(ProtocolVersion selectedVersion)
	{
		return null;
	}

	public static byte[] CreateTruncatedHmacExtension()
	{
		return null;
	}

	public static byte[] CreateTrustedCAKeysExtensionClient(IList<TrustedAuthority> trustedAuthoritiesList)
	{
		return null;
	}

	public static byte[] CreateTrustedCAKeysExtensionServer()
	{
		return null;
	}

	private static bool ReadEmptyExtensionData(byte[] extensionData)
	{
		return false;
	}

	public static IList<ProtocolName> ReadAlpnExtensionClient(byte[] extensionData)
	{
		return null;
	}

	public static ProtocolName ReadAlpnExtensionServer(byte[] extensionData)
	{
		return null;
	}

	public static IList<X509Name> ReadCertificateAuthoritiesExtension(byte[] extensionData)
	{
		return null;
	}

	public static short[] ReadCertificateTypeExtensionClient(byte[] extensionData)
	{
		return null;
	}

	public static short ReadCertificateTypeExtensionServer(byte[] extensionData)
	{
		return 0;
	}

	public static bool ReadClientCertificateUrlExtension(byte[] extensionData)
	{
		return false;
	}

	public static int[] ReadCompressCertificateExtension(byte[] extensionData)
	{
		return null;
	}

	public static byte[] ReadConnectionIDExtension(byte[] extensionData)
	{
		return null;
	}

	public static byte[] ReadCookieExtension(byte[] extensionData)
	{
		return null;
	}

	public static bool ReadEarlyDataIndication(byte[] extensionData)
	{
		return false;
	}

	public static long ReadEarlyDataMaxSize(byte[] extensionData)
	{
		return 0L;
	}

	public static bool ReadEncryptThenMacExtension(byte[] extensionData)
	{
		return false;
	}

	public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
	{
		return false;
	}

	public static HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
	{
		return null;
	}

	public static IList<KeyShareEntry> ReadKeyShareClientHello(byte[] extensionData)
	{
		return null;
	}

	public static int ReadKeyShareHelloRetryRequest(byte[] extensionData)
	{
		return 0;
	}

	public static KeyShareEntry ReadKeyShareServerHello(byte[] extensionData)
	{
		return null;
	}

	public static short ReadMaxFragmentLengthExtension(byte[] extensionData)
	{
		return 0;
	}

	public static IDictionary<DerObjectIdentifier, byte[]> ReadOidFiltersExtension(byte[] extensionData)
	{
		return null;
	}

	public static int ReadPaddingExtension(byte[] extensionData)
	{
		return 0;
	}

	public static bool ReadPostHandshakeAuthExtension(byte[] extensionData)
	{
		return false;
	}

	public static OfferedPsks ReadPreSharedKeyClientHello(byte[] extensionData)
	{
		return null;
	}

	public static int ReadPreSharedKeyServerHello(byte[] extensionData)
	{
		return 0;
	}

	public static short[] ReadPskKeyExchangeModesExtension(byte[] extensionData)
	{
		return null;
	}

	public static int ReadRecordSizeLimitExtension(byte[] extensionData)
	{
		return 0;
	}

	public static IList<ServerName> ReadServerNameExtensionClient(byte[] extensionData)
	{
		return null;
	}

	public static bool ReadServerNameExtensionServer(byte[] extensionData)
	{
		return false;
	}

	public static IList<SignatureAndHashAlgorithm> ReadSignatureAlgorithmsExtension(byte[] extensionData)
	{
		return null;
	}

	public static IList<SignatureAndHashAlgorithm> ReadSignatureAlgorithmsCertExtension(byte[] extensionData)
	{
		return null;
	}

	public static CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
	{
		return null;
	}

	public static IList<CertificateStatusRequestItemV2> ReadStatusRequestV2Extension(byte[] extensionData)
	{
		return null;
	}

	public static int[] ReadSupportedGroupsExtension(byte[] extensionData)
	{
		return null;
	}

	public static short[] ReadSupportedPointFormatsExtension(byte[] extensionData)
	{
		return null;
	}

	public static ProtocolVersion[] ReadSupportedVersionsExtensionClient(byte[] extensionData)
	{
		return null;
	}

	public static ProtocolVersion ReadSupportedVersionsExtensionServer(byte[] extensionData)
	{
		return null;
	}

	public static bool ReadTruncatedHmacExtension(byte[] extensionData)
	{
		return false;
	}

	public static IList<TrustedAuthority> ReadTrustedCAKeysExtensionClient(byte[] extensionData)
	{
		return null;
	}

	public static bool ReadTrustedCAKeysExtensionServer(byte[] extensionData)
	{
		return false;
	}

	private static byte[] PatchOpaque16(MemoryStream buf)
	{
		return null;
	}
}
