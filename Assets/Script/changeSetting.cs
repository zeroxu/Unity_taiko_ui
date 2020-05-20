using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSetting : MonoBehaviour
{
   public void OnStartGame(string ScneneName){
       SceneManager.LoadScene("setting");
   }
}

