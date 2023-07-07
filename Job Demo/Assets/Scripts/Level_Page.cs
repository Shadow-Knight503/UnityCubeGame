using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Page : MonoBehaviour {

    public void LevelLoad(int Lvl_Build) {
        SceneManager.LoadScene(Lvl_Build + 2);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
