using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedInt : Conditional
	{
		public SharedInt variable;
		public SharedInt compareTo;
	}
}
