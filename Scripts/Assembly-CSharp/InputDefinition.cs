using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputDefinition : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct DefaultActions(InputDefinition wrapper)
	{
		private InputDefinition m_Wrapper = null;

		public InputAction Select => null;

		public InputAction Remove => null;

		public InputAction Undo => null;

		public InputAction Redo => null;

		public InputAction Group => null;

		public InputAction Ungroup => null;

		public InputAction Rotate => null;

		public InputAction Rotateleft => null;

		public InputAction Rotateright => null;

		public InputAction Rotation => null;

		public InputAction Cancel => null;

		public InputAction MenuLeft => null;

		public InputAction MenuRight => null;

		public InputAction MenuUp => null;

		public InputAction MenuDown => null;

		public InputAction MenuSelect => null;

		public InputAction Movement => null;

		public InputAction CameraZoom => null;

		public InputAction CameraRotation => null;

		public InputAction CameraPan => null;

		public InputAction CameraMovement => null;

		public InputAction CameraTarget => null;

		public InputAction CameraTargetRotation => null;

		public InputAction CameraTargetPan => null;

		public InputAction CameraToggle => null;

		public InputAction VirtualMouseMovement => null;

		public InputAction VirtualMouseLeft => null;

		public InputAction Confirm => null;

		public InputAction LayerUp => null;

		public InputAction LayerDown => null;

		public InputAction ModifierControl => null;

		public InputAction ModifierShift => null;

		public InputAction ColorsCopy => null;

		public InputAction ColorsPaste => null;

		public InputAction ObjectEnlarge => null;

		public InputAction ObjectShrink => null;

		public InputAction VerticalMovementUp => null;

		public InputAction VerticalMovementDown => null;

		public InputAction ToggleUI => null;

		public InputAction Hide => null;

		public InputAction UnhideAll => null;

		public InputAction Lock => null;

		public InputAction UnlockAll => null;

		public InputAction SelectionPrevious => null;

		public InputAction SelectionNext => null;

		public InputAction Gizmo => null;

		public InputAction Duplicate => null;

		public bool enabled => false;

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(DefaultActions set)
		{
			return null;
		}

		public void AddCallbacks(IDefaultActions instance)
		{
		}

		private void UnregisterCallbacks(IDefaultActions instance)
		{
		}

		public void RemoveCallbacks(IDefaultActions instance)
		{
		}

		public void SetCallbacks(IDefaultActions instance)
		{
		}
	}

	public interface IDefaultActions
	{
		void OnSelect(InputAction.CallbackContext context);

		void OnRemove(InputAction.CallbackContext context);

		void OnUndo(InputAction.CallbackContext context);

		void OnRedo(InputAction.CallbackContext context);

		void OnGroup(InputAction.CallbackContext context);

		void OnUngroup(InputAction.CallbackContext context);

		void OnRotate(InputAction.CallbackContext context);

		void OnRotateleft(InputAction.CallbackContext context);

		void OnRotateright(InputAction.CallbackContext context);

		void OnRotation(InputAction.CallbackContext context);

		void OnCancel(InputAction.CallbackContext context);

		void OnMenuLeft(InputAction.CallbackContext context);

		void OnMenuRight(InputAction.CallbackContext context);

		void OnMenuUp(InputAction.CallbackContext context);

		void OnMenuDown(InputAction.CallbackContext context);

		void OnMenuSelect(InputAction.CallbackContext context);

		void OnMovement(InputAction.CallbackContext context);

		void OnCameraZoom(InputAction.CallbackContext context);

		void OnCameraRotation(InputAction.CallbackContext context);

		void OnCameraPan(InputAction.CallbackContext context);

		void OnCameraMovement(InputAction.CallbackContext context);

		void OnCameraTarget(InputAction.CallbackContext context);

		void OnCameraTargetRotation(InputAction.CallbackContext context);

		void OnCameraTargetPan(InputAction.CallbackContext context);

		void OnCameraToggle(InputAction.CallbackContext context);

		void OnVirtualMouseMovement(InputAction.CallbackContext context);

		void OnVirtualMouseLeft(InputAction.CallbackContext context);

		void OnConfirm(InputAction.CallbackContext context);

		void OnLayerUp(InputAction.CallbackContext context);

		void OnLayerDown(InputAction.CallbackContext context);

		void OnModifierControl(InputAction.CallbackContext context);

		void OnModifierShift(InputAction.CallbackContext context);

		void OnColorsCopy(InputAction.CallbackContext context);

		void OnColorsPaste(InputAction.CallbackContext context);

		void OnObjectEnlarge(InputAction.CallbackContext context);

		void OnObjectShrink(InputAction.CallbackContext context);

		void OnVerticalMovementUp(InputAction.CallbackContext context);

		void OnVerticalMovementDown(InputAction.CallbackContext context);

		void OnToggleUI(InputAction.CallbackContext context);

		void OnHide(InputAction.CallbackContext context);

		void OnUnhideAll(InputAction.CallbackContext context);

		void OnLock(InputAction.CallbackContext context);

		void OnUnlockAll(InputAction.CallbackContext context);

		void OnSelectionPrevious(InputAction.CallbackContext context);

		void OnSelectionNext(InputAction.CallbackContext context);

		void OnGizmo(InputAction.CallbackContext context);

		void OnDuplicate(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_Default;

	private List<IDefaultActions> m_DefaultActionsCallbackInterfaces;

	private readonly InputAction m_Default_Select;

	private readonly InputAction m_Default_Remove;

	private readonly InputAction m_Default_Undo;

	private readonly InputAction m_Default_Redo;

	private readonly InputAction m_Default_Group;

	private readonly InputAction m_Default_Ungroup;

	private readonly InputAction m_Default_Rotate;

	private readonly InputAction m_Default_Rotateleft;

	private readonly InputAction m_Default_Rotateright;

	private readonly InputAction m_Default_Rotation;

	private readonly InputAction m_Default_Cancel;

	private readonly InputAction m_Default_MenuLeft;

	private readonly InputAction m_Default_MenuRight;

	private readonly InputAction m_Default_MenuUp;

	private readonly InputAction m_Default_MenuDown;

	private readonly InputAction m_Default_MenuSelect;

	private readonly InputAction m_Default_Movement;

	private readonly InputAction m_Default_CameraZoom;

	private readonly InputAction m_Default_CameraRotation;

	private readonly InputAction m_Default_CameraPan;

	private readonly InputAction m_Default_CameraMovement;

	private readonly InputAction m_Default_CameraTarget;

	private readonly InputAction m_Default_CameraTargetRotation;

	private readonly InputAction m_Default_CameraTargetPan;

	private readonly InputAction m_Default_CameraToggle;

	private readonly InputAction m_Default_VirtualMouseMovement;

	private readonly InputAction m_Default_VirtualMouseLeft;

	private readonly InputAction m_Default_Confirm;

	private readonly InputAction m_Default_LayerUp;

	private readonly InputAction m_Default_LayerDown;

	private readonly InputAction m_Default_ModifierControl;

	private readonly InputAction m_Default_ModifierShift;

	private readonly InputAction m_Default_ColorsCopy;

	private readonly InputAction m_Default_ColorsPaste;

	private readonly InputAction m_Default_ObjectEnlarge;

	private readonly InputAction m_Default_ObjectShrink;

	private readonly InputAction m_Default_VerticalMovementUp;

	private readonly InputAction m_Default_VerticalMovementDown;

	private readonly InputAction m_Default_ToggleUI;

	private readonly InputAction m_Default_Hide;

	private readonly InputAction m_Default_UnhideAll;

	private readonly InputAction m_Default_Lock;

	private readonly InputAction m_Default_UnlockAll;

	private readonly InputAction m_Default_SelectionPrevious;

	private readonly InputAction m_Default_SelectionNext;

	private readonly InputAction m_Default_Gizmo;

	private readonly InputAction m_Default_Duplicate;

	private int m_KeyboardMouseSchemeIndex;

	private int m_GamepadSchemeIndex;

	public InputActionAsset asset { get; }

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default;

	public IEnumerable<InputBinding> bindings => null;

	public DefaultActions Default => default;

	public InputControlScheme KeyboardMouseScheme => default;

	public InputControlScheme GamepadScheme => default;

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
