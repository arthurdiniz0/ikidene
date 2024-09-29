using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class SetSharedObject : Action
	{
		public SharedObject targetValue;
		public SharedObject targetVariable;
	}
}
