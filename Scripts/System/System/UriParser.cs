using System.Collections.Generic;

namespace System;

public abstract class UriParser
{
	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3
	}

	private class BuiltInUriParser : UriParser
	{
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			: base(UriSyntaxFlags.None)
		{
		}
	}

	private const UriSyntaxFlags SchemeOnlyFlags = UriSyntaxFlags.MayHavePath;

	private static readonly Dictionary<string, UriParser> m_Table;

	private static Dictionary<string, UriParser> m_TempTable;

	private UriSyntaxFlags m_Flags;

	private UriSyntaxFlags m_UpdatableFlags;

	private bool m_UpdatableFlagsUsed;

	private const UriSyntaxFlags c_UpdatableFlags = UriSyntaxFlags.UnEscapeDotsAndSlashes;

	private int m_Port;

	private string m_Scheme;

	internal const int NoDefaultPort = -1;

	private const int c_InitialTableSize = 25;

	internal static UriParser HttpUri;

	internal static UriParser HttpsUri;

	internal static UriParser WsUri;

	internal static UriParser WssUri;

	internal static UriParser FtpUri;

	internal static UriParser FileUri;

	internal static UriParser GopherUri;

	internal static UriParser NntpUri;

	internal static UriParser NewsUri;

	internal static UriParser MailToUri;

	internal static UriParser UuidUri;

	internal static UriParser TelnetUri;

	internal static UriParser LdapUri;

	internal static UriParser NetTcpUri;

	internal static UriParser NetPipeUri;

	internal static UriParser VsMacrosUri;

	private static readonly UriQuirksVersion s_QuirksVersion;

	private const int c_MaxCapacity = 512;

	private const UriSyntaxFlags UnknownV1SyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private static readonly UriSyntaxFlags HttpSyntaxFlags;

	private const UriSyntaxFlags FtpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private static readonly UriSyntaxFlags FileSyntaxFlags;

	private const UriSyntaxFlags VsmacrosSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags GopherSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NewsSyntaxFlags = UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NntpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags TelnetSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags LdapSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags MailtoSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NetPipeSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NetTcpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	internal string SchemeName => null;

	internal int DefaultPort => 0;

	internal static bool ShouldUseLegacyV2Quirks => false;

	internal UriSyntaxFlags Flags => UriSyntaxFlags.None;

	internal bool IsSimple => false;

	protected virtual UriParser OnNewUri()
	{
		return null;
	}

	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
	{
		return null;
	}

	static UriParser()
	{
	}

	internal bool NotAny(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool InFact(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool IsAllSet(UriSyntaxFlags flags)
	{
		return false;
	}

	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
	{
		return false;
	}

	internal UriParser(UriSyntaxFlags flags)
	{
	}

	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
	{
		return null;
	}

	internal static UriParser GetSyntax(string lwrCaseScheme)
	{
		return null;
	}

	internal UriParser InternalOnNewUri()
	{
		return null;
	}

	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
	{
		return null;
	}
}
