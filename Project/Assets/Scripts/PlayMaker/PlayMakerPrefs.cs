using UnityEngine;

public class PlayMakerPrefs : ScriptableObject
{
	[SerializeField]
	private bool logPerformanceWarnings;
	[SerializeField]
	private bool showEventHandlerComponents;
	[SerializeField]
	private Color[] colors;
	[SerializeField]
	private string[] colorNames;
	[SerializeField]
	private Color tweenFromColor;
	[SerializeField]
	private Color tweenToColor;
}
