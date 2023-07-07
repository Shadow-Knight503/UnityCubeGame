using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI scoretxt;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (player.position.z.ToString("0") == "0") {
            scoretxt.text = "Press Arrow Icons to Start";
        } else {
            scoretxt.text = player.position.z.ToString("0");
        }
    }
}
