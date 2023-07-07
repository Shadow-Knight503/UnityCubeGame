using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public Player_Move movement;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnCollisionEnter (UnityEngine.Collision CollisionInfo) {
        
        if (CollisionInfo.gameObject.tag == "Obstacles") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
