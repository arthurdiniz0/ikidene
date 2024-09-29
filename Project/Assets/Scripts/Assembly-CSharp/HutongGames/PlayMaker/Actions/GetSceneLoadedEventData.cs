using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneLoadedEventData : FsmStateAction
	{
		public FsmEnum loadedMode;
		public new FsmString name;
		public FsmString path;
		public FsmBool isValid;
		public FsmInt buildIndex;
		public FsmBool isLoaded;
		public FsmBool isDirty;
		public FsmInt rootCount;
		public FsmArray rootGameObjects;
	}
}
