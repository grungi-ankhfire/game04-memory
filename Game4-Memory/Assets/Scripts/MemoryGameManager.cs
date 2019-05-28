using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGameManager : MonoBehaviour {

    public MemoryCube[] cubes;

    public MemoryCube firstCube = null;
    public MemoryCube secondCube;

	// Use this for initialization
	void Start () {
		foreach(MemoryCube cube in cubes) {
            cube.manager = this;
        }
	}
    
    IEnumerator CompareCubesDelayed() {
        yield return new WaitForSeconds(2f);

        if (firstCube.secondaryColor == secondCube.secondaryColor) {
            Destroy(firstCube.gameObject);
            Destroy(secondCube.gameObject);
        } else {
            firstCube.Hide();
            secondCube.Hide();
        }
        firstCube = null;
        secondCube = null;
    }

    public void CubeClicked(MemoryCube cube) {
        if (firstCube == null) {
            cube.Reveal();
            firstCube = cube;
        } else if (cube != firstCube && secondCube == null){
            cube.Reveal();
            secondCube = cube;
            StartCoroutine(CompareCubesDelayed());
        }

    }

}
