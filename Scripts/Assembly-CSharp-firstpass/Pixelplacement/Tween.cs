using System;
using System.Collections.Generic;
using Pixelplacement.TweenSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Pixelplacement;

public class Tween
{
	public enum TweenType
	{
		Position = 0,
		Rotation = 1,
		LocalScale = 2,
		LightColor = 3,
		CameraBackgroundColor = 4,
		LightIntensity = 5,
		LightRange = 6,
		FieldOfView = 7,
		SpriteRendererColor = 8,
		GraphicColor = 9,
		AnchoredPosition = 10,
		Size = 11,
		Volume = 12,
		Pitch = 13,
		PanStereo = 14,
		ShaderFloat = 15,
		ShaderColor = 16,
		ShaderInt = 17,
		ShaderVector = 18,
		Value = 19,
		CanvasGroupAlpha = 20,
		Spline = 21,
		TextColor = 22,
		ImageColor = 23,
		RawImageColor = 24,
		TextMeshColor = 25
	}

	public enum LoopType
	{
		None = 0,
		Loop = 1,
		PingPong = 2
	}

	public enum TweenStatus
	{
		Delayed = 0,
		Running = 1,
		Canceled = 2,
		Stopped = 3,
		Finished = 4
	}

	public static List<TweenBase> activeTweens;

	private static TweenEngine _instance;

	private static AnimationCurve _easeIn;

	private static AnimationCurve _easeInStrong;

	private static AnimationCurve _easeOut;

	private static AnimationCurve _easeOutStrong;

	private static AnimationCurve _easeInOut;

	private static AnimationCurve _easeInOutStrong;

	private static AnimationCurve _easeInBack;

	private static AnimationCurve _easeOutBack;

	private static AnimationCurve _easeInOutBack;

	private static AnimationCurve _easeSpring;

	private static AnimationCurve _easeBounce;

	private static AnimationCurve _easeWobble;

	public static TweenEngine Instance => null;

	public static AnimationCurve EaseLinear => null;

	public static AnimationCurve EaseIn => null;

	public static AnimationCurve EaseInStrong => null;

	public static AnimationCurve EaseOut => null;

	public static AnimationCurve EaseOutStrong => null;

	public static AnimationCurve EaseInOut => null;

	public static AnimationCurve EaseInOutStrong => null;

	public static AnimationCurve EaseInBack => null;

	public static AnimationCurve EaseOutBack => null;

	public static AnimationCurve EaseInOutBack => null;

	public static AnimationCurve EaseSpring => null;

	public static AnimationCurve EaseBounce => null;

	public static AnimationCurve EaseWobble => null;

	public static TweenBase Shake(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Spline(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase CanvasGroupAlpha(CanvasGroup target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Value(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderVector(Material target, string propertyName, Vector4 startValue, Vector4 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderInt(Material target, string propertyName, int startValue, int endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderColor(Material target, string propertyName, Color startValue, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase ShaderFloat(Material target, string propertyName, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Pitch(AudioSource target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Pitch(AudioSource target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase PanStereo(AudioSource target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase PanStereo(AudioSource target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Volume(AudioSource target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Volume(AudioSource target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Size(RectTransform target, Vector2 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Size(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase FieldOfView(Camera target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase FieldOfView(Camera target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LightRange(Light target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LightRange(Light target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LightIntensity(Light target, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LightIntensity(Light target, float startValue, float endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalScale(Transform target, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalScale(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Graphic target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Graphic target, Color startValue, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Light target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Light target, Color startValue, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Material target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Material target, Color startColor, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Renderer target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Renderer target, Color startColor, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(SpriteRenderer target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(SpriteRenderer target, Color startColor, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Camera target, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Color(Camera target, Color startColor, Color endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Position(Transform target, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Position(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase AnchoredPosition(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalPosition(Transform target, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalPosition(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Rotate(Transform target, Vector3 amount, Space space, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Rotation(Transform target, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Rotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Rotation(Transform target, Quaternion endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase Rotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalRotation(Transform target, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalRotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalRotation(Transform target, Quaternion endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LocalRotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LookAt(Transform target, Transform targetToLookAt, Vector3 up, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static TweenBase LookAt(Transform target, Vector3 positionToLookAt, Vector3 up, float duration, float delay, AnimationCurve easeCurve = null, LoopType loop = LoopType.None, Action startCallback = null, Action completeCallback = null, bool obeyTimescale = true)
	{
		return null;
	}

	public static void Stop(int targetInstanceID, TweenType tweenType)
	{
	}

	public static void Stop(int targetInstanceID)
	{
	}

	public static void StopAll()
	{
	}

	public static void FinishAll()
	{
	}

	public static void Finish(int targetInstanceID)
	{
	}

	public static void Cancel(int targetInstanceID)
	{
	}

	public static void CancelAll()
	{
	}

	private static void StopInstanceTarget(int id)
	{
	}

	private static void StopInstanceTargetType(int id, TweenType type)
	{
	}

	private static void FinishInstanceTarget(int id)
	{
	}

	private static void CancelInstanceTarget(int id)
	{
	}

	private static void SendTweenForProcessing(TweenBase tween, bool interrupt = false)
	{
	}
}
