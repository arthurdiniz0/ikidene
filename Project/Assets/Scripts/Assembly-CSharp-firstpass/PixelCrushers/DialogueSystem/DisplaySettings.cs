using System;
using PixelCrushers;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DisplaySettings
	{
		[Serializable]
		public class LocalizationSettings
		{
			public string language;
			public bool useSystemLanguage;
			public TextTable textTable;
		}

		[Serializable]
		public class CameraSettings
		{
			public Camera sequencerCamera;
			public GameObject alternateCameraObject;
			public GameObject cameraAngles;
			public string defaultSequence;
			public string defaultPlayerSequence;
			public string defaultResponseMenuSequence;
			public EntrytagFormat entrytagFormat;
			public bool disableInternalSequencerCommands;
		}

		[Serializable]
		public class InputSettings
		{
			public bool alwaysForceResponseMenu;
			public bool includeInvalidEntries;
			public float responseTimeout;
			public ResponseTimeoutAction responseTimeoutAction;
			public EmTag emTagForOldResponses;
			public EmTag emTagForInvalidResponses;
			public string[] qteButtons;
			public InputTrigger cancel;
			public InputTrigger cancelConversation;
		}

		[Serializable]
		public class BarkSettings
		{
			public bool allowBarksDuringConversations;
			public float barkCharsPerSecond;
			public float minBarkSeconds;
		}

		[Serializable]
		public class AlertSettings
		{
			public bool allowAlertsDuringConversations;
			public float alertCheckFrequency;
			public float alertCharsPerSecond;
			public float minAlertSeconds;
		}

		[Serializable]
		public class SubtitleSettings
		{
			public enum ContinueButtonMode
			{
				Never = 0,
				Always = 1,
				Optional = 2,
				OptionalBeforeResponseMenu = 3,
				NotBeforeResponseMenu = 4,
				OptionalBeforePCAutoresponseOrMenu = 5,
				NotBeforePCAutoresponseOrMenu = 6,
				OptionalForPC = 7,
				NotForPC = 8,
				OptionalForPCOrBeforeResponseMenu = 9,
				NotForPCOrBeforeResponseMenu = 10,
				OptionalForPCOrBeforePCAutoresponseOrMenu = 11,
				NotForPCOrBeforePCAutoresponseOrMenu = 12,
			}

			public bool showNPCSubtitlesDuringLine;
			public bool showNPCSubtitlesWithResponses;
			public bool showPCSubtitlesDuringLine;
			public bool allowPCSubtitleReminders;
			public bool skipPCSubtitleAfterResponseMenu;
			public float subtitleCharsPerSecond;
			public float minSubtitleSeconds;
			public ContinueButtonMode continueButton;
			public bool richTextEmphases;
			public bool informSequenceStartAndEnd;
		}

		public ConversationOverrideDisplaySettings conversationOverrideSettings;
		public GameObject dialogueUI;
		public LocalizationSettings localizationSettings;
		public SubtitleSettings subtitleSettings;
		public CameraSettings cameraSettings;
		public InputSettings inputSettings;
		public BarkSettings barkSettings;
		public AlertSettings alertSettings;
	}
}
