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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region RingtonePreference
    public partial class RingtonePreference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public RingtonePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [System.Obsolete()]
        public RingtonePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [System.Obsolete()]
        public RingtonePreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [System.Obsolete()]
        public RingtonePreference(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#getRingtoneType()"/> <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#setRingtoneType(int)"/>
        /// </summary>
        [System.Obsolete()]
        public int RingtoneType
        {
            get { return IExecuteWithSignature<int>("getRingtoneType", "()I"); } set { IExecuteWithSignature("setRingtoneType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#getShowDefault()"/> <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#setShowDefault(boolean)"/>
        /// </summary>
        [System.Obsolete()]
        public bool ShowDefault
        {
            get { return IExecuteWithSignature<bool>("getShowDefault", "()Z"); } set { IExecuteWithSignature("setShowDefault", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#getShowSilent()"/> <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#setShowSilent(boolean)"/>
        /// </summary>
        [System.Obsolete()]
        public bool ShowSilent
        {
            get { return IExecuteWithSignature<bool>("getShowSilent", "()Z"); } set { IExecuteWithSignature("setShowSilent", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/RingtonePreference.html#onActivityResult(int,int,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool OnActivityResult(int arg0, int arg1, Android.Content.Intent arg2)
        {
            return IExecute<bool>("onActivityResult", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}