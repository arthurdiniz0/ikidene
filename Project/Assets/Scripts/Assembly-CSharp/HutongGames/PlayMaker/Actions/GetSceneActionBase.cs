using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneActionBase : FsmStateAction
	{
		public enum SceneAllReferenceOptions
		{
			ActiveScene = 0,
			SceneAtIndex = 1,
			SceneByName = 2,
			SceneByPath = 3,
			SceneByGameObject = 4,
		}

		public enum SceneSimpleReferenceOptions
		{
			SceneAtIndex = 0,
			SceneByName = 1,
		}

		public SceneAllReferenceOptions sceneReference;
		public FsmInt sceneAtIndex;
		public FsmString sceneByName;
		public FsmString sceneByPath;
		public FsmOwnerDefault sceneByGameObject;
		public FsmBool sceneFound;
		public FsmEvent sceneFoundEvent;
		public FsmEvent sceneNotFoundEvent;
	}
}
