using BehaviorDesigner.Runtime.Tasks;

namespace BehaviorDesigner.Runtime.ObjectDrawers
{
	public class FloatSliderAttribute : ObjectDrawerAttribute
	{
		public FloatSliderAttribute(float min, float max)
		{
		}

		public float min;
		public float max;
	}
}
