using System.Collections.Generic;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public abstract class PgpKeyRing : PgpObject
{
	internal PgpKeyRing()
	{
	}

	internal static TrustPacket ReadOptionalTrustPacket(BcpgInputStream pIn)
	{
		return null;
	}

	internal static IList<PgpSignature> ReadSignaturesAndTrust(BcpgInputStream pIn)
	{
		return null;
	}

	internal static void ReadUserIDs(BcpgInputStream pIn, out IList<IUserDataPacket> ids, out IList<TrustPacket> idTrusts, out IList<IList<PgpSignature>> idSigs)
	{
		ids = null;
		idTrusts = null;
		idSigs = null;
	}

	private static bool IsUserTag(PacketTag tag)
	{
		return false;
	}
}
