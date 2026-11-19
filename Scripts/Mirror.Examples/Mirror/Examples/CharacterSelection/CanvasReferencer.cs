using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.CharacterSelection;

public class CanvasReferencer : MonoBehaviour
{
	public Button buttonExit;

	public Button buttonNextCharacter;

	public Button buttonGo;

	public Button buttonColour;

	public Button buttonColourReset;

	public Text textTitle;

	public Text textHealth;

	public Text textSpeed;

	public Text textAttack;

	public Text textAbilities;

	public InputField inputFieldPlayerName;

	public Transform podiumPosition;

	private int currentlySelectedCharacter;

	private CharacterData characterData;

	private GameObject currentInstantiatedCharacter;

	private CharacterSelection characterSelection;

	public SceneReferencer sceneReferencer;

	public Camera cameraObj;

	private void Start()
	{
	}

	public void ButtonExit()
	{
	}

	public void ButtonGo()
	{
	}

	public void ButtonNextCharacter()
	{
	}

	public void ButtonColour()
	{
	}

	public void ButtonColourReset()
	{
	}

	private void SetupCharacters()
	{
	}

	public void SetupCharacterColours()
	{
	}

	public void InputFieldChangedPlayerName()
	{
	}

	public void SetupPlayerName()
	{
	}

	public void LoadData()
	{
	}
}
