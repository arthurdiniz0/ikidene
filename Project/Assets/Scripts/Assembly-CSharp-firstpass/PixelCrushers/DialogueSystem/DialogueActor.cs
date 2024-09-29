using UnityEngine;
using System;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueActor : MonoBehaviour
	{
		[Serializable]
		public class BarkUISettings
		{
			public AbstractBarkUI barkUI;
			public Vector3 barkUIOffset;
		}

		[Serializable]
		public class StandardDialogueUISettings
		{
			public SubtitlePanelNumber subtitlePanelNumber;
			public StandardUISubtitlePanel customSubtitlePanel;
			public MenuPanelNumber menuPanelNumber;
			public StandardUIMenuPanel customMenuPanel;
			public DialogueActor.UseMenuPanelFor useMenuPanelFor;
			public RuntimeAnimatorController portraitAnimatorController;
			public bool setSubtitleColor;
			public bool applyColorToPrependedName;
			public string prependActorNameSeparator;
			public Color subtitleColor;
		}

		public enum UseMenuPanelFor
		{
			OnlyMe = 0,
			MeAndResponsesToMe = 1,
		}

		public string actor;
		public string persistentDataName;
		public Texture2D portrait;
		public BarkUISettings barkUISettings;
		public StandardDialogueUISettings standardDialogueUISettings;
	}
}
