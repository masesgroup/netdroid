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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*/

package org.mases.netdroid.generated.android.media.tv;

public final class OnUnhandledInputEventListener extends org.mases.jcobridge.JCListener implements android.media.tv.TvView.OnUnhandledInputEventListener {
    public OnUnhandledInputEventListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean onUnhandledInputEvent(android.view.InputEvent arg0) {
        raiseEvent("onUnhandledInputEvent", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }

}