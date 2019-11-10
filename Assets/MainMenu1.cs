using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public GameObject zvuk;
    void Awake()
    {
        
    }
  public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }

    public void Options()
    {
        SceneManager.LoadScene(2);
        DontDestroyOnLoad(zvuk);
    }
    public void Highscores()
    {
        SceneManager.LoadScene(3);
    }
    public void Credits()
    {
        SceneManager.LoadScene(5);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

   //void sortiranje(int[] niz,int n)
   // {
   //     int c;
   //     for(int i = 0; i < n - 1; i++)
   //     {
   //         for(int j = i + 1; j < n; j++)
   //         {
   //             if (niz[i] > niz[j])
   //             {
   //                 c = niz[i];
   //                 niz[i] = niz[j];
   //                 niz[j] = c;
   //             }
   //         }
   //     }
   // }

 
    }


