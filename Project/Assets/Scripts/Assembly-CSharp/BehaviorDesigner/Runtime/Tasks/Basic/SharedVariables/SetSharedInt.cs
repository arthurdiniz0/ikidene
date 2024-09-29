using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class SetSharedInt : Action
	{
		public SharedInt targetValue;
		public SharedInt targetVariable;
	}
}
