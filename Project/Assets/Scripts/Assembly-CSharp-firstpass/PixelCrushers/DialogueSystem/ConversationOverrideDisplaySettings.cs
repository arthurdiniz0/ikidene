using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class ConversationOverrideDisplaySettings
	{
		public bool useOverrides;
		public bool overrideSubtitleSettings;
		public bool showNPCSubtitlesDuringLine;
		public bool showNPCSubtitlesWithResponses;
		public bool showPCSubtitlesDuringLine;
		public bool skipPCSubtitleAfterResponseMenu;
		public float subtitleCharsPerSecond;
		public float minSubtitleSeconds;
		public DisplaySettings.SubtitleSettings.ContinueButtonMode continueButton;
		public bool overrideSequenceSettings;
		public string defaultSequence;
		public string defaultPlayerSequence;
		public string defaultResponseMenuSequence;
		public bool overrideInputSettings;
		public bool alwaysForceResponseMenu;
		public bool includeInvalidEntries;
		public float responseTimeout;
	}
}
