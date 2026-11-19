using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> where T : VisualElement
{
	private List<StyleSelector> m_StyleSelectors = null;

	private List<StyleSelectorPart> m_Parts = null;

	private VisualElement m_Element = null;

	private List<RuleMatcher> m_Matchers = null;

	private StyleSelectorRelationship m_Relationship = StyleSelectorRelationship.None;

	private int pseudoStatesMask = 0;

	private int negatedPseudoStatesMask = 0;

	private List<StyleSelector> styleSelectors => null;

	private List<StyleSelectorPart> parts => null;

	public UQueryBuilder(VisualElement visualElement)
	{
	}

	public UQueryBuilder<T> Class(string classname)
	{
		return default;
	}

	public UQueryBuilder<T> Name(string id)
	{
		return default;
	}

	public UQueryBuilder<T2> OfType<T2>(string name = null, string className = null) where T2 : VisualElement
	{
		return default;
	}

	internal UQueryBuilder<T> SingleBaseType()
	{
		return default;
	}

	private void AddClass(string c)
	{
	}

	private void AddName(string id)
	{
	}

	private void AddType<T2>() where T2 : VisualElement
	{
	}

	private UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship) where T2 : VisualElement
	{
		return default;
	}

	private void AddPseudoStatesRuleIfNecessasy()
	{
	}

	private void FinishSelector()
	{
	}

	private bool CurrentSelectorEmpty()
	{
		return false;
	}

	private void FinishCurrentSelector()
	{
	}

	public UQueryState<T> Build()
	{
		return default;
	}

	public void ToList(List<T> results)
	{
	}

	public bool Equals(UQueryBuilder<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
