namespace Mirror.BouncyCastle.Tls;

public abstract class HandshakeType
{
	public const short hello_request = 0;

	public const short client_hello = 1;

	public const short server_hello = 2;

	public const short certificate = 11;

	public const short server_key_exchange = 12;

	public const short certificate_request = 13;

	public const short server_hello_done = 14;

	public const short certificate_verify = 15;

	public const short client_key_exchange = 16;

	public const short finished = 20;

	public const short certificate_url = 21;

	public const short certificate_status = 22;

	public const short hello_verify_request = 3;

	public const short supplemental_data = 23;

	public const short new_session_ticket = 4;

	public const short end_of_early_data = 5;

	public const short hello_retry_request = 6;

	public const short encrypted_extensions = 8;

	public const short key_update = 24;

	public const short message_hash = 254;

	public const short compressed_certificate = 25;

	public static string GetName(short handshakeType)
	{
		return null;
	}

	public static string GetText(short handshakeType)
	{
		return null;
	}

	public static bool IsRecognized(short handshakeType)
	{
		return false;
	}
}
