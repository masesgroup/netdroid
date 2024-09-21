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

namespace Android.Adservices.Adselection
{
    #region AdSelectionFromOutcomesConfig declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html"/>
    /// </summary>
    public partial class AdSelectionFromOutcomesConfig : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.adservices.adselection.AdSelectionFromOutcomesConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdSelectionFromOutcomesConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdSelectionFromOutcomesConfig(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.adselection.AdSelectionFromOutcomesConfig$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region AdSelectionFromOutcomesConfig implementation
    public partial class AdSelectionFromOutcomesConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#getSelectionSignals()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdSelectionSignals"/></returns>
        public Android.Adservices.Common.AdSelectionSignals GetSelectionSignals()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdSelectionSignals>("getSelectionSignals", "()Landroid/adservices/common/AdSelectionSignals;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#getSeller()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdTechIdentifier"/></returns>
        public Android.Adservices.Common.AdTechIdentifier GetSeller()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdTechIdentifier>("getSeller", "()Landroid/adservices/common/AdTechIdentifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#getSelectionLogicUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetSelectionLogicUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getSelectionLogicUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#getAdSelectionIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Long> GetAdSelectionIds()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Long>>("getAdSelectionIds", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionFromOutcomesConfig"/></returns>
            public Android.Adservices.Adselection.AdSelectionFromOutcomesConfig Build()
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionFromOutcomesConfig>("build", "()Landroid/adservices/adselection/AdSelectionFromOutcomesConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html#setAdSelectionIds(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder SetAdSelectionIds(Java.Util.List<Java.Lang.Long> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder>("setAdSelectionIds", "(Ljava/util/List;)Landroid/adservices/adselection/AdSelectionFromOutcomesConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html#setSelectionLogicUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder SetSelectionLogicUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder>("setSelectionLogicUri", "(Landroid/net/Uri;)Landroid/adservices/adselection/AdSelectionFromOutcomesConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html#setSelectionSignals(android.adservices.common.AdSelectionSignals)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder SetSelectionSignals(Android.Adservices.Common.AdSelectionSignals arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder>("setSelectionSignals", "(Landroid/adservices/common/AdSelectionSignals;)Landroid/adservices/adselection/AdSelectionFromOutcomesConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionFromOutcomesConfig.Builder.html#setSeller(android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder SetSeller(Android.Adservices.Common.AdTechIdentifier arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionFromOutcomesConfig.Builder>("setSeller", "(Landroid/adservices/common/AdTechIdentifier;)Landroid/adservices/adselection/AdSelectionFromOutcomesConfig$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}