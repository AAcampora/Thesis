using System.Collections;
using UnityEngine;

public class FirstCam : MonoBehaviour
{
    //TODO add cam array
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public bool isCamOn;
    public int camNumber = 1;

    private void Start()
    {
        StartCoroutine(CameraSwitch());
    }
    IEnumerator CameraSwitch()
    {
        yield return new WaitForSeconds(5); //change to reausable
        cameraTwo.SetActive(true);
        cameraOne.SetActive(false);
        isCamOn = true;
    }
}
