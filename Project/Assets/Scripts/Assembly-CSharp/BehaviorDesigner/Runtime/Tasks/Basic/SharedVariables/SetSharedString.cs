using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class SetSharedString : Action
	{
		public SharedString targetValue;
		public SharedString targetVariable;
	}
}
