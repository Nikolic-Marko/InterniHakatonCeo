using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public InputField name;
    public Text score;
    string ime, skor;
    private Text sk;
    void Start()
    {
        sk = GameObject.Find("score").GetComponent<Text>();
        score.text = sk.text;
    }

    void Update()
    {

        ime = name.text;
        skor = score.text;
    }
   

    public void Unesi()
    {
        if (name.text!= "")
        {
            StreamWriter sw = new StreamWriter("Assets/highscores.txt", true);
            string linija = ime + '$' + skor + ';';
            sw.Write(linija);
            sw.Close();
            name.text = "";
            //Destroy(sk.gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
