using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
}
