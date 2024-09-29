using PixelCrushers;
using UnityEngine.UI;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIMenuPanel : UIPanel
	{
		public Graphic panel;
		public Image pcImage;
		public UITextField pcName;
		public Slider timerSlider;
		public ResponseButtonAlignment buttonAlignment;
		public bool showUnusedButtons;
		public StandardUIResponseButton[] buttons;
		public StandardUIResponseButton buttonTemplate;
		public Graphic buttonTemplateHolder;
		public Scrollbar buttonTemplateScrollbar;
		public UIScrollbarEnabler scrollbarEnabler;
		public float buttonTemplateScrollbarResetValue;
		public bool explicitNavigationForTemplateButtons;
		public bool loopExplicitNavigation;
		public UIAutonumberSettings autonumber;
		public UnityEvent onContentChanged;
		public string focusAnimationTrigger;
		public string unfocusAnimationTrigger;
		public UnityEvent onFocus;
		public UnityEvent onUnfocus;
	}
}
