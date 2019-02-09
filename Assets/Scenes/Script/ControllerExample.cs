using UnityEngine;
using Valve.VR;

public class ControllerExample : MonoBehaviour {

    private static SteamVR_Action_Boolean p_default_GrabGrip;

    // Update is called once per frame
    private void Update () {

        if (ControllerExample.p_default_GrabGrip.GetStateUp(SteamVR_Input_Sources.Any))
        {
            Debug.Log("トリガーを浅く引いた");
        }
        /*
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを深く引いた");
        }
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを離した");
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドをクリックした");
        }
        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドをクリックしている");
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドをクリックして離した");
        }
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドに触った");
        }
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドを離した");
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log("メニューボタンをクリックした");
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log("グリップボタンをクリックした");
        }

        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            //Debug.Log("トリガーを浅く引いている");
        }
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            //Debug.Log("トリガーを深く引いている");
        }
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
        {
            //Debug.Log("タッチパッドに触っている");
        }
        */
    }
}