namespace Cinemachine
{
	public class CinemachineGroupComposer : CinemachineComposer
	{
		public enum FramingMode
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
		}

		public enum AdjustmentMode
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2,
		}

		public float m_GroupFramingSize;
		public FramingMode m_FramingMode;
		public float m_FrameDamping;
		public AdjustmentMode m_AdjustmentMode;
		public float m_MaxDollyIn;
		public float m_MaxDollyOut;
		public float m_MinimumDistance;
		public float m_MaximumDistance;
		public float m_MinimumFOV;
		public float m_MaximumFOV;
		public float m_MinimumOrthoSize;
		public float m_MaximumOrthoSize;
	}
}
