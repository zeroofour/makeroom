namespace Mirror.BouncyCastle.Tls;

public abstract class ExtensionType
{
	public const int server_name = 0;

	public const int max_fragment_length = 1;

	public const int client_certificate_url = 2;

	public const int trusted_ca_keys = 3;

	public const int truncated_hmac = 4;

	public const int status_request = 5;

	public const int user_mapping = 6;

	public const int client_authz = 7;

	public const int server_authz = 8;

	public const int cert_type = 9;

	public const int supported_groups = 10;

	public const int ec_point_formats = 11;

	public const int srp = 12;

	public const int signature_algorithms = 13;

	public const int use_srtp = 14;

	public const int heartbeat = 15;

	public const int application_layer_protocol_negotiation = 16;

	public const int status_request_v2 = 17;

	public const int signed_certificate_timestamp = 18;

	public const int client_certificate_type = 19;

	public const int server_certificate_type = 20;

	public const int padding = 21;

	public const int encrypt_then_mac = 22;

	public const int extended_master_secret = 23;

	public const int token_binding = 24;

	public const int cached_info = 25;

	public const int compress_certificate = 27;

	public const int record_size_limit = 28;

	public const int session_ticket = 35;

	public const int pre_shared_key = 41;

	public const int early_data = 42;

	public const int supported_versions = 43;

	public const int cookie = 44;

	public const int psk_key_exchange_modes = 45;

	public const int certificate_authorities = 47;

	public const int oid_filters = 48;

	public const int post_handshake_auth = 49;

	public const int signature_algorithms_cert = 50;

	public const int key_share = 51;

	public const int connection_id = 54;

	public const int renegotiation_info = 65281;

	public static string GetName(int extensionType)
	{
		return null;
	}

	public static string GetText(int extensionType)
	{
		return null;
	}

	public static bool IsRecognized(int extensionType)
	{
		return false;
	}
}
