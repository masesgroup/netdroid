/*
 *  Copyright 2024 MASES s.r.l.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  Refer to LICENSE for more information.
 */

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*/

package org.mases.netdroid.generated.android.accessibilityservice;

public final class AccessibilityService_MagnificationController_OnMagnificationChangedListener extends org.mases.jcobridge.JCListener implements android.accessibilityservice.AccessibilityService.MagnificationController.OnMagnificationChangedListener {
    public AccessibilityService_MagnificationController_OnMagnificationChangedListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onMagnificationChanged(android.accessibilityservice.AccessibilityService.MagnificationController arg0, android.graphics.Region arg1, float arg2, float arg3, float arg4) {
        raiseEvent("onMagnificationChanged", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void onMagnificationChanged(android.accessibilityservice.AccessibilityService.MagnificationController arg0, android.graphics.Region arg1, android.accessibilityservice.MagnificationConfig arg2) {
        raiseEvent("onMagnificationChanged3", arg0, arg1, arg2);
    }
    //@Override
    public void onMagnificationChangedDefault(android.accessibilityservice.AccessibilityService.MagnificationController arg0, android.graphics.Region arg1, android.accessibilityservice.MagnificationConfig arg2) {
        android.accessibilityservice.AccessibilityService.MagnificationController.OnMagnificationChangedListener.super.onMagnificationChanged(arg0, arg1, arg2);
    }

}