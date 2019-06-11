using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCubeSpawner : MonoBehaviour {

    public GameObject cubePrefab;

    private int numPairs;

	// Use this for initialization
	void Start () {
        // numPairs = la variable numberOfCubePairs du MemoryGameManager

        for (int x = 0; x < numPairs * 2; x++)
        {
            Instantiate(cubePrefab, new Vector3(x * 2 - (2*numPairs - 1) , 0, 0), Quaternion.identity);
        }

	}
	
}
