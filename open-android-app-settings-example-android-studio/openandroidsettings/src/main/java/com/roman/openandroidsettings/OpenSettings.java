package com.roman.openandroidsettings;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;

public class OpenSettings {
    public static void runPlugin(Activity activity, String packageName){
        Intent intent = new Intent(android.provider.Settings.ACTION_APPLICATION_DETAILS_SETTINGS);
        intent.setData(Uri.parse("package:" + packageName));
        activity.startActivity(intent);
    }
}
