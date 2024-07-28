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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*/

package org.mases.netdroid.generated.android.media;

public final class JetPlayer_OnJetEventListener extends org.mases.jcobridge.JCListener implements android.media.JetPlayer.OnJetEventListener {
    public JetPlayer_OnJetEventListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5) {
        raiseEvent("onJetEvent", arg0, arg1, arg2, arg3, arg4, arg5);
    }
    //@Override
    public void onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1) {
        raiseEvent("onJetNumQueuedSegmentUpdate", arg0, arg1);
    }
    //@Override
    public void onJetPauseUpdate(android.media.JetPlayer arg0, int arg1) {
        raiseEvent("onJetPauseUpdate", arg0, arg1);
    }
    //@Override
    public void onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2) {
        raiseEvent("onJetUserIdUpdate", arg0, arg1, arg2);
    }

}