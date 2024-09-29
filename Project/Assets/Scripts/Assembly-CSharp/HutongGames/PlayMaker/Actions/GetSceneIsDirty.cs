using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneIsDirty : GetSceneActionBase
	{
		public FsmBool isDirty;
		public FsmEvent isDirtyEvent;
		public FsmEvent isNotDirtyEvent;
		public bool everyFrame;
	}
}
