using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

    public Rigidbody Rb;
    public float ForwardForce = 2000f;
    public float SideForce = 500f;
    bool IsRunning = false;
    public GameManager gamemanager;

    void Test() {
        Debug.Log("Works");
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (IsRunning) {
            Rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }
        if (gamemanager.Right){
            IsRunning = true;
            Rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (gamemanager.Left){
            IsRunning = true;
            Rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
