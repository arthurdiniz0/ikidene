using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedGameObject : Conditional
	{
		public SharedGameObject variable;
		public SharedGameObject compareTo;
	}
}
