using UnityEngine;
using Valve.VR;

public class GrabTest : MonoBehaviour
{
    public SteamVR_Input_Sources hand;
    public SteamVR_Action_Boolean grabAction;

    void Update()
    {
        if (grabAction.GetState(hand))
        {
            Debug.Log("Grab!");
        }
    }
}