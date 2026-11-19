using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;
using Mirror.BouncyCastle.X509.Store;

namespace Mirror.BouncyCastle.Pkix;

public class PkixCrlUtilities
{
	public virtual ISet<X509Crl> FindCrls(X509CrlStoreSelector crlSelector, PkixParameters paramsPkix)
	{
		return null;
	}

	public virtual ISet<X509Crl> FindCrls(ISelector<X509Crl> crlSelector, PkixParameters paramsPkix)
	{
		return null;
	}

	public virtual ISet<X509Crl> FindCrls(X509CrlStoreSelector crlSelector, PkixParameters paramsPkix, DateTime currentDate)
	{
		return null;
	}

	public virtual ISet<X509Crl> FindCrls(ISelector<X509Crl> crlSelector, PkixParameters paramsPkix, DateTime currentDate)
	{
		return null;
	}

	private HashSet<X509Crl> FindCrls(ISelector<X509Crl> crlSelector, IEnumerable<IStore<X509Crl>> crlStores)
	{
		return null;
	}
}
