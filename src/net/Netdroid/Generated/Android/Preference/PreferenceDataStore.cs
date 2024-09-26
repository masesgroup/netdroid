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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region PreferenceDataStore declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class PreferenceDataStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PreferenceDataStore>
    {
        const string _bridgeClassName = "android.preference.PreferenceDataStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PreferenceDataStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceDataStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PreferenceDataStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceDataStore(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

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

    #region PreferenceDataStore implementation
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
            return IExecuteWithSignature<bool>("getBoolean", "(Ljava/lang/String;Z)Z", arg0, arg1);
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
            return IExecuteWithSignature<float>("getFloat", "(Ljava/lang/String;F)F", arg0, arg1);
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
            return IExecuteWithSignature<int>("getInt", "(Ljava/lang/String;I)I", arg0, arg1);
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
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
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
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", arg0, arg1);
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
            return IExecuteWithSignature<long>("getLong", "(Ljava/lang/String;J)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void PutBoolean(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("putBoolean", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void PutFloat(Java.Lang.String arg0, float arg1)
        {
            IExecuteWithSignature("putFloat", "(Ljava/lang/String;F)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void PutInt(Java.Lang.String arg0, int arg1)
        {
            IExecuteWithSignature("putInt", "(Ljava/lang/String;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void PutLong(Java.Lang.String arg0, long arg1)
        {
            IExecuteWithSignature("putLong", "(Ljava/lang/String;J)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void PutString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("putString", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceDataStore.html#putStringSet(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        [global::System.Obsolete()]
        public void PutStringSet(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            IExecuteWithSignature("putStringSet", "(Ljava/lang/String;Ljava/util/Set;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}