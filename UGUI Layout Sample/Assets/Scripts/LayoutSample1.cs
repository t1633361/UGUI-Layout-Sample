using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutSample1 : MonoBehaviour
{
    public GameObject LeftAreaRoot;
    public GameObject RightAreaRoot;
    public GameObject DownAreaRoot;
    
    public Button LeftButton;
    public Button RightButton;
    public Button DownButton;



    public void EnableLeftArea()
    {
        LeftAreaRoot.SetActive(!LeftAreaRoot.activeSelf);
    }
    public void EnableRightArea()
    {
        RightAreaRoot.SetActive(!RightAreaRoot.activeSelf);
    }
    public void EnableDownArea()
    {
        DownAreaRoot.SetActive(!DownAreaRoot.activeSelf);
    }
}
