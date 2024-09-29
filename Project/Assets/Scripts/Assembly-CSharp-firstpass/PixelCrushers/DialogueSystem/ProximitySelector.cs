using UnityEngine;
using PixelCrushers.DialogueSystem.UnityGUI;

namespace PixelCrushers.DialogueSystem
{
	public class ProximitySelector : MonoBehaviour
	{
		public bool useDefaultGUI;
		public GUISkin guiSkin;
		public string guiStyleName;
		public TextAnchor alignment;
		public Color color;
		public TextStyle textStyle;
		public Color textStyleColor;
		public string defaultUseMessage;
		public KeyCode useKey;
		public string useButton;
		public bool enableTouch;
		public ScaledRect touchArea;
		public bool broadcastToChildren;
		public Transform actorTransform;
		public UsableUnityEvent onSelectedUsable;
		public UsableUnityEvent onDeselectedUsable;
	}
}
