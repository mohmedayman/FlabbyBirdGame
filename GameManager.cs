using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameObject GameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
