using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class FloatClamp : Action
	{
		public SharedFloat floatVariable;
		public SharedFloat minValue;
		public SharedFloat maxValue;
	}
}
