using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class IntClamp : Action
	{
		public SharedInt intVariable;
		public SharedInt minValue;
		public SharedInt maxValue;
	}
}
