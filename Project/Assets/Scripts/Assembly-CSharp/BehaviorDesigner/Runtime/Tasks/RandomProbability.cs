using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class RandomProbability : Conditional
	{
		public SharedFloat successProbability;
		public SharedInt seed;
		public SharedBool useSeed;
	}
}
