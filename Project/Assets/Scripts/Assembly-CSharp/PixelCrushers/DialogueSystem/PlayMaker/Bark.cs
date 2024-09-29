using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class Bark : FsmStateAction
	{
		public FsmString conversation;
		public FsmGameObject speaker;
		public FsmGameObject listener;
	}
}
