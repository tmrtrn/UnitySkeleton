using UnityEngine;
using System.Collections;

public abstract class GameScreen : MonoBehaviour {

	public enum ScreenType
	{
		PAUSE,
		GAMEHUD
	}

	public abstract ScreenType Type{get;}

	public bool hasTransition;

	public virtual void TransitionOut() {

	}

	public virtual void Hide()
	{

	}

	public virtual void Show()
	{

	}

	public virtual void TransitionIn()
	{

	}
}
