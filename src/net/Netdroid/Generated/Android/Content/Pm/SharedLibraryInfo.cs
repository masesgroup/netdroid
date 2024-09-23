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
    #region SharedLibraryInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html"/>
    /// </summary>
    public partial class SharedLibraryInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.pm.SharedLibraryInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SharedLibraryInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SharedLibraryInfo(params object[] args) : base(args) { }
    
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

    #region SharedLibraryInfo implementation
    public partial class SharedLibraryInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#TYPE_BUILTIN"/>
        /// </summary>
        public static int TYPE_BUILTIN { get { if (!_TYPE_BUILTINReady) { _TYPE_BUILTINContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUILTIN"); _TYPE_BUILTINReady = true; } return _TYPE_BUILTINContent; } }
        private static int _TYPE_BUILTINContent = default;
        private static bool _TYPE_BUILTINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#TYPE_DYNAMIC"/>
        /// </summary>
        public static int TYPE_DYNAMIC { get { if (!_TYPE_DYNAMICReady) { _TYPE_DYNAMICContent = SGetField<int>(LocalBridgeClazz, "TYPE_DYNAMIC"); _TYPE_DYNAMICReady = true; } return _TYPE_DYNAMICContent; } }
        private static int _TYPE_DYNAMICContent = default;
        private static bool _TYPE_DYNAMICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#TYPE_SDK_PACKAGE"/>
        /// </summary>
        public static int TYPE_SDK_PACKAGE { get { if (!_TYPE_SDK_PACKAGEReady) { _TYPE_SDK_PACKAGEContent = SGetField<int>(LocalBridgeClazz, "TYPE_SDK_PACKAGE"); _TYPE_SDK_PACKAGEReady = true; } return _TYPE_SDK_PACKAGEContent; } }
        private static int _TYPE_SDK_PACKAGEContent = default;
        private static bool _TYPE_SDK_PACKAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#TYPE_STATIC"/>
        /// </summary>
        public static int TYPE_STATIC { get { if (!_TYPE_STATICReady) { _TYPE_STATICContent = SGetField<int>(LocalBridgeClazz, "TYPE_STATIC"); _TYPE_STATICReady = true; } return _TYPE_STATICContent; } }
        private static int _TYPE_STATICContent = default;
        private static bool _TYPE_STATICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#VERSION_UNDEFINED"/>
        /// </summary>
        public static int VERSION_UNDEFINED { get { if (!_VERSION_UNDEFINEDReady) { _VERSION_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "VERSION_UNDEFINED"); _VERSION_UNDEFINEDReady = true; } return _VERSION_UNDEFINEDContent; } }
        private static int _VERSION_UNDEFINEDContent = default;
        private static bool _VERSION_UNDEFINEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getDeclaringPackage()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.VersionedPackage"/></returns>
        public Android.Content.Pm.VersionedPackage GetDeclaringPackage()
        {
            return IExecuteWithSignature<Android.Content.Pm.VersionedPackage>("getDeclaringPackage", "()Landroid/content/pm/VersionedPackage;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getDependentPackages()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.VersionedPackage> GetDependentPackages()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.VersionedPackage>>("getDependentPackages", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#getLongVersion()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLongVersion()
        {
            return IExecuteWithSignature<long>("getLongVersion", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/SharedLibraryInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}