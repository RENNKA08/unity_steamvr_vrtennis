using UnityEngine;
using Valve.VR;

public class Recenterer : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        //着席モードでRキーで位置トラッキングをリセットする
        if (Input.GetKeyDown(KeyCode.R))
        {
            SteamVR.instance.hmd.ResetSeatedZeroPose();
        }
	}
}
