using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
   public void Play(){ //gumb play funkcija za start igre

SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //indexi za scene (0,1)-->(MainMenu,LVL0)

   }

   public void Quit(){

Application.Quit();
Debug.Log("Igralec je zapiustil igro");

   }

}
