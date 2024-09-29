using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class TacticalGroup : Action
	{
		public SharedGameObjectList targetGroup;
		public SharedString targetTag;
		public SharedFloat waitTime;
		public SharedBool independent;
	}
}
