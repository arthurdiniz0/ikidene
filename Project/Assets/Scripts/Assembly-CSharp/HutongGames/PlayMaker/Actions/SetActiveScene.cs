using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class SetActiveScene : FsmStateAction
	{
		public enum SceneReferenceOptions
		{
			SceneAtBuildIndex = 0,
			SceneAtIndex = 1,
			SceneByName = 2,
			SceneByPath = 3,
			SceneByGameObject = 4,
		}

		public SceneReferenceOptions sceneReference;
		public FsmString sceneByName;
		public FsmInt sceneAtBuildIndex;
		public FsmInt sceneAtIndex;
		public FsmString sceneByPath;
		public FsmOwnerDefault sceneByGameObject;
		public FsmBool success;
		public FsmEvent successEvent;
		public FsmBool sceneFound;
		public FsmEvent sceneNotActivatedEvent;
		public FsmEvent sceneNotFoundEvent;
	}
}
