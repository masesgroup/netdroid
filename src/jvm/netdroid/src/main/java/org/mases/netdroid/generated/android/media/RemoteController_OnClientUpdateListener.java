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

package org.mases.netdroid.generated.android.media;

public final class RemoteController_OnClientUpdateListener extends org.mases.jcobridge.JCListener implements android.media.RemoteController.OnClientUpdateListener {
    public RemoteController_OnClientUpdateListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onClientChange(boolean arg0) {
        raiseEvent("onClientChange", arg0);
    }
    //@Override
    public void onClientMetadataUpdate(android.media.RemoteController.MetadataEditor arg0) {
        raiseEvent("onClientMetadataUpdate", arg0);
    }
    //@Override
    public void onClientPlaybackStateUpdate(int arg0, long arg1, long arg2, float arg3) {
        raiseEvent("onClientPlaybackStateUpdate", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onClientPlaybackStateUpdate(int arg0) {
        raiseEvent("onClientPlaybackStateUpdate1", arg0);
    }
    //@Override
    public void onClientTransportControlUpdate(int arg0) {
        raiseEvent("onClientTransportControlUpdate", arg0);
    }

}