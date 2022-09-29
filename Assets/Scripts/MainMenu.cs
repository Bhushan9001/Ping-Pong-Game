using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
   public void SinglePlayer(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
    public void DoublePlayer(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
   public void QuitGame(){
      
      Application.Quit();
   }
}
