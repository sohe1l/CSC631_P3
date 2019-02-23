using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{

    public GameObject prefab;
    Ray ray;
    RaycastHit hit;


    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Update is called once per frame
    void Start()
    {

    }


    void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    createObject();
        //}

        if (Input.GetButtonDown("Fire1"))
        {
            createObject(Input.mousePosition);
        }

    }


    public void createObject(Vector2 mousePosition)
    {
        RaycastHit hit = RayFromCamera(mousePosition, 1000.0f);
        GameObject.Instantiate(prefab, hit.point, Quaternion.identity);
    }

    public RaycastHit RayFromCamera(Vector3 mousePosition, float rayLength)
    {
        RaycastHit hit; 
        Ray ray = getCurrentCamera().ScreenPointToRay(mousePosition);
        Physics.Raycast(ray, out hit, rayLength);
        return hit;
    }

    private Camera getCurrentCamera()
    {
        if (firstPersonCamera.enabled)
        {
            return firstPersonCamera;
        }
        else
        {
            return overheadCamera;
        }
    }

    //private void createObject()
    //{
    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        Debug.Log("Creatingggggg - yes ");
    //        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        GameObject obj = Instantiate(prefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;
    //    }
    //    else
    //    {
    //        Debug.Log("Creatingggggg - no ");
    //    }
    //}


}
