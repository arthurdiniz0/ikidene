using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class SynchronizeString : Action
	{
		public SharedString sharedVariable;
		public SharedBool toBehaviorDesigner;
		public SharedString FsmVariableName;
		public SharedBool isGlobalFsmVariable;
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
	}
}
