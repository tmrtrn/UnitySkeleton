using UnityEngine;
using System.Collections;

public class GameHudScreen : GameScreen {


	public override ScreenType Type {
		get {
			return ScreenType.GAMEHUD;
		}
	}

	public override void TransitionIn ()
	{
		base.TransitionIn ();
	}

	public override void TransitionOut ()
	{
		base.TransitionOut ();
	}

	public override void Show ()
	{
		base.Show ();
	}

	public override void Hide ()
	{
		base.Hide ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
