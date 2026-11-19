using System;
using System.Collections.Generic;
using System.Text;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixNameConstraintValidator
{
	private static readonly DerObjectIdentifier SerialNumberOid;

	private HashSet<Asn1Sequence> excludedSubtreesDN;

	private HashSet<string> excludedSubtreesDns;

	private HashSet<string> excludedSubtreesEmail;

	private HashSet<string> excludedSubtreesUri;

	private HashSet<byte[]> excludedSubtreesIP;

	private HashSet<OtherName> excludedSubtreesOtherName;

	private HashSet<Asn1Sequence> permittedSubtreesDN;

	private HashSet<string> permittedSubtreesDns;

	private HashSet<string> permittedSubtreesEmail;

	private HashSet<string> permittedSubtreesUri;

	private HashSet<byte[]> permittedSubtreesIP;

	private HashSet<OtherName> permittedSubtreesOtherName;

	private static bool WithinDNSubtree(Asn1Sequence dns, Asn1Sequence subtree)
	{
		return false;
	}

	public void CheckExcludedDN(Asn1Sequence dn)
	{
	}

	public void CheckPermittedDN(Asn1Sequence dn)
	{
	}

	private void CheckExcludedDN(HashSet<Asn1Sequence> excluded, Asn1Sequence directory)
	{
	}

	private void CheckPermittedDN(HashSet<Asn1Sequence> permitted, Asn1Sequence directory)
	{
	}

	private bool IsDNConstrained(HashSet<Asn1Sequence> constraints, Asn1Sequence directory)
	{
		return false;
	}

	private HashSet<Asn1Sequence> IntersectDN(HashSet<Asn1Sequence> permitted, HashSet<GeneralSubtree> dns)
	{
		return null;
	}

	private HashSet<Asn1Sequence> UnionDN(HashSet<Asn1Sequence> excluded, Asn1Sequence dn)
	{
		return null;
	}

	private void CheckExcludedOtherName(HashSet<OtherName> excluded, OtherName name)
	{
	}

	private void CheckPermittedOtherName(HashSet<OtherName> permitted, OtherName name)
	{
	}

	private bool IsOtherNameConstrained(HashSet<OtherName> constraints, OtherName otherName)
	{
		return false;
	}

	private bool IsOtherNameConstrained(OtherName constraint, OtherName otherName)
	{
		return false;
	}

	private HashSet<OtherName> IntersectOtherName(HashSet<OtherName> permitted, HashSet<GeneralSubtree> otherNames)
	{
		return null;
	}

	private void IntersectOtherName(OtherName otherName1, OtherName otherName2, HashSet<OtherName> intersect)
	{
	}

	private HashSet<OtherName> UnionOtherName(HashSet<OtherName> permitted, OtherName otherName)
	{
		return null;
	}

	private void CheckExcludedEmail(HashSet<string> excluded, string email)
	{
	}

	private void CheckPermittedEmail(HashSet<string> permitted, string email)
	{
	}

	private bool IsEmailConstrained(HashSet<string> constraints, string email)
	{
		return false;
	}

	private bool IsEmailConstrained(string constraint, string email)
	{
		return false;
	}

	private HashSet<string> IntersectEmail(HashSet<string> permitted, HashSet<GeneralSubtree> emails)
	{
		return null;
	}

	private void IntersectEmail(string email1, string email2, HashSet<string> intersect)
	{
	}

	private HashSet<string> UnionEmail(HashSet<string> excluded, string email)
	{
		return null;
	}

	private void UnionEmail(string email1, string email2, HashSet<string> union)
	{
	}

	private void CheckExcludedIP(HashSet<byte[]> excluded, byte[] ip)
	{
	}

	private void CheckPermittedIP(HashSet<byte[]> permitted, byte[] ip)
	{
	}

	private bool IsIPConstrained(HashSet<byte[]> constraints, byte[] ip)
	{
		return false;
	}

	private bool IsIPConstrained(byte[] constraint, byte[] ip)
	{
		return false;
	}

	private HashSet<byte[]> IntersectIP(HashSet<byte[]> permitted, HashSet<GeneralSubtree> ips)
	{
		return null;
	}

	private HashSet<byte[]> IntersectIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		return null;
	}

	private HashSet<byte[]> UnionIP(HashSet<byte[]> excluded, byte[] ip)
	{
		return null;
	}

	private HashSet<byte[]> UnionIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		return null;
	}

	private byte[] IpWithSubnetMask(byte[] ip, byte[] subnetMask)
	{
		return null;
	}

	private byte[][] ExtractIPsAndSubnetMasks(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		return null;
	}

	private byte[][] MinMaxIPs(byte[] ip1, byte[] subnetmask1, byte[] ip2, byte[] subnetmask2)
	{
		return null;
	}

	private static byte[] Max(byte[] ip1, byte[] ip2)
	{
		return null;
	}

	private static byte[] Min(byte[] ip1, byte[] ip2)
	{
		return null;
	}

	private static int CompareTo(byte[] ip1, byte[] ip2)
	{
		return 0;
	}

	private static byte[] Or(byte[] ip1, byte[] ip2)
	{
		return null;
	}

	private void CheckExcludedDns(HashSet<string> excluded, string dns)
	{
	}

	private void CheckPermittedDns(HashSet<string> permitted, string dns)
	{
	}

	private bool IsDnsConstrained(HashSet<string> constraints, string dns)
	{
		return false;
	}

	private bool IsDnsConstrained(string constraint, string dns)
	{
		return false;
	}

	private HashSet<string> IntersectDns(HashSet<string> permitted, HashSet<GeneralSubtree> dnss)
	{
		return null;
	}

	private HashSet<string> UnionDns(HashSet<string> excluded, string dns)
	{
		return null;
	}

	private void CheckExcludedUri(HashSet<string> excluded, string uri)
	{
	}

	private void CheckPermittedUri(HashSet<string> permitted, string uri)
	{
	}

	private bool IsUriConstrained(HashSet<string> constraints, string uri)
	{
		return false;
	}

	private bool IsUriConstrained(string constraint, string uri)
	{
		return false;
	}

	private HashSet<string> IntersectUri(HashSet<string> permitted, HashSet<GeneralSubtree> uris)
	{
		return null;
	}

	private void IntersectUri(string email1, string email2, HashSet<string> intersect)
	{
	}

	private HashSet<string> UnionUri(HashSet<string> excluded, string uri)
	{
		return null;
	}

	private void UnionUri(string email1, string email2, HashSet<string> union)
	{
	}

	private static string ExtractHostFromURL(string url)
	{
		return null;
	}

	private bool WithinDomain(string testDomain, string domain)
	{
		return false;
	}

	[Obsolete("Use 'CheckPermittedName' instead")]
	public void checkPermitted(GeneralName name)
	{
	}

	public void CheckPermittedName(GeneralName name)
	{
	}

	[Obsolete("Use 'CheckExcludedName' instead")]
	public void checkExcluded(GeneralName name)
	{
	}

	public void CheckExcludedName(GeneralName name)
	{
	}

	public void IntersectPermittedSubtree(Asn1Sequence permitted)
	{
	}

	private string ExtractNameAsString(GeneralName name)
	{
		return null;
	}

	public void IntersectEmptyPermittedSubtree(int nameType)
	{
	}

	public void AddExcludedSubtree(GeneralSubtree subtree)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private int HashCollection(HashSet<byte[]> c)
	{
		return 0;
	}

	private int HashCollection<T>(HashSet<T> c)
	{
		return 0;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	private bool AreEqualSets(HashSet<byte[]> set1, HashSet<byte[]> set2)
	{
		return false;
	}

	private bool AreEqualSets<T>(HashSet<T> set1, HashSet<T> set2)
	{
		return false;
	}

	private string StringifyIP(byte[] ip)
	{
		return null;
	}

	private string StringifyIPCollection(HashSet<byte[]> ips)
	{
		return null;
	}

	private string StringifyOtherNameCollection(HashSet<OtherName> otherNames)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static void Append(StringBuilder sb, string name, object value)
	{
	}
}
