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

package org.mases.netdroid.generated.android.media;

public final class LoudnessCodecController_OnLoudnessCodecUpdateListener extends org.mases.jcobridge.JCListener implements android.media.LoudnessCodecController.OnLoudnessCodecUpdateListener {
    public LoudnessCodecController_OnLoudnessCodecUpdateListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public android.os.Bundle onLoudnessCodecUpdate(android.media.MediaCodec arg0, android.os.Bundle arg1) {
        raiseEvent("onLoudnessCodecUpdate", arg0, arg1); Object retVal = getReturnData(); return (android.os.Bundle)retVal;
    }
    //@Override
    public android.os.Bundle onLoudnessCodecUpdateDefault(android.media.MediaCodec arg0, android.os.Bundle arg1) {
        return android.media.LoudnessCodecController.OnLoudnessCodecUpdateListener.super.onLoudnessCodecUpdate(arg0, arg1);
    }

}