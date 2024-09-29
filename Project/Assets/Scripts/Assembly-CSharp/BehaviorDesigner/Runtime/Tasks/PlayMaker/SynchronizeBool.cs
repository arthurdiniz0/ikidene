using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class SynchronizeBool : Action
	{
		public SharedBool sharedVariable;
		public SharedBool toBehaviorDesigner;
		public SharedString FsmVariableName;
		public SharedBool isGlobalFsmVariable;
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
	}
}
