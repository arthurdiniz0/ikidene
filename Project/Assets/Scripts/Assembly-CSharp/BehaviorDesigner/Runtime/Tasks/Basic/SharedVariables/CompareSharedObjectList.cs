using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedObjectList : Conditional
	{
		public SharedObjectList variable;
		public SharedObjectList compareTo;
	}
}
