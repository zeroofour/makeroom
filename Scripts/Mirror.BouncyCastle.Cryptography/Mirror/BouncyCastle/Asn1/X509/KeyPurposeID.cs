using System;

namespace Mirror.BouncyCastle.Asn1.X509;

public sealed class KeyPurposeID : DerObjectIdentifier
{
	private const string id_kp = "1.3.6.1.5.5.7.3";

	public static readonly KeyPurposeID AnyExtendedKeyUsage;

	public static readonly KeyPurposeID id_kp_serverAuth;

	public static readonly KeyPurposeID id_kp_clientAuth;

	public static readonly KeyPurposeID id_kp_codeSigning;

	public static readonly KeyPurposeID id_kp_emailProtection;

	public static readonly KeyPurposeID id_kp_ipsecEndSystem;

	public static readonly KeyPurposeID id_kp_ipsecTunnel;

	public static readonly KeyPurposeID id_kp_ipsecUser;

	public static readonly KeyPurposeID id_kp_timeStamping;

	public static readonly KeyPurposeID id_kp_OCSPSigning;

	public static readonly KeyPurposeID id_kp_dvcs;

	public static readonly KeyPurposeID id_kp_sbgpCertAAServerAuth;

	public static readonly KeyPurposeID id_kp_scvp_responder;

	public static readonly KeyPurposeID id_kp_eapOverPPP;

	public static readonly KeyPurposeID id_kp_eapOverLAN;

	public static readonly KeyPurposeID id_kp_scvpServer;

	public static readonly KeyPurposeID id_kp_scvpClient;

	public static readonly KeyPurposeID id_kp_ipsecIKE;

	public static readonly KeyPurposeID id_kp_capwapAC;

	public static readonly KeyPurposeID id_kp_capwapWTP;

	public static readonly KeyPurposeID id_kp_cmcCA;

	public static readonly KeyPurposeID id_kp_cmcRA;

	public static readonly KeyPurposeID id_kp_cmKGA;

	public static readonly KeyPurposeID id_kp_smartcardlogon;

	public static readonly KeyPurposeID id_kp_macAddress;

	public static readonly KeyPurposeID id_kp_msSGC;

	private const string id_pkinit = "1.3.6.1.5.2.3";

	public static readonly KeyPurposeID scSysNodeNumber;

	public static readonly KeyPurposeID id_pkinit_authData;

	public static readonly KeyPurposeID id_pkinit_DHKeyData;

	public static readonly KeyPurposeID id_pkinit_rkeyData;

	public static readonly KeyPurposeID keyPurposeClientAuth;

	public static readonly KeyPurposeID keyPurposeKdc;

	public static readonly KeyPurposeID id_kp_nsSGC;

	[Obsolete("Use 'id_kp_serverAuth' instead")]
	public static readonly KeyPurposeID IdKPServerAuth;

	[Obsolete("Use 'id_kp_clientAuth' instead")]
	public static readonly KeyPurposeID IdKPClientAuth;

	[Obsolete("Use 'id_kp_codeSigning' instead")]
	public static readonly KeyPurposeID IdKPCodeSigning;

	[Obsolete("Use 'id_kp_emailProtection' instead")]
	public static readonly KeyPurposeID IdKPEmailProtection;

	[Obsolete("Use 'id_kp_ipsecEndSystem' instead")]
	public static readonly KeyPurposeID IdKPIpsecEndSystem;

	[Obsolete("Use 'id_kp_ipsecTunnel' instead")]
	public static readonly KeyPurposeID IdKPIpsecTunnel;

	[Obsolete("Use 'id_kp_ipsecUser' instead")]
	public static readonly KeyPurposeID IdKPIpsecUser;

	[Obsolete("Use 'id_kp_timeStamping' instead")]
	public static readonly KeyPurposeID IdKPTimeStamping;

	[Obsolete("Use 'id_kp_OCSPSigning' instead")]
	public static readonly KeyPurposeID IdKPOcspSigning;

	[Obsolete("Use 'id_kp_smartcardlogon' instead")]
	public static readonly KeyPurposeID IdKPSmartCardLogon;

	[Obsolete("Use 'id_kp_macAddress' instead")]
	public static readonly KeyPurposeID IdKPMacAddress;

	private KeyPurposeID(string id)
		: base(null)
	{
	}
}
