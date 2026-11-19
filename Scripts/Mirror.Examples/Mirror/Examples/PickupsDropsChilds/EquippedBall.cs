using UnityEngine;

namespace Mirror.Examples.PickupsDropsChilds;

public class EquippedBall : MonoBehaviour, IEquipped
{
	[Header("Components")]
	public Animator animator;

	public AudioSource audioSource;

	[SerializeField]
	[Header("Equipped Item")]
	private EquippedItemConfig _equippedItemConfig;

	public EquippedItemConfig equippedItemConfig
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	private void Reset()
	{
	}

	public void Use()
	{
	}

	public void AddUsages(byte usages)
	{
	}

	public void ResetUsages()
	{
	}

	public void ResetUsages(byte usages)
	{
	}
}
