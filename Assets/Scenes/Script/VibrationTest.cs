using UnityEngine;
using Valve.VR;

public class VibrationTest : MonoBehaviour
{
    public SteamVR_Input_Sources hand;
    public SteamVR_Action_Boolean grabAction;
    public SteamVR_Action_Vibration vibration;

    void Update()
    {
        // grabActionがオンになったら
        if (grabAction.GetStateDown(hand))
        {
            // 0秒後から0.2秒間、100Hz、強さ1で振動させる
            vibration.Execute(0, 0.2f, 100, 1f, hand);
        }
    }
}
