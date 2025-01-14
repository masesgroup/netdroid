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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region PreferenceGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class PreferenceGroup : Android.Preference.Preference
    {
        const string _bridgeClassName = "android.preference.PreferenceGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PreferenceGroup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PreferenceGroup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceGroup(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region PreferenceGroup implementation
    public partial class PreferenceGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public PreferenceGroup(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public PreferenceGroup(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public PreferenceGroup(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#findPreference(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Preference.Preference"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.Preference FindPreference(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Preference.Preference>("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#getPreference(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Preference.Preference"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.Preference GetPreference(int arg0)
        {
            return IExecuteWithSignature<Android.Preference.Preference>("getPreference", "(I)Landroid/preference/Preference;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#addPreference(android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool AddPreference(Android.Preference.Preference arg0)
        {
            return IExecuteWithSignature<bool>("addPreference", "(Landroid/preference/Preference;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#isOrderingAsAdded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsOrderingAsAdded()
        {
            return IExecuteWithSignature<bool>("isOrderingAsAdded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#removePreference(android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool RemovePreference(Android.Preference.Preference arg0)
        {
            return IExecuteWithSignature<bool>("removePreference", "(Landroid/preference/Preference;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#getPreferenceCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetPreferenceCount()
        {
            return IExecuteWithSignature<int>("getPreferenceCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#addItemFromInflater(android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        [global::System.Obsolete()]
        public void AddItemFromInflater(Android.Preference.Preference arg0)
        {
            IExecuteWithSignature("addItemFromInflater", "(Landroid/preference/Preference;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#removeAll()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveAll()
        {
            IExecuteWithSignature("removeAll", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceGroup.html#setOrderingAsAdded(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetOrderingAsAdded(bool arg0)
        {
            IExecuteWithSignature("setOrderingAsAdded", "(Z)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}