using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void goToStage2()
    {
        SceneManager.LoadScene("Fase2");
    }
    public void goToStage3()
    {
        SceneManager.LoadScene("Fase3");
    }
    public void goToStageSELECT()
    {
        SceneManager.LoadScene("SelectStage");
    }
}
