using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class StartFSM : Action
	{
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
		public SharedString startEventName;
		public SharedString pauseEventName;
		public SharedString resumeEventName;
		public SharedString endEventName;
		public SharedBool waitForFSMCompletion;
		public SharedBool resetOnComplete;
		public SharedBool synchronizeVariables;
		public SharedBool synchronizeGlobalVariables;
	}
}
