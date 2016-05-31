using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    Text text;
    private Controls player;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();

    }
	
	void Update () {
        text.text = "Crystals: " + player.crystals + " / 41";


    }
}
