using System;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIDialogueControls : AbstractDialogueUIControls
	{
		public UIPanel mainPanel;
		public StandardUISubtitlePanel[] subtitlePanels;
		public StandardUISubtitlePanel defaultNPCSubtitlePanel;
		public StandardUISubtitlePanel defaultPCSubtitlePanel;
		public bool allowOpenSubtitlePanelsOnStartConversation;
		public StandardUIMenuPanel[] menuPanels;
		public StandardUIMenuPanel defaultMenuPanel;
	}
}
