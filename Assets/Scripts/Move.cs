using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class Move : MonoBehaviour
{
    
    GameObject currentPoint;
    public GameObject[] words;
    public GameObject[] buttons;    
    public GameObject word;
    public GameObject CanvasChange;
    int index;
    public GameObject canvasOne;
    public GameObject canvasTwo;
    public GameObject canvasThree;
    public GameObject canvasFour;
    public GameObject canvasFive;
    public GameObject canvasSix;
    public GameObject canvasSeven;
    public GameObject canvasEight;
    public GameObject samescore;
    public GameObject Timer;
    public GameObject pauseButton;
    public GameObject pauseMenu;
    public GameObject gameoverPanel;
    public int gameoverTime;
    public bool comp = true;
    Timer timer;
    void Start()
    {
        
        StartCoroutine(GameOver());
    }

    void Update()
    { 
        if (GameObject.FindGameObjectWithTag("Currect") == true)
        {
            StartCoroutine(NextOne());
        }
    }

    public IEnumerator GameOver()
    {
        while (comp == true)
        {
            yield return new WaitForSeconds(1f);
            gameoverTime--;
            
            if (gameoverTime == 0)
            {
                gameoverPanel.SetActive(true);
                Time.timeScale = 0;
                //gameoverPanel.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    public void DeletedSaves()
    {
        PlayerPrefs.DeleteAll();
    }

    IEnumerator NextOne()
    {              
        yield return new WaitForSeconds(3f);
        


    }
    public void CanvasChangeButton()
    {
        canvasOne.SetActive(false);
        canvasTwo.SetActive(true);      
        if (canvasTwo == true)
        {
            
            //samescore.transform.parent = canvasTwo.transform;
            Timer.transform.parent = canvasTwo.transform;
            pauseButton.transform.parent = canvasTwo.transform;
            pauseMenu.transform.parent = canvasTwo.transform;
            gameoverPanel.transform.parent = canvasTwo.transform;
        }       
    }   
    public void CanvasChangeButtonTwo()
    {
        canvasTwo.SetActive(false);
        canvasThree.SetActive(true);
        if (canvasThree == true)
        {
            
            //samescore.transform.parent = canvasThree.transform;
            Timer.transform.parent = canvasThree.transform;
            pauseButton.transform.parent = canvasThree.transform;
            pauseMenu.transform.parent = canvasThree.transform;
            gameoverPanel.transform.parent = canvasThree.transform;
        }       
    }
    public void CanvasChangeButtonThree()
    {
        canvasThree.SetActive(false);
        canvasFour.SetActive(true);
        if (canvasFour == true)
        {
            
            //samescore.transform.parent = canvasFour.transform;
            Timer.transform.parent = canvasFour.transform;
            pauseButton.transform.parent = canvasFour.transform;
            pauseMenu.transform.parent = canvasFour.transform;
            gameoverPanel.transform.parent = canvasFour.transform;
        }      
    }
    public void CanvasChangeButtonFour()
    {
        canvasFour.SetActive(false);
        canvasFive.SetActive(true);
        if (canvasFive == true)
        {
            
            //samescore.transform.parent = canvasFive.transform;
            Timer.transform.parent = canvasFive.transform;
            pauseButton.transform.parent = canvasFive.transform;
            pauseMenu.transform.parent = canvasFive.transform;
            gameoverPanel.transform.parent = canvasFive.transform;
        }
    }
    public void CanvasChangeButtonFive()
    {
        canvasFive.SetActive(false);
        canvasSix.SetActive(true);
        if (canvasSix == true)
        {
            
            //samescore.transform.parent = canvasFive.transform;
            Timer.transform.parent = canvasSix.transform;
            pauseButton.transform.parent = canvasSix.transform;
            pauseMenu.transform.parent = canvasSix.transform;
            gameoverPanel.transform.parent = canvasSix.transform;
        }
    }

    public void CanvasChangeButtonSix()
    {
        canvasSix.SetActive(false);
        canvasSeven.SetActive(true);
        if (canvasSeven == true)
        {
            
            //samescore.transform.parent = canvasFive.transform;
            Timer.transform.parent = canvasSeven.transform;
            pauseButton.transform.parent = canvasSeven.transform;
            pauseMenu.transform.parent = canvasSeven.transform;
            gameoverPanel.transform.parent = canvasSeven.transform;
        }
    }
    public void CanvasChangeButtonSeven()
    {
        canvasSeven.SetActive(false);
        canvasEight.SetActive(true);
        if (canvasEight == true)
        {
            
            //samescore.transform.parent = canvasFive.transform;
            Timer.transform.parent = canvasEight.transform;
            pauseButton.transform.parent = canvasEight.transform;
            pauseMenu.transform.parent = canvasEight.transform;
            gameoverPanel.transform.parent = canvasEight.transform;
        }
    }

    public void Pass()
    {
        
        canvasOne.SetActive(false);
        canvasTwo.SetActive(true);
        
        //samescore.transform.parent = canvasTwo.transform;
        Timer.transform.parent = canvasTwo.transform;
        pauseButton.transform.parent = canvasTwo.transform;
        pauseMenu.transform.parent = canvasTwo.transform;
        gameoverPanel.transform.parent = canvasTwo.transform;
    }
    public void PassTwo()
    {
        
        canvasTwo.SetActive(false);
        canvasThree.SetActive(true);
        
        //samescore.transform.parent = canvasThree.transform;
        Timer.transform.parent = canvasThree.transform;
        pauseButton.transform.parent = canvasThree.transform;
        pauseMenu.transform.parent = canvasThree.transform;
        gameoverPanel.transform.parent = canvasThree.transform;
    }
    public void PassThree()
    {
        
        canvasThree.SetActive(false);
        canvasFour.SetActive(true);
        
        //samescore.transform.parent = canvasFour.transform;
        Timer.transform.parent = canvasFour.transform;
        pauseButton.transform.parent = canvasFour.transform;
        pauseMenu.transform.parent = canvasFour.transform;
        gameoverPanel.transform.parent = canvasFour.transform;
    }
    public void PassFour()
    {
        
        canvasFour.SetActive(false);
        canvasFive.SetActive(true);
        
        //samescore.transform.parent = canvasFive.transform;
        Timer.transform.parent = canvasFive.transform;
        pauseButton.transform.parent = canvasFive.transform;
        pauseMenu.transform.parent = canvasFive.transform;
        gameoverPanel.transform.parent = canvasFive.transform;
    }
    public void PassFive()
    {

        canvasFive.SetActive(false);
        canvasSix.SetActive(true);

        //samescore.transform.parent = canvasFive.transform;
        Timer.transform.parent = canvasSix.transform;
        pauseButton.transform.parent = canvasSix.transform;
        pauseMenu.transform.parent = canvasSix.transform;
        gameoverPanel.transform.parent = canvasSix.transform;
    }
    public void PassSix()
    {

        canvasSix.SetActive(false);
        canvasSeven.SetActive(true);

        //samescore.transform.parent = canvasFive.transform;
        Timer.transform.parent = canvasSeven.transform;
        pauseButton.transform.parent = canvasSeven.transform;
        pauseMenu.transform.parent = canvasSeven.transform;
        gameoverPanel.transform.parent = canvasSeven.transform;
    }
    public void PassSeven()
    {

        canvasSeven.SetActive(false);
        canvasEight.SetActive(true);

        //samescore.transform.parent = canvasFive.transform;
        Timer.transform.parent = canvasEight.transform;
        pauseButton.transform.parent = canvasEight.transform;
        pauseMenu.transform.parent = canvasEight.transform;
        gameoverPanel.transform.parent = canvasEight.transform;
    }
    public GameObject passObje;
    public void Idea()
    {
        
        Destroy(GameObject.FindGameObjectWithTag("Idea"));
        Destroy(GameObject.FindGameObjectWithTag("WrongOne"));
        Destroy(GameObject.FindGameObjectWithTag("WrongTwo"));
        Destroy(GameObject.FindGameObjectWithTag("WrongThree"));
        Destroy(GameObject.FindGameObjectWithTag("WrongFour"));
        Destroy(GameObject.FindGameObjectWithTag("WrongFive"));
        Destroy(GameObject.FindGameObjectWithTag("WrongSix"));
        Destroy(GameObject.FindGameObjectWithTag("WrongSeven"));
    }
    public void RightButton()
    {
        
        words[0].SetActive(true);
        if (words[0] == true)
        {
            Destroy(buttons[0]);
            Destroy(buttons[1]);
            Destroy(buttons[2]);
            Destroy(buttons[3]);
            Destroy(buttons[4]);

            buttons[5].SetActive(true); buttons[6].SetActive(true); buttons[7].SetActive(true); buttons[8].SetActive(true); buttons[9].SetActive(true);
            
        }       
    }

    public void RightButtonTwo()
    {
        
        words[1].SetActive(true);
        if (words[1] == true)
        {
            Destroy(buttons[5]);
            Destroy(buttons[6]);
            Destroy(buttons[7]);
            Destroy(buttons[8]);
            Destroy(buttons[9]);

            buttons[10].SetActive(true); buttons[11].SetActive(true); buttons[12].SetActive(true); buttons[13].SetActive(true); buttons[14].SetActive(true);
        }
    }

    public void RightButtonThree()
    {
        
        words[2].SetActive(true);
        if (words[2] == true)
        {
            Destroy(buttons[10]);
            Destroy(buttons[11]);
            Destroy(buttons[12]);
            Destroy(buttons[13]);
            Destroy(buttons[14]);

            buttons[15].SetActive(true); buttons[16].SetActive(true); buttons[17].SetActive(true); buttons[18].SetActive(true); buttons[19].SetActive(true);
        }
    }

    public void RightButtonFour()
    {
        
        words[3].SetActive(true);
        if (words[3] == true)
        {
            Destroy(buttons[15]);
            Destroy(buttons[16]);
            Destroy(buttons[17]);
            Destroy(buttons[18]);
            Destroy(buttons[19]);

            buttons[20].SetActive(true); buttons[21].SetActive(true); buttons[22].SetActive(true); buttons[23].SetActive(true); buttons[24].SetActive(true);
        }
    }
    public void RightButtonFive()
    {
        
        words[4].SetActive(true);
        if (words[4] == true)
        {
            Destroy(buttons[20]);
            Destroy(buttons[21]);
            Destroy(buttons[22]);
            Destroy(buttons[23]);
            Destroy(buttons[24]);

            words[5].SetActive(true);
            CanvasChange.SetActive(true);
        }
    }

    public void FalseButtonOne()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongOne"));
        
    }
    public void FalseButtonTwo()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongTwo"));
        
    }
    public void FalseButtonThree()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongThree"));
        
    }
    public void FalseButtonFour()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongFour"));
        
    }
    public void FalseButtonFive()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongFive"));
        
    }
    public void FalseButtonSix()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongSix"));
        
    }
    public void FalseButtonSeven()
    {
        Destroy(GameObject.FindGameObjectWithTag("WrongSeven"));
        
    }

    // FOUR WORDS GAME //

    public void FOURRightButton()
    {
        
        words[0].SetActive(true);
        if (words[0] == true)
        {
            Destroy(buttons[0]);
            Destroy(buttons[1]);
            Destroy(buttons[2]);
            Destroy(buttons[3]);
            Destroy(buttons[4]);

            buttons[5].SetActive(true); buttons[6].SetActive(true); buttons[7].SetActive(true); buttons[8].SetActive(true);

        }
    }
    public void FOURRightButtonTwo()
    {
        
        words[1].SetActive(true);
        if (words[1] == true)
        {
            Destroy(buttons[5]);
            Destroy(buttons[6]);
            Destroy(buttons[7]);
            Destroy(buttons[8]);
            Destroy(buttons[9]);

            buttons[10].SetActive(true); buttons[11].SetActive(true); buttons[12].SetActive(true); buttons[13].SetActive(true);
        }
    }
    public void FOURRightButtonThree()
    {
        
        words[2].SetActive(true);
        if (words[2] == true)
        {
            Destroy(buttons[10]);
            Destroy(buttons[11]);
            Destroy(buttons[12]);
            Destroy(buttons[13]);
            Destroy(buttons[14]);

            buttons[15].SetActive(true); buttons[16].SetActive(true); buttons[17].SetActive(true); buttons[18].SetActive(true);
        }
    }
    public void FOURRightButtonFour()
    {
        
        words[3].SetActive(true);
        if (words[3] == true)
        {
            Destroy(buttons[15]);
            Destroy(buttons[16]);
            Destroy(buttons[17]);
            Destroy(buttons[18]);
            Destroy(buttons[19]);
            words[5].SetActive(true);
            CanvasChange.SetActive(true);
        }
    }

    // SÝX WORDS GAME //

    public void SÝXRightButton()
    {
        
        words[0].SetActive(true);
        if (words[0] == true)
        {
            Destroy(buttons[0]);
            Destroy(buttons[1]);
            Destroy(buttons[2]);
            Destroy(buttons[3]);
            Destroy(buttons[4]);
            Destroy(buttons[5]);

            buttons[6].SetActive(true); buttons[7].SetActive(true); buttons[8].SetActive(true); buttons[9].SetActive(true); buttons[10].SetActive(true); buttons[11].SetActive(true);

        }
    }
    public void SÝXRightButtonTwo()
    {
        
        words[1].SetActive(true);
        if (words[1] == true)
        {
            Destroy(buttons[6]);
            Destroy(buttons[7]);
            Destroy(buttons[8]);
            Destroy(buttons[9]);
            Destroy(buttons[10]);
            Destroy(buttons[11]);

            buttons[12].SetActive(true); buttons[13].SetActive(true); buttons[14].SetActive(true); buttons[15].SetActive(true); buttons[16].SetActive(true); buttons[17].SetActive(true);
        }
    }
    public void SÝXRightButtonThree()
    {
        
        words[2].SetActive(true);
        if (words[2] == true)
        {
            Destroy(buttons[12]);
            Destroy(buttons[13]);
            Destroy(buttons[14]);
            Destroy(buttons[15]);
            Destroy(buttons[16]);
            Destroy(buttons[17]);

            buttons[18].SetActive(true); buttons[19].SetActive(true); buttons[20].SetActive(true); buttons[21].SetActive(true); buttons[22].SetActive(true); buttons[23].SetActive(true);
        }
    }
    public void SÝXRightButtonFour()
    {
        
        words[3].SetActive(true);
        if (words[3] == true)
        {
            Destroy(buttons[18]);
            Destroy(buttons[19]);
            Destroy(buttons[20]);
            Destroy(buttons[21]);
            Destroy(buttons[22]);
            Destroy(buttons[23]);

            buttons[24].SetActive(true); buttons[25].SetActive(true); buttons[26].SetActive(true); buttons[27].SetActive(true); buttons[28].SetActive(true); buttons[29].SetActive(true);
        }
    }
    public void SÝXRightButtonFive()
    {
        
        words[4].SetActive(true);
        if (words[4] == true)
        {
            Destroy(buttons[24]);
            Destroy(buttons[25]);
            Destroy(buttons[26]);
            Destroy(buttons[27]);
            Destroy(buttons[28]);
            Destroy(buttons[29]);

            buttons[30].SetActive(true); buttons[31].SetActive(true); buttons[32].SetActive(true); buttons[33].SetActive(true); buttons[34].SetActive(true); buttons[35].SetActive(true);
        }
    }
    public void SÝXRightButtonSix()
    {
        
        words[6].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[30]);
            Destroy(buttons[31]);
            Destroy(buttons[32]);
            Destroy(buttons[33]);
            Destroy(buttons[34]);
            Destroy(buttons[35]);

            words[5].SetActive(true);
            CanvasChange.SetActive(true);
        }
    }

    // SEVEN WORDS GAME

    public void SEVENRightButton()
    {
        
        words[0].SetActive(true);
        if (words[0] == true)
        {
            Destroy(buttons[0]);
            Destroy(buttons[1]);
            Destroy(buttons[2]);
            Destroy(buttons[3]);
            Destroy(buttons[4]);
            Destroy(buttons[5]);
            Destroy(buttons[6]);

            buttons[7].SetActive(true); buttons[8].SetActive(true); buttons[9].SetActive(true); buttons[10].SetActive(true); buttons[11].SetActive(true); buttons[12].SetActive(true); buttons[13].SetActive(true);

        }
    }
    public void SEVENRightButtonTwo()
    {
        
        words[1].SetActive(true);
        if (words[1] == true)
        {
            Destroy(buttons[7]);
            Destroy(buttons[8]);
            Destroy(buttons[9]);
            Destroy(buttons[10]);
            Destroy(buttons[11]);
            Destroy(buttons[12]);
            Destroy(buttons[13]);

            buttons[14].SetActive(true); buttons[15].SetActive(true); buttons[16].SetActive(true); buttons[17].SetActive(true); buttons[18].SetActive(true); buttons[19].SetActive(true); buttons[20].SetActive(true);
        }
    }
    public void SEVENightButtonThree()
    {
        
        words[2].SetActive(true);
        if (words[2] == true)
        {
            Destroy(buttons[14]);
            Destroy(buttons[15]);
            Destroy(buttons[16]);
            Destroy(buttons[17]);
            Destroy(buttons[18]);
            Destroy(buttons[19]);
            Destroy(buttons[20]);

            buttons[21].SetActive(true); buttons[22].SetActive(true); buttons[23].SetActive(true); buttons[24].SetActive(true); buttons[25].SetActive(true); buttons[26].SetActive(true); buttons[27].SetActive(true);
        }
    }
    public void SEVENRightButtonFour()
    {
        
        words[3].SetActive(true);
        if (words[3] == true)
        {
            Destroy(buttons[21]);
            Destroy(buttons[22]);
            Destroy(buttons[23]);
            Destroy(buttons[24]);
            Destroy(buttons[25]);
            Destroy(buttons[26]);
            Destroy(buttons[27]);

            buttons[28].SetActive(true); buttons[29].SetActive(true); buttons[30].SetActive(true); buttons[31].SetActive(true); buttons[32].SetActive(true); buttons[33].SetActive(true); buttons[34].SetActive(true);
        }
    }
    public void SEVENRightButtonFive()
    {
        
        words[4].SetActive(true);
        if (words[4] == true)
        {
            Destroy(buttons[28]);
            Destroy(buttons[29]);
            Destroy(buttons[30]);
            Destroy(buttons[31]);
            Destroy(buttons[32]);
            Destroy(buttons[33]);
            Destroy(buttons[34]);

            buttons[35].SetActive(true); buttons[36].SetActive(true); buttons[37].SetActive(true); buttons[38].SetActive(true); buttons[39].SetActive(true); buttons[40].SetActive(true); buttons[41].SetActive(true);
        }
    }
    public void SEVENRightButtonSix()
    {
        
        words[6].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[35]);
            Destroy(buttons[36]);
            Destroy(buttons[37]);
            Destroy(buttons[38]);
            Destroy(buttons[39]);
            Destroy(buttons[40]);
            Destroy(buttons[41]);

            buttons[42].SetActive(true); buttons[43].SetActive(true); buttons[44].SetActive(true); buttons[45].SetActive(true); buttons[46].SetActive(true); buttons[47].SetActive(true); buttons[48].SetActive(true);           
        }
    }
    public void SEVENRightButtonSeven()
    {
        
        words[7].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[42]);
            Destroy(buttons[43]);
            Destroy(buttons[44]);
            Destroy(buttons[45]);
            Destroy(buttons[46]);
            Destroy(buttons[47]);
            Destroy(buttons[48]);

            words[5].SetActive(true);
            CanvasChange.SetActive(true);
        }
    }

    // EIGHT WORDS GAME

    public void EIGHTRightButton()
    {
        
        words[0].SetActive(true);
        if (words[0] == true)
        {
            Destroy(buttons[0]);
            Destroy(buttons[1]);
            Destroy(buttons[2]);
            Destroy(buttons[3]);
            Destroy(buttons[4]);
            Destroy(buttons[5]);
            Destroy(buttons[6]);
            Destroy(buttons[7]);

            buttons[8].SetActive(true); buttons[9].SetActive(true); buttons[10].SetActive(true); buttons[11].SetActive(true); buttons[12].SetActive(true); buttons[13].SetActive(true); buttons[14].SetActive(true); buttons[15].SetActive(true);

        }
    }
    public void EIGHTRightButtonTwo()
    {
        
        words[1].SetActive(true);
        if (words[1] == true)
        {
            Destroy(buttons[8]);
            Destroy(buttons[9]);
            Destroy(buttons[10]);
            Destroy(buttons[11]);
            Destroy(buttons[12]);
            Destroy(buttons[13]);
            Destroy(buttons[14]);
            Destroy(buttons[15]);

            buttons[16].SetActive(true); buttons[17].SetActive(true); buttons[18].SetActive(true); buttons[19].SetActive(true); buttons[20].SetActive(true); buttons[21].SetActive(true); buttons[22].SetActive(true); buttons[23].SetActive(true);
        }
    }
    public void EIGHTightButtonThree()
    {
        
        words[2].SetActive(true);
        if (words[2] == true)
        {
            Destroy(buttons[16]);
            Destroy(buttons[17]);
            Destroy(buttons[18]);
            Destroy(buttons[19]);
            Destroy(buttons[20]);
            Destroy(buttons[21]);
            Destroy(buttons[22]);
            Destroy(buttons[23]);

            buttons[24].SetActive(true); buttons[25].SetActive(true); buttons[26].SetActive(true); buttons[27].SetActive(true); buttons[28].SetActive(true); buttons[29].SetActive(true); buttons[30].SetActive(true); buttons[31].SetActive(true);
        }
    }
    public void EIGHTRightButtonFour()
    {
        
        words[3].SetActive(true);
        if (words[3] == true)
        {
            Destroy(buttons[24]);
            Destroy(buttons[25]);
            Destroy(buttons[26]);
            Destroy(buttons[27]);
            Destroy(buttons[28]);
            Destroy(buttons[29]);
            Destroy(buttons[30]);
            Destroy(buttons[31]);

            buttons[32].SetActive(true); buttons[33].SetActive(true); buttons[34].SetActive(true); buttons[35].SetActive(true); buttons[36].SetActive(true); buttons[37].SetActive(true); buttons[38].SetActive(true); buttons[39].SetActive(true);
        }
    }
    public void EIGHTRightButtonFive()
    {
        
        words[4].SetActive(true);
        if (words[4] == true)
        {
            Destroy(buttons[32]);
            Destroy(buttons[33]);
            Destroy(buttons[34]);
            Destroy(buttons[35]);
            Destroy(buttons[36]);
            Destroy(buttons[37]);
            Destroy(buttons[38]);
            Destroy(buttons[39]);

            buttons[40].SetActive(true); buttons[41].SetActive(true); buttons[42].SetActive(true); buttons[43].SetActive(true); buttons[44].SetActive(true); buttons[45].SetActive(true); buttons[46].SetActive(true); buttons[47].SetActive(true);
        }
    }
    public void EIGHTRightButtonSix()
    {
        
        words[6].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[40]);
            Destroy(buttons[41]);
            Destroy(buttons[42]);
            Destroy(buttons[43]);
            Destroy(buttons[44]);
            Destroy(buttons[45]);
            Destroy(buttons[46]);
            Destroy(buttons[47]);

            buttons[48].SetActive(true); buttons[49].SetActive(true); buttons[50].SetActive(true); buttons[51].SetActive(true); buttons[52].SetActive(true); buttons[53].SetActive(true); buttons[54].SetActive(true); buttons[55].SetActive(true);
        }
    }
    public void EIGHTRightButtonSeven()
    {
        
        words[7].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[48]);
            Destroy(buttons[49]);
            Destroy(buttons[50]);
            Destroy(buttons[51]);
            Destroy(buttons[52]);
            Destroy(buttons[53]);
            Destroy(buttons[54]);
            Destroy(buttons[55]);

            buttons[56].SetActive(true); buttons[57].SetActive(true); buttons[58].SetActive(true); buttons[59].SetActive(true); buttons[60].SetActive(true); buttons[61].SetActive(true); buttons[62].SetActive(true); buttons[63].SetActive(true);          
        }
    }
    public void EIGHTRightButtonEight()
    {
        
        words[8].SetActive(true);
        if (words[6] == true)
        {
            Destroy(buttons[56]);
            Destroy(buttons[57]);
            Destroy(buttons[58]);
            Destroy(buttons[59]);
            Destroy(buttons[60]);
            Destroy(buttons[61]);
            Destroy(buttons[62]);
            Destroy(buttons[63]);

            
            words[5].SetActive(true);
            CanvasChange.SetActive(true);
        }
    }    
}
