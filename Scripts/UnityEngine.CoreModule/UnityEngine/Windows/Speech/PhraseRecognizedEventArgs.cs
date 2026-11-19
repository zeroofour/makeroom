using System;

namespace UnityEngine.Windows.Speech;

public struct PhraseRecognizedEventArgs
{
	public readonly ConfidenceLevel confidence = ConfidenceLevel.High;

	public readonly SemanticMeaning[] semanticMeanings = null;

	public readonly string text = null;

	public readonly DateTime phraseStartTime = default;

	public readonly TimeSpan phraseDuration = default;

	internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
	{
	}
}
