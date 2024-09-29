using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedString : Conditional
	{
		public SharedString variable;
		public SharedString compareTo;
	}
}
