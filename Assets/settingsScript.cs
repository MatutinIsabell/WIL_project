using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsScript : MonoBehaviour
{
    public GameObject RED;
    public GameObject BLUE;
    public GameObject WHITE;
    public GameObject YELLOW;

   public void OpenSettigns ()
    {
       
    }

    public void ChangeImageR ()
    {
        RED.SetActive(true);
        BLUE.SetActive(false);
        WHITE.SetActive(false);
        YELLOW.SetActive(false);
    }

    public void ChangeImageB()
    {
        RED.SetActive(false);
        BLUE.SetActive(true);
        WHITE.SetActive(false);
        YELLOW.SetActive(false);
    }

    public void ChangeImageW()
    {
        RED.SetActive(false);
        BLUE.SetActive(false);
        WHITE.SetActive(true);
        YELLOW.SetActive(false);
    }

    public void ChangeImageY()
    {
        RED.SetActive(false);
        BLUE.SetActive(false);
        WHITE.SetActive(false);
        YELLOW.SetActive(true);
    }
}
