using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class MergeScenes : FsmStateAction
	{
		public GetSceneActionBase.SceneAllReferenceOptions sourceReference;
		public FsmInt sourceAtIndex;
		public FsmString sourceByName;
		public FsmString sourceByPath;
		public FsmOwnerDefault sourceByGameObject;
		public GetSceneActionBase.SceneAllReferenceOptions destinationReference;
		public FsmInt destinationAtIndex;
		public FsmString destinationByName;
		public FsmString destinationByPath;
		public FsmOwnerDefault destinationByGameObject;
		public FsmBool success;
		public FsmEvent successEvent;
		public FsmEvent failureEvent;
	}
}
