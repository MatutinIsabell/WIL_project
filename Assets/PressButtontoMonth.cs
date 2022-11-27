using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PressButtontoMonth : MonoBehaviour
{
    public AutoFlip autoFlip;
    public Book book;

    //public GameObject Page;
    public float PageNumber;
    bool isAtPage = true;


    public void TurnTo()
    {
        autoFlip = GetComponent<AutoFlip>();
        book = GetComponent<Book>();

        
        


    }

   


}
