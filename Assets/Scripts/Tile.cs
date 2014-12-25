using UnityEngine;
using System.Collections;

public class Tile {

	int index;

	public Tile(int index){
		this.index = index;
	}

	protected int Index
	{
		get{
			return this.index;
		}
	}
}
