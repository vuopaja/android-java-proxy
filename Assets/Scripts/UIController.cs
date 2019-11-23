using UnityEngine;

public class UIController : MonoBehaviour
{
	UnityEngine.UI.Text text;
	JavaBridge javaBridge;

	void Start ()
	{
		// Create a new JavaBridge and register to callback event
		javaBridge = new JavaBridge();
		javaBridge.GotJavaCallback += onJavaCallback;

		// Setup UI
		text = GetComponentInChildren<UnityEngine.UI.Text>();
		var button = GetComponentInChildren<UnityEngine.UI.Button>();
		button.onClick.AddListener(onUiButtonClicked);
	}
	
	void onUiButtonClicked()
	{
		javaBridge.CallJavaMethod();
	}

	void onJavaCallback(int result)
	{
		text.text = result.ToString();
	}
}
