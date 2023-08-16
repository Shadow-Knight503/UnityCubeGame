using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LevelName : MonoBehaviour {

    public TextMeshProUGUI LvlTxt;
    // Start is called before the first frame update
    void Start() {
        LvlTxt.text = "Level: " + (SceneManager.GetActiveScene().buildIndex - 2).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
