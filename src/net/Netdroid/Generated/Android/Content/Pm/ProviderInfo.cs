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

namespace Android.Content.Pm
{
    #region ProviderInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html"/>
    /// </summary>
    public partial class ProviderInfo : Android.Content.Pm.ComponentInfo
    {
        const string _bridgeClassName = "android.content.pm.ProviderInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ProviderInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ProviderInfo(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region ProviderInfo implementation
    public partial class ProviderInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#%3Cinit%3E(android.content.pm.ProviderInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ProviderInfo"/></param>
        public ProviderInfo(Android.Content.Pm.ProviderInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Pm.ProviderInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Pm.ProviderInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#pathPermissions"/>
        /// </summary>
        public Android.Content.Pm.PathPermission[] pathPermissions { get { return IGetFieldArray<Android.Content.Pm.PathPermission>("pathPermissions"); } set { ISetField("pathPermissions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#uriPermissionPatterns"/>
        /// </summary>
        public Android.Os.PatternMatcher[] uriPermissionPatterns { get { return IGetFieldArray<Android.Os.PatternMatcher>("uriPermissionPatterns"); } set { ISetField("uriPermissionPatterns", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#forceUriPermissions"/>
        /// </summary>
        public bool forceUriPermissions { get { return IGetField<bool>("forceUriPermissions"); } set { ISetField("forceUriPermissions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#grantUriPermissions"/>
        /// </summary>
        public bool grantUriPermissions { get { return IGetField<bool>("grantUriPermissions"); } set { ISetField("grantUriPermissions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#isSyncable"/>
        /// </summary>
        [global::System.Obsolete()]
        public bool isSyncable { get { return IGetField<bool>("isSyncable"); } set { ISetField("isSyncable", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#multiprocess"/>
        /// </summary>
        public bool multiprocess { get { return IGetField<bool>("multiprocess"); } set { ISetField("multiprocess", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#initOrder"/>
        /// </summary>
        public int initOrder { get { return IGetField<int>("initOrder"); } set { ISetField("initOrder", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#authority"/>
        /// </summary>
        public Java.Lang.String authority { get { return IGetField<Java.Lang.String>("authority"); } set { ISetField("authority", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#readPermission"/>
        /// </summary>
        public Java.Lang.String readPermission { get { return IGetField<Java.Lang.String>("readPermission"); } set { ISetField("readPermission", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#writePermission"/>
        /// </summary>
        public Java.Lang.String writePermission { get { return IGetField<Java.Lang.String>("writePermission"); } set { ISetField("writePermission", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#FLAG_SINGLE_USER"/>
        /// </summary>
        public static int FLAG_SINGLE_USER { get { if (!_FLAG_SINGLE_USERReady) { _FLAG_SINGLE_USERContent = SGetField<int>(LocalBridgeClazz, "FLAG_SINGLE_USER"); _FLAG_SINGLE_USERReady = true; } return _FLAG_SINGLE_USERContent; } }
        private static int _FLAG_SINGLE_USERContent = default;
        private static bool _FLAG_SINGLE_USERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ProviderInfo.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}