using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
	public enum BodyAnimation
	{
		Default = 0,
		Breath = 1
	}

	public enum ArmAnimation
	{
		Default = 0,
		Wave = 1
	}

	public enum FaceAnimation
	{
		Default = 0,
		Talking = 1
	}

	[Header("Properties")]
	public bool interaction;

	public BodyAnimation bodyAnimation;

	public ArmAnimation armAnimationLeft;

	public ArmAnimation armAnimationRight;

	public FaceAnimation faceAnimation;

	[Header("Body")]
	public Transform body;

	public Transform armLeft;

	public Transform armRight;

	[Header("Face")]
	public SpriteRenderer eyes;

	public SpriteRenderer brows;

	public SpriteRenderer mouth;

	[Header("Sprites")]
	public Sprite spriteEyesOpen;

	public Sprite spriteEyesClosed;

	public Sprite spriteEyesHappy;

	public Sprite spriteMouthDefault;

	public Sprite[] spritesMouthTalking;

	[Header("Components")]
	public RectTransform output;

	[Header("Initials")]
	public Vector3 initialBodyRotation;

	private float bodyRotationTarget;

	private float browsPositionTarget;

	private Vector3 armLeftRotationTarget;

	private Vector3 armRightRotationTarget;

	private Vector3 bodyRotation;

	private Vector3 bodyVelocity;

	private bool petting;

	private int mouthIndex;

	private string previousCursor;

	private void Awake()
	{
	}

	public void StartTalking()
	{
	}

	public void StopTalking()
	{
	}

	public void Talk()
	{
	}

	private void Update()
	{
	}

	private void MouseInteraction()
	{
	}

	public void Blink()
	{
	}

	public void BlinkCompleted()
	{
	}

	public void RandomPositions()
	{
	}

	public static Quaternion SmoothDampQuaternion(Quaternion current, Quaternion target, ref Vector3 currentVelocity, float smoothTime)
	{
		return default;
	}
}
