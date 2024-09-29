using HutongGames.PlayMaker;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SetDialogueActorPanel : FsmStateAction
	{
		public FsmGameObject dialogueActor;
		public SubtitlePanelNumber subtitlePanelNumber;
		public FsmGameObject customPanel;
	}
}
