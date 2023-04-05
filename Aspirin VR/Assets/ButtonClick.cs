using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonClick : MonoBehaviour
{
    private SteamVR_Input_Sources Righty = SteamVR_Input_Sources.RightHand;
    public Collider collide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, collide.transform.position));
        /*if (SteamVR_Input.__actions_default_in_GrabGrip.GetStateDown(Righty) && Vector3.Distance(transform.position, collide.transform.position) <= 10)
        {
            Debug.Log("REEEEEEEEEEEEEEEEEEEEEEEEEE");
        }*/
    }
}
