using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class SetSharedGameObject : Action
	{
		public SharedGameObject targetValue;
		public SharedGameObject targetVariable;
		public SharedBool valueCanBeNull;
	}
}
