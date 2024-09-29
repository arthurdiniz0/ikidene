using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneIsLoaded : GetSceneActionBase
	{
		public FsmBool isLoaded;
		public FsmEvent isLoadedEvent;
		public FsmEvent isNotLoadedEvent;
		public bool everyFrame;
	}
}
