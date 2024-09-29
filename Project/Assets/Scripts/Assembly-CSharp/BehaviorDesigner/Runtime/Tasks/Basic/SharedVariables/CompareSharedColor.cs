using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedColor : Conditional
	{
		public SharedColor variable;
		public SharedColor compareTo;
	}
}
