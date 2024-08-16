using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameIsHasEnd = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    public void completeLevel()
    {
        Debug.Log("LEVEN WON");
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (gameIsHasEnd == false)
        {
            gameIsHasEnd = true;
            Debug.Log("GAME OVER");
            Invoke("restart",restartDelay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
