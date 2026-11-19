using UnityEngine;

namespace Pixelplacement
{
	[ExecuteInEditMode]
	public class SplineAnchor : MonoBehaviour
	{
		public TangentMode tangentMode;

		private bool _initialized;

		[HideInInspector]
		[SerializeField]
		private Transform _masterTangent;

		[SerializeField]
		[HideInInspector]
		private Transform _slaveTangent;

		private TangentMode _previousTangentMode;

		private Vector3 _previousInPosition;

		private Vector3 _previousOutPosition;

		private Vector3 _previousAnchorPosition;

		private Bounds _skinnedBounds;

		private Transform _anchor;

		private Transform _inTangent;

		private Transform _outTangent;

		public bool RenderingChange { get; set; }

		public bool Changed { get; set; }

		public Transform Anchor
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Transform InTangent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Transform OutTangent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void TangentChanged()
		{
		}

		private void Initialize()
		{
		}

		public void SetTangentStatus(bool inStatus, bool outStatus)
		{
		}

		public void Tilt(Vector3 angles)
		{
		}
	}
}
