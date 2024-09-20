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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*/

package org.mases.netdroid.generated.android.app;

public final class AppOpsManager_OnOpActiveChangedListener extends org.mases.jcobridge.JCListener implements android.app.AppOpsManager.OnOpActiveChangedListener {
    public AppOpsManager_OnOpActiveChangedListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onOpActiveChanged(java.lang.String arg0, int arg1, java.lang.String arg2, boolean arg3) {
        raiseEvent("onOpActiveChanged", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onOpActiveChanged(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3, int arg4, boolean arg5, int arg6, int arg7) {
        raiseEvent("onOpActiveChanged8", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }
    //@Override
    public void onOpActiveChangedDefault(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3, int arg4, boolean arg5, int arg6, int arg7) {
        android.app.AppOpsManager.OnOpActiveChangedListener.super.onOpActiveChanged(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

}