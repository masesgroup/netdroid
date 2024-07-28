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

package org.mases.netdroid.generated.android.preference;

public final class Preference_OnPreferenceChangeListener extends org.mases.jcobridge.JCListener implements android.preference.Preference.OnPreferenceChangeListener {
    public Preference_OnPreferenceChangeListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1) {
        raiseEvent("onPreferenceChange", arg0, arg1); Object retVal = getReturnData(); return (boolean)retVal;
    }

}