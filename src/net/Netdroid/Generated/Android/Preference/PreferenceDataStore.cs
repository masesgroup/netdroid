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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region IPreferenceDataStore
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPreferenceDataStore
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PreferenceDataStore
    public partial class PreferenceDataStore : Android.Preference.IPreferenceDataStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetBoolean(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public float GetFloat(Java.Lang.String arg0, float arg1)
        {
            return IExecute<float>("getFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getStringSet(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Set<Java.Lang.String> GetStringSet(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecute<Java.Util.Set<Java.Lang.String>>("getStringSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#getLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void PutBoolean(Java.Lang.String arg0, bool arg1)
        {
            IExecute("putBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void PutFloat(Java.Lang.String arg0, float arg1)
        {
            IExecute("putFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void PutInt(Java.Lang.String arg0, int arg1)
        {
            IExecute("putInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void PutLong(Java.Lang.String arg0, long arg1)
        {
            IExecute("putLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void PutString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("putString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putStringSet(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        [global::System.Obsolete()]
        public void PutStringSet(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            IExecute("putStringSet", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}