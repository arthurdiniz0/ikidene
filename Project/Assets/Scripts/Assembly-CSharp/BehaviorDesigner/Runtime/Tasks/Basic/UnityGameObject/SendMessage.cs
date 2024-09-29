using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class SendMessage : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString message;
		public SharedGenericVariable value;
	}
}
