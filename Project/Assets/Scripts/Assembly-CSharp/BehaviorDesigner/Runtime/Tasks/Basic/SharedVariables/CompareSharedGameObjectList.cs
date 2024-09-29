using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedGameObjectList : Conditional
	{
		public SharedGameObjectList variable;
		public SharedGameObjectList compareTo;
	}
}
