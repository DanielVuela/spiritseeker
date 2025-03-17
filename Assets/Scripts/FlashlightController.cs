using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    // #region Inpsectable fields
    public Light flashlight;
    public AudioSource clickSound; 
    // #endregion

    private bool isOn = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            isOn = !isOn;
            flashlight.enabled = isOn;
            clickSound.Play();
        }
    }
}
