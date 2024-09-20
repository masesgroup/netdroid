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

package org.mases.netdroid.generated.android.bluetooth;

public final class BluetoothProfile_ServiceListener extends org.mases.jcobridge.JCListener implements android.bluetooth.BluetoothProfile.ServiceListener {
    public BluetoothProfile_ServiceListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onServiceConnected(int arg0, android.bluetooth.BluetoothProfile arg1) {
        raiseEvent("onServiceConnected", arg0, arg1);
    }
    //@Override
    public void onServiceDisconnected(int arg0) {
        raiseEvent("onServiceDisconnected", arg0);
    }

}