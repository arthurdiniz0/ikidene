using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityBehaviour
{
	public class SetIsEnabled : Action
	{
		public SharedObject specifiedObject;
		public SharedBool enabled;
	}
}
