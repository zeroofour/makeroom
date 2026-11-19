using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public abstract class DtlsProtocol
{
	internal DtlsProtocol()
	{
	}

	internal virtual void ProcessFinished(byte[] body, byte[] expected_verify_data)
	{
	}

	internal static void ApplyMaxFragmentLengthExtension(DtlsRecordLayer recordLayer, short maxFragmentLength)
	{
	}

	internal static byte[] GenerateCertificate(TlsContext context, Certificate certificate, Stream endPointHash)
	{
		return null;
	}

	internal static byte[] GenerateSupplementalData(IList<SupplementalDataEntry> supplementalData)
	{
		return null;
	}

	internal static void SendCertificateMessage(TlsContext context, DtlsReliableHandshake handshake, Certificate certificate, Stream endPointHash)
	{
	}

	internal static int ValidateSelectedCipherSuite(int selectedCipherSuite, short alertDescription)
	{
		return 0;
	}
}
