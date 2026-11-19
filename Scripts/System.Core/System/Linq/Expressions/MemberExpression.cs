using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{
	public MemberInfo Member => null;

	public Expression Expression { get; }

	[ExcludeFromCodeCoverage]
	internal virtual MemberInfo GetMember()
	{
		return null;
	}
}
