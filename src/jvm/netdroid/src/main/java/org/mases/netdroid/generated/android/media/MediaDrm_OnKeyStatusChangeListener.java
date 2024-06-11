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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*/

package org.mases.netdroid.generated.android.media;

public final class MediaDrm_OnKeyStatusChangeListener extends org.mases.jcobridge.JCListener implements android.media.MediaDrm.OnKeyStatusChangeListener {
    public MediaDrm_OnKeyStatusChangeListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onKeyStatusChange(android.media.MediaDrm arg0, byte[] arg1, java.util.List arg2, boolean arg3) {
        raiseEvent("onKeyStatusChange", arg0, arg1, arg2, arg3);
    }

}