using BehaviorDesigner.Runtime.Tasks;

namespace BehaviorDesigner.Runtime.ObjectDrawers
{
	public class IntSliderAttribute : ObjectDrawerAttribute
	{
		public IntSliderAttribute(int min, int max)
		{
		}

		public int min;
		public int max;
	}
}
