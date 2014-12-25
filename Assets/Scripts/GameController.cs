using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour {

	public GameHudScreen gameHUDScreen;
	public BasicGame basicGame;
	[System.NonSerialized]
	public GameState _state = GameState.Running;

	public static event Action OnGameStateChanged;

	public enum GameState{ Running = 0, Paused = 1, Over = 2, Tutorial = 3 }

	static GameController instance;
	public static GameController Instance {
		get {
			if(instance == null) {
				instance = FindObjectOfType(typeof(GameController)) as GameController;
			}
			return instance;
		}
	}
	
	void Awake() {
		if(instance == null) {
			instance = this;
		}
	}

	void Start()
	{
		GUIController.Instance.SetScreen (gameHUDScreen);
		StartGamePlay ();
	}

	void StartGamePlay()
	{
		basicGame.Create ();

		GUIController.Instance.InputEnabled = true;
	}

	public void PauseGame() {
		
		if (State == GameState.Running)
		{
			State = GameState.Paused;
		}

	}
	
	public void ResumeGame(bool onlyChangeScreen) {

		if(GUIController.Instance.currentScreen != gameHUDScreen) {
			GUIController.Instance.SetScreen(gameHUDScreen,true);
		}

		State = /*tutorialController.enabled ? GameState.Tutorial : */ GameState.Running;
	}
	
	public void Restart() {
		State = GameState.Over;
		StartGamePlay();
	}

	public GameState State
	{
		get{
			return _state;
		}
		set{
			_state = value;
			if(OnGameStateChanged != null)
				OnGameStateChanged();
		}
	}
}
