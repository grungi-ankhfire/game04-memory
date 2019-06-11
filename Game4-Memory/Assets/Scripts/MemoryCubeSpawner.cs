using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCubeSpawner : MonoBehaviour {

    public GameObject cubePrefab;

    private int numPairs;

	// Use this for initialization
	void Start () {
        numPairs = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MemoryGameManager>().numberOfCubePairs;

        List<MemoryCube> cubeList = new List<MemoryCube>();

        for (int x = 0; x < numPairs * 2; x++)
        {
            GameObject newGO = Instantiate(cubePrefab, new Vector3(x * 2 - (2*numPairs - 1) , 0, 0), Quaternion.identity);
            cubeList.Add(newGO.GetComponent<MemoryCube>());
        }

        for (int p = 0; p < numPairs; p++) {
            Color col = Random.ColorHSV(0, 1, 1, 1, 1, 1, 1, 1);
            for (int c = 0; c < 2; c++)
            {
                MemoryCube cube = cubeList[Random.Range(0, cubeList.Count)];
                cube.secondaryColor = col;
                cubeList.Remove(cube);
            }
        }

        // Autant de fois que de paires de cube :
        //      Générer une couleur : Color col = Random.ColorHSV(0, 1, 1, 1, 1, 1, 1, 1)
        //      2 fois :
        //          choisir un cube au hasard dans la liste
        //          lui mettre col comme secondaryColor
        //          retirer le cube de la liste
	}
	
}
