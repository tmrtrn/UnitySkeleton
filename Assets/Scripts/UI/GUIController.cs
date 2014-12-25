using UnityEngine;
using System.Collections;

public class GUIController : MonoBehaviour {

	bool inputEnabled = true;


	public bool InputEnabled {
		get{
			return inputEnabled;
		}
		set{
			inputEnabled = value;
		}
	}

	[System.NonSerialized] public GameScreen currentScreen;
	[System.NonSerialized] public GameScreen previousScreen;

	static GUIController instance;

	public static GUIController Instance{
		get{
			if(instance == null){
				instance = FindObjectOfType(typeof(GUIController)) as GUIController;
				if(instance == null)
					instance = new GameObject("GUIController").AddComponent<GUIController>();
			}
			return instance;
		}
	}

	Camera m_GUICamera;

	public Camera GUICamera {
		get {
			if(m_GUICamera == null) {
				m_GUICamera = GameObject.FindWithTag("GUICamera").camera;
			}
			return m_GUICamera;
		}
	}

	void Awake()
	{
		if (instance == null) {
			instance = this;
		} 
		else if (instance != this) {
			Destroy(gameObject);
			return;
		}
	}

	void OnDestroy(){
		if (instance == this) {
			instance = null;
		}
	}

	public void SetScreen(GameScreen newScreen){
		SetScreen (newScreen, true);
	}

	public void SetScreen(GameScreen newScreen, bool doTransitions){
		AnimateGoToScreen (newScreen, doTransitions);
	}

	void AnimateGoToScreen(GameScreen newScreen, bool doTransitions){
		InputEnabled = false;

		if(currentScreen != null){
			if(currentScreen.hasTransition && doTransitions) {
				currentScreen.TransitionOut();
			}
			else {
				currentScreen.Hide();
			}
		}

		previousScreen = currentScreen;
		currentScreen = newScreen;

		if (currentScreen != null) {
			if(currentScreen.hasTransition && doTransitions) {
				currentScreen.TransitionIn();
			}
			else {
				currentScreen.Show();
			}
		}

		InputEnabled = true;
	}
















	


}
