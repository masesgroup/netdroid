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

namespace Android.Content
{
    #region AttributionSource declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html"/>
    /// </summary>
    public partial class AttributionSource : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.AttributionSource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AttributionSource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AttributionSource(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.content.AttributionSource$Builder";
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

    #region AttributionSource implementation
    public partial class AttributionSource
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#myAttributionSource()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.AttributionSource"/></returns>
        public static Android.Content.AttributionSource MyAttributionSource()
        {
            return SExecuteWithSignature<Android.Content.AttributionSource>(LocalBridgeClazz, "myAttributionSource", "()Landroid/content/AttributionSource;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getNext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.AttributionSource"/></returns>
        public Android.Content.AttributionSource GetNext()
        {
            return IExecuteWithSignature<Android.Content.AttributionSource>("getNext", "()Landroid/content/AttributionSource;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#checkCallingUid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CheckCallingUid()
        {
            return IExecuteWithSignature<bool>("checkCallingUid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#isTrusted(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTrusted(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<bool>("isTrusted", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getDeviceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceId()
        {
            return IExecuteWithSignature<int>("getDeviceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getPid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPid()
        {
            return IExecuteWithSignature<int>("getPid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUid()
        {
            return IExecuteWithSignature<int>("getUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getAttributionTag()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributionTag()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributionTag", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#enforceCallingUid()"/>
        /// </summary>
        public void EnforceCallingUid()
        {
            IExecuteWithSignature("enforceCallingUid", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AttributionSource.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#%3Cinit%3E(android.content.AttributionSource)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.AttributionSource"/></param>
            public Builder(Android.Content.AttributionSource arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.AttributionSource"/></returns>
            public Android.Content.AttributionSource Build()
            {
                return IExecuteWithSignature<Android.Content.AttributionSource>("build", "()Landroid/content/AttributionSource;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#setAttributionTag(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Content.AttributionSource.Builder"/></returns>
            public Android.Content.AttributionSource.Builder SetAttributionTag(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Content.AttributionSource.Builder>("setAttributionTag", "(Ljava/lang/String;)Landroid/content/AttributionSource$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#setDeviceId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.AttributionSource.Builder"/></returns>
            public Android.Content.AttributionSource.Builder SetDeviceId(int arg0)
            {
                return IExecuteWithSignature<Android.Content.AttributionSource.Builder>("setDeviceId", "(I)Landroid/content/AttributionSource$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#setNext(android.content.AttributionSource)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.AttributionSource"/></param>
            /// <returns><see cref="Android.Content.AttributionSource.Builder"/></returns>
            public Android.Content.AttributionSource.Builder SetNext(Android.Content.AttributionSource arg0)
            {
                return IExecuteWithSignature<Android.Content.AttributionSource.Builder>("setNext", "(Landroid/content/AttributionSource;)Landroid/content/AttributionSource$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#setPackageName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Content.AttributionSource.Builder"/></returns>
            public Android.Content.AttributionSource.Builder SetPackageName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Content.AttributionSource.Builder>("setPackageName", "(Ljava/lang/String;)Landroid/content/AttributionSource$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/AttributionSource.Builder.html#setPid(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.AttributionSource.Builder"/></returns>
            public Android.Content.AttributionSource.Builder SetPid(int arg0)
            {
                return IExecuteWithSignature<Android.Content.AttributionSource.Builder>("setPid", "(I)Landroid/content/AttributionSource$Builder;", arg0);
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