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

package org.mases.netdroid.generated.android.net.nsd;

public final class NsdManager_DiscoveryListener extends org.mases.jcobridge.JCListener implements android.net.nsd.NsdManager.DiscoveryListener {
    public NsdManager_DiscoveryListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onDiscoveryStarted(java.lang.String arg0) {
        raiseEvent("onDiscoveryStarted", arg0);
    }
    //@Override
    public void onDiscoveryStopped(java.lang.String arg0) {
        raiseEvent("onDiscoveryStopped", arg0);
    }
    //@Override
    public void onServiceFound(android.net.nsd.NsdServiceInfo arg0) {
        raiseEvent("onServiceFound", arg0);
    }
    //@Override
    public void onServiceLost(android.net.nsd.NsdServiceInfo arg0) {
        raiseEvent("onServiceLost", arg0);
    }
    //@Override
    public void onStartDiscoveryFailed(java.lang.String arg0, int arg1) {
        raiseEvent("onStartDiscoveryFailed", arg0, arg1);
    }
    //@Override
    public void onStopDiscoveryFailed(java.lang.String arg0, int arg1) {
        raiseEvent("onStopDiscoveryFailed", arg0, arg1);
    }

}