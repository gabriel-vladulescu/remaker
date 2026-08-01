using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Interaction/Envelop Content")]
public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	public bool ignoreDisabled;

	private bool mStarted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[ContextMenu("Execute")]
	public void Execute()
	{
	}
}
