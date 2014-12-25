using UnityEngine;
using System.Collections;

public class BasicGame : MonoBehaviour {

	public int rowCount;
	public int columnCount;

	int[][] matrix;
	Tile[][] tiles;

	void Start () {
	
	}

	public void Create()
	{
		InitMatrix ();
	}

	void InitMatrix()
	{
		matrix = new int[rowCount][];
		tiles = new Tile[rowCount][];

		for (int i = 0; i < matrix.Length; i++) {
			matrix[i] = new int[columnCount];
			tiles [i] = new Tile[columnCount];
			for (int j = 0; j < matrix[i].Length; j++) {
				int tileNumber = (i*matrix[i].Length)+j;
				matrix[i][j] = tileNumber;

				tiles[i][j] = new Tile(tileNumber);

			}
		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
