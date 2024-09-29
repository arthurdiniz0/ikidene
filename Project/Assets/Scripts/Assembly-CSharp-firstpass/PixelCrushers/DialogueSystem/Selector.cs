using UnityEngine;
using System;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class Selector : MonoBehaviour
	{
		[Serializable]
		public class Reticle
		{
			public Texture2D inRange;
			public Texture2D outOfRange;
			public float width;
			public float height;
		}

		public enum SelectAt
		{
			CenterOfScreen = 0,
			MousePosition = 1,
			CustomPosition = 2,
		}

		public enum DistanceFrom
		{
			Camera = 0,
			GameObject = 1,
		}

		public enum Dimension
		{
			In2D = 0,
			In3D = 1,
		}

		public SelectAt selectAt;
		public LayerMask layerMask;
		public DistanceFrom distanceFrom;
		public float maxSelectionDistance;
		public Dimension runRaycasts;
		public bool raycastAll;
		public bool useDefaultGUI;
		public GUISkin guiSkin;
		public string guiStyleName;
		public TextAnchor alignment;
		public TextStyle textStyle;
		public Color textStyleColor;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Reticle reticle;
		public KeyCode useKey;
		public string useButton;
		public string defaultUseMessage;
		public bool broadcastToChildren;
		public Transform actorTransform;
		public string tooFarMessage;
		public UsableUnityEvent onSelectedUsable;
		public UsableUnityEvent onDeselectedUsable;
		public UnityEvent tooFarEvent;
		public bool debug;
	}
}
