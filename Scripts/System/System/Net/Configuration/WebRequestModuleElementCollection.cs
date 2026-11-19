using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

[DefaultMember("Item")]
[ConfigurationCollection(typeof(WebRequestModuleElement))]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
{
}
