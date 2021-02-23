using UnityEngine;

public class PreviewButtons : MonoBehaviour
{

    public GameObject game01;
    public GameObject game02;
    public GameObject game03;
    public GameObject backButton;
    public GameObject scanSquare;

    public void Cancel()
    {
        game01.SetActive(false);
        game02.SetActive(false);
        game03.SetActive(false);
        backButton.SetActive(true);
        scanSquare.SetActive(true);
    }
}
