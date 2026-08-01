using System;
using System.Collections;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/JoyStick")]
public class JoyStick : MonoBehaviour
{
	public delegate void OnJoystickStart();

	public delegate void OnJoystickDrag(Vector2 v);

	public delegate void OnJoystickFinish();

	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public float joyStickPosX;

	public float joyStickPosY;

	private float posDivision = 1f;

	public Transform target;

	public Transform mbackground;

	private Vector3 scale = Vector3.one;

	public float scrollWheelFactor;

	public bool restrictWithinPanel;

	public float ClampRadius = 50f;

	private bool isHidingJoystick;

	private Vector3 center;

	private Plane mPlane;

	private Vector3 mLastPos;

	private UIPanel mPanel;

	private bool mPressed;

	private Vector3 mMomentum;

	private float mScroll;

	private Bounds mBounds;

	private Vector3 targetPosition;

	public float strength = 1f;

	public bool ignoreTimeScale;

	private float mThreshold;

	public event OnJoystickStart onStartDelegate;

	public event OnJoystickDrag onDragDelegate;

	public event OnJoystickFinish onFinishDelegate;

	private void Awake()
	{
		if (target == null)
		{
			target = transform;
		}
		center = target.localPosition;
		targetPosition = center;
	}

	public void SetEnableJoystick(bool enable)
	{
		isHidingJoystick = !enable;
		NGUITools.SetActive(gameObject, enable);
	}

	private void FindPanel()
	{
		if (mPanel == null)
		{
			mPanel = NGUITools.FindInParents<UIPanel>(gameObject);
		}
	}

	private void OnHover(bool Hover)
	{
	}

	public void OnPress(bool pressed)
	{
		mPressed = pressed;

		if (pressed)
		{
			FindPanel();
			targetPosition = (target != null) ? target.localPosition : center;
			if (onStartDelegate != null)
			{
				onStartDelegate();
			}
		}
		else
		{
			if (onFinishDelegate != null)
			{
				onFinishDelegate();
			}
			StopAllCoroutines();
			StartCoroutine(SpringPositionUpdate());
		}
	}

	public void EnableWithPosition(Vector3 position)
	{
		if (mbackground != null)
		{
			mbackground.position = position;
		}
		else
		{
			transform.position = position;
		}
		targetPosition = center;
		if (target != null)
		{
			target.localPosition = center;
		}
		SetEnableJoystick(true);
	}

	private void OnDrag(Vector2 delta)
	{
		if (!mPressed)
		{
			return;
		}

		targetPosition.x += delta.x / posDivision;
		targetPosition.y += delta.y / posDivision;

		Vector3 offset = targetPosition - center;
		if (offset.magnitude > ClampRadius)
		{
			offset = offset.normalized * ClampRadius;
			targetPosition = center + offset;
		}

		if (target != null)
		{
			target.localPosition = targetPosition;
		}

		Vector2 normalized = (ClampRadius > 0f) ? new Vector2(offset.x, offset.y) / ClampRadius : Vector2.zero;
		if (onDragDelegate != null)
		{
			onDragDelegate(normalized);
		}
	}

	private void LateUpdate()
	{
	}

	private void OnScroll(float delta)
	{
		mScroll += delta * scrollWheelFactor;
	}

	private IEnumerator SpringPositionUpdate()
	{
		float duration = 0.15f;
		float elapsed = 0f;
		Vector3 start = targetPosition;

		while (elapsed < duration)
		{
			elapsed += ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / duration);
			targetPosition = Vector3.Lerp(start, center, t);

			if (target != null)
			{
				target.localPosition = targetPosition;
			}

			Vector3 offset = targetPosition - center;
			Vector2 normalized = (ClampRadius > 0f) ? new Vector2(offset.x, offset.y) / ClampRadius : Vector2.zero;
			if (onDragDelegate != null)
			{
				onDragDelegate(normalized);
			}

			yield return null;
		}

		targetPosition = center;
		if (target != null)
		{
			target.localPosition = center;
		}
		if (onDragDelegate != null)
		{
			onDragDelegate(Vector2.zero);
		}
	}
}
