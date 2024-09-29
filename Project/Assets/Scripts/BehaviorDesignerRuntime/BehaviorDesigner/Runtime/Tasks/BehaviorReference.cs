using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class BehaviorReference : Action
	{
		public ExternalBehavior[] externalBehaviors;
		public SharedNamedVariable[] variables;
		public bool collapsed;
	}
}
