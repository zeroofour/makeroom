using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore;

[Serializable]
[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
public class Glyph
{
	[NativeName("index")]
	[SerializeField]
	private uint m_Index;

	[SerializeField]
	[NativeName("metrics")]
	private GlyphMetrics m_Metrics;

	[SerializeField]
	[NativeName("glyphRect")]
	private GlyphRect m_GlyphRect;

	[SerializeField]
	[NativeName("scale")]
	private float m_Scale;

	[SerializeField]
	[NativeName("atlasIndex")]
	private int m_AtlasIndex;

	[SerializeField]
	[NativeName("type")]
	private GlyphClassDefinitionType m_ClassDefinitionType;

	public uint index => 0u;

	public GlyphMetrics metrics => default;

	public GlyphRect glyphRect => default;

	public int atlasIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Glyph()
	{
	}

	internal Glyph(GlyphMarshallingStruct glyphStruct)
	{
	}

	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
	{
	}
}
