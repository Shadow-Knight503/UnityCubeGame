using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool IsGameOver = false;
    public float RestartDelay = 1f;
    public GameObject CompleteLvlUI;
    public bool Right = false;
    public bool Left = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelComplete () {
        CompleteLvlUI.SetActive(true);
    }

    public void EndGame() {
        if (!IsGameOver) {
            Invoke("Restart", RestartDelay);
            IsGameOver = true;
        }
    }

    void Restart () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoRight() {
        Right = true;
    }
    public void StopRight() {
        Right = false;
    }
    public void GoLeft() {
        Left = true;
    }
    public void StopLeft() {
        Left = false;
    }
}
