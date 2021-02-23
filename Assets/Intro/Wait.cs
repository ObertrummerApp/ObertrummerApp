using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{

    public float waitTime = 5f;

    void Start()
    {
        StartCoroutine(waitForIntro());
    }

    IEnumerator waitForIntro()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("MainScene");
    }

}
