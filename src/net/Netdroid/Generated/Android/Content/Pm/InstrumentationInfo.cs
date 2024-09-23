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
    #region InstrumentationInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html"/>
    /// </summary>
    public partial class InstrumentationInfo : Android.Content.Pm.PackageItemInfo
    {
        const string _bridgeClassName = "android.content.pm.InstrumentationInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InstrumentationInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InstrumentationInfo(params object[] args) : base(args) { }
    
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

    #region InstrumentationInfo implementation
    public partial class InstrumentationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#%3Cinit%3E(android.content.pm.InstrumentationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.InstrumentationInfo"/></param>
        public InstrumentationInfo(Android.Content.Pm.InstrumentationInfo arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Pm.InstrumentationInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Pm.InstrumentationInfo t) => t.Cast<Android.Os.Parcelable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#functionalTest"/>
        /// </summary>
        public bool functionalTest { get { return IGetField<bool>("functionalTest"); } set { ISetField("functionalTest", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#handleProfiling"/>
        /// </summary>
        public bool handleProfiling { get { return IGetField<bool>("handleProfiling"); } set { ISetField("handleProfiling", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#dataDir"/>
        /// </summary>
        public Java.Lang.String dataDir { get { return IGetField<Java.Lang.String>("dataDir"); } set { ISetField("dataDir", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#publicSourceDir"/>
        /// </summary>
        public Java.Lang.String publicSourceDir { get { return IGetField<Java.Lang.String>("publicSourceDir"); } set { ISetField("publicSourceDir", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#sourceDir"/>
        /// </summary>
        public Java.Lang.String sourceDir { get { return IGetField<Java.Lang.String>("sourceDir"); } set { ISetField("sourceDir", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#targetPackage"/>
        /// </summary>
        public Java.Lang.String targetPackage { get { return IGetField<Java.Lang.String>("targetPackage"); } set { ISetField("targetPackage", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#targetProcesses"/>
        /// </summary>
        public Java.Lang.String targetProcesses { get { return IGetField<Java.Lang.String>("targetProcesses"); } set { ISetField("targetProcesses", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#splitNames"/>
        /// </summary>
        public Java.Lang.String[] splitNames { get { return IGetFieldArray<Java.Lang.String>("splitNames"); } set { ISetField("splitNames", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#splitPublicSourceDirs"/>
        /// </summary>
        public Java.Lang.String[] splitPublicSourceDirs { get { return IGetFieldArray<Java.Lang.String>("splitPublicSourceDirs"); } set { ISetField("splitPublicSourceDirs", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#splitSourceDirs"/>
        /// </summary>
        public Java.Lang.String[] splitSourceDirs { get { return IGetFieldArray<Java.Lang.String>("splitSourceDirs"); } set { ISetField("splitSourceDirs", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstrumentationInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}