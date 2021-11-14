using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AndroidJavaClass androidJC = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo= androidJC.GetStatic<AndroidJavaObject>("currentActivity");
        var javaClass=new AndroidJavaClass("com.roman.openandroidsettings.OpenSettings");
        javaClass.CallStatic("runPlugin",jo,Application.identifier);
    }

}
