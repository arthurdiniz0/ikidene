using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneProperties : GetSceneActionBase
	{
		public new FsmString name;
		public FsmString path;
		public FsmInt buildIndex;
		public FsmBool isValid;
		public FsmBool isLoaded;
		public FsmBool isDirty;
		public FsmInt rootCount;
		public FsmArray rootGameObjects;
		public bool everyFrame;
	}
}
