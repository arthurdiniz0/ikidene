using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class RunConditionalFSM : Conditional
	{
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
		public SharedString eventName;
	}
}
