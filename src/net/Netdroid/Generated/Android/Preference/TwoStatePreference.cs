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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region TwoStatePreference
    public partial class TwoStatePreference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public TwoStatePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public TwoStatePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public TwoStatePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public TwoStatePreference(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#getDisableDependentsState()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetDisableDependentsState()
        {
            return IExecuteWithSignature<bool>("getDisableDependentsState", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#isChecked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsChecked()
        {
            return IExecuteWithSignature<bool>("isChecked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#getSummaryOff()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetSummaryOff()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSummaryOff", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#getSummaryOn()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetSummaryOn()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSummaryOn", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setChecked(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetChecked(bool arg0)
        {
            IExecuteWithSignature("setChecked", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setDisableDependentsState(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetDisableDependentsState(bool arg0)
        {
            IExecuteWithSignature("setDisableDependentsState", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setSummaryOff(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSummaryOff(int arg0)
        {
            IExecuteWithSignature("setSummaryOff", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setSummaryOff(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetSummaryOff(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSummaryOff", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setSummaryOn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSummaryOn(int arg0)
        {
            IExecuteWithSignature("setSummaryOn", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/TwoStatePreference.html#setSummaryOn(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetSummaryOn(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSummaryOn", "(Ljava/lang/CharSequence;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}