﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    public GameObject buttonScanMode;
    public GameObject buttonSettings;
    public GameObject buttonInfo;
    public GameObject buttonBack;
    public GameObject buttonScan;
    public GameObject backGround;
    public GameObject textSettings;
    public GameObject textInfo;
    public GameObject scrollView;

    // Start is called before the first frame update
    void Start()
    {
        Back();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterScanMode()
    {
        buttonScanMode.SetActive(false);
        buttonInfo.SetActive(false);
        buttonSettings.SetActive(false);
        buttonBack.SetActive(true);
        buttonScan.SetActive(true);
        backGround.SetActive(false);
    }

    public void Settings()
    {
        buttonScanMode.SetActive(false);
        buttonInfo.SetActive(false);
        buttonSettings.SetActive(false);
        buttonBack.SetActive(true);
        buttonScan.SetActive(false);
        textSettings.SetActive(true);
}

    public void Info()
    {
        buttonScanMode.SetActive(false);
        buttonInfo.SetActive(false);
        buttonSettings.SetActive(false);
        buttonBack.SetActive(true);
        buttonScan.SetActive(false);
        textInfo.SetActive(true);
        scrollView.SetActive(true);
    }

    public void Back()
    {
        buttonScanMode.SetActive(true);
        buttonInfo.SetActive(true);
        buttonSettings.SetActive(true);
        buttonBack.SetActive(false);
        buttonScan.SetActive(false);
        backGround.SetActive(true);
        textSettings.SetActive(false);
        textInfo.SetActive(false);
        scrollView.SetActive(false);
    }
}
