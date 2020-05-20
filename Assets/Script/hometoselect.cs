using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hometoselect : MonoBehaviour
{
   public void OnStartGame(string ScneneName){
       SceneManager.LoadScene("select");
   }
}
