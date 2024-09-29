namespace Cinemachine
{
	public class CinemachineFramingTransposer : CinemachineComponentBase
	{
		public enum FramingMode
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3,
		}

		public enum AdjustmentMode
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2,
		}

		public float m_LookaheadTime;
		public float m_LookaheadSmoothing;
		public bool m_LookaheadIgnoreY;
		public float m_XDamping;
		public float m_YDamping;
		public float m_ZDamping;
		public float m_ScreenX;
		public float m_ScreenY;
		public float m_CameraDistance;
		public float m_DeadZoneWidth;
		public float m_DeadZoneHeight;
		public float m_DeadZoneDepth;
		public bool m_UnlimitedSoftZone;
		public float m_SoftZoneWidth;
		public float m_SoftZoneHeight;
		public float m_BiasX;
		public float m_BiasY;
		public FramingMode m_GroupFramingMode;
		public AdjustmentMode m_AdjustmentMode;
		public float m_GroupFramingSize;
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
