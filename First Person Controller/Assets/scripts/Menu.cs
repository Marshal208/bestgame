using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void buttonfunction()
    {
        SceneManager.LoadScene("SampleScene");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}