using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuIII : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void QuitGame() {
        Debug.Log("Oyundan Çıktık!");
        Application.Quit();
    }
    public void ReturnToMainMenu() {
        Debug.Log("ReturnToMainMenu called");
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Scene loading initiated");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene"); //Ana oyun sahnesinin ismi yazılacak
    }
}
   
