using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class StopFSM : Action
	{
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
		public SharedString endEventName;
	}
}
