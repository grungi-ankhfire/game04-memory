using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCube : MonoBehaviour {

    public Color baseColor;
    public Color secondaryColor;
    public MemoryGameManager manager;

    private Renderer render;

    // Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MemoryGameManager>();
        render = GetComponent<Renderer>();
        render.material.color = baseColor;
    }

    public void Reveal() {
        render.material.color = secondaryColor;
    }

    public void Hide() {
        render.material.color = baseColor;
    }

    private void OnMouseDown() {
        manager.CubeClicked(this);
    }

}
