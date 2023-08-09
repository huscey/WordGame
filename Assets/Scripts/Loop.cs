using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loop : MonoBehaviour
{
    private float rotZ;
    public float RotationSpeed;
    public bool Rotation;

    public GameObject panelOne;
    public GameObject panelTwo;
    public GameObject panelThree;
    public GameObject panelFour;
    public GameObject panelFive;

    public GameObject pauseMenu;
    private void Update()
    {
        if (Rotation == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (pauseMenu == false)
        {
            Time.timeScale = 1;
        }

    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void MenuStart()
    {
        SceneManager.LoadScene(2);
    }

    public void MenuQuit()
    {
        Application.Quit();
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenuLevel()
    {
        SceneManager.LoadScene(0);
    }

    private int currentSceneIndex;
    public void MainMenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene(0);
    }
    private int sceneToContinue;
    public void MainContinue()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        }
        else
            return;
    }
    private int currentSceneIndexTwo;
    public void MainMenuTwo()
    {
        currentSceneIndexTwo = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedSceneTwo", currentSceneIndexTwo);
        SceneManager.LoadScene(0);
    }
    private int sceneToContinueTwo;
    public void MainContinueTwo()
    {
        sceneToContinueTwo = PlayerPrefs.GetInt("SavedSceneTwo");

        if (sceneToContinueTwo != 0)
        {
            SceneManager.LoadScene(sceneToContinueTwo);
        }
        else
            return;
    }
    private int currentSceneIndexThree;
    public void MainMenuThree()
    {
        currentSceneIndexThree = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedSceneThree", currentSceneIndexThree);
        SceneManager.LoadScene(0);
    }
    private int sceneToContinueThree;
    public void MainContinueThree()
    {
        sceneToContinueThree = PlayerPrefs.GetInt("SavedSceneThree");

        if (sceneToContinueThree != 0)
        {
            SceneManager.LoadScene(sceneToContinueThree);
        }
        else
            return;
    }

    public void DeleteSaving()
    {
        PlayerPrefs.DeleteAll();
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void nextLevelFour()
    {
        SceneManager.LoadScene(4);
    }
    public void nextLevelFive()
    {
        SceneManager.LoadScene(5);
    }
    public void nextLevelSix()
    {
        SceneManager.LoadScene(6);
    }
    public void goLevels()
    {
        SceneManager.LoadScene(1);
    }
    public GameObject gameFinish;
    public void goFinishGame()
    {
        gameFinish.SetActive(true);
    }
    public void aOneGame()
    {
        SceneManager.LoadScene(7);
    }

    public void aTwoGame()
    {
        SceneManager.LoadScene(8);
    }

    public void PastLevelOne()
    {
        panelOne.SetActive(false);
        panelTwo.SetActive(true);
    }
    public void PastLevelTwo()
    {
        panelTwo.SetActive(false);
        panelThree.SetActive(true);
    }
    public void PastLevelThree()
    {
        panelThree.SetActive(false);
        panelFour.SetActive(true);
    }
    public void PastLevelFour()
    {
        panelFour.SetActive(false);
        panelFive.SetActive(true);
    }
    public void BackLevelTwo()
    {       
        panelTwo.SetActive(false);
        panelOne.SetActive(true);
    }
    public void BackLevelThree()
    {
        panelThree.SetActive(false);
        panelTwo.SetActive(true);
    }
    public void BackLevelFour()
    {       
        panelFour.SetActive(false);
        panelThree.SetActive(true);
    }
    public void BackLevelFive()
    {       
        panelFive.SetActive(false);
        panelFour.SetActive(true);
    }

}
