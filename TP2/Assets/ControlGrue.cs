using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGrue : MonoBehaviour
{
    public float torque = 250f;
    public float forceChariot = 500f;
    public float forceMoufle = 500f;
    public ArticulationBody pivot;
    public ArticulationBody chariot;
    public ArticulationBody moufle;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    private Camera currentCamera;

    void Start()
    {
        // Initialisation si nécessaire
        currentCamera = camera1;
        SwitchToCamera(camera1);
    }

    void Update()
    {
        // Commandes pour la flèche (rotation avec torque)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pivot.AddTorque(Vector3.up * -torque);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pivot.AddTorque(Vector3.up * torque);
        }

        // Commandes pour le chariot (déplacement horizontal)
        if (Input.GetKey(KeyCode.UpArrow))
        {
            chariot.AddForce(Vector3.right * forceChariot);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            chariot.AddForce(Vector3.right * -forceChariot);
        }

        // Commandes pour la moufle (déplacement vertical)
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moufle.AddForce(Vector3.up * forceMoufle);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            moufle.AddForce(Vector3.up * -forceMoufle);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // Alterner entre les caméras
            if (currentCamera == camera1)
            {
                SwitchToCamera(camera2);
            }
            else if(currentCamera == camera2)
            {
                SwitchToCamera(camera3);
            }
            else{
                SwitchToCamera(camera1);
            }
        }
    }

    void SwitchToCamera(Camera newCamera)
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        newCamera.enabled = true;

        // Mettre à jour la caméra courante
        currentCamera = newCamera;
    }
}
