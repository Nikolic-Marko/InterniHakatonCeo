using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    void Start()
    {
        Invoke("Return",25f);
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
