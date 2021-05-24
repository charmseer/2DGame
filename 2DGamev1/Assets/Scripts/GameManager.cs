using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject GameOverUI;
    public void EndGame()
    {
        
        Debug.Log("Game Over");
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverUI.SetActive(true);
            Invoke("Restart", 3);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
