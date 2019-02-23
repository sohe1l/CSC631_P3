using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public Camera firstPersonCamera;
    public Camera overheadCamera;

    bool isFirstPerson;
        void Start()
    {
        ShowFirstPersonView();
        isFirstPerson = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (isFirstPerson)
            {
                ShowOverheadView();
            }
            else
            {
                ShowFirstPersonView();
            }
            isFirstPerson = !isFirstPerson;
        }
    }

    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
