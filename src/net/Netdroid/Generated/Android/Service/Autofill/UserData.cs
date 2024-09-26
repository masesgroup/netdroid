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

namespace Android.Service.Autofill
{
    #region UserData declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html"/>
    /// </summary>
    public partial class UserData : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.autofill.UserData";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UserData() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UserData(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.service.autofill.UserData$Builder";
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

    #region UserData implementation
    public partial class UserData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getMaxCategoryCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxCategoryCount()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxCategoryCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getMaxFieldClassificationIdsSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxFieldClassificationIdsSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxFieldClassificationIdsSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getMaxUserDataSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxUserDataSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxUserDataSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getMaxValueLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxValueLength()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxValueLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getMinValueLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMinValueLength()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMinValueLength", "()I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getFieldClassificationAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFieldClassificationAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFieldClassificationAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getFieldClassificationAlgorithmForCategory(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFieldClassificationAlgorithmForCategory(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getFieldClassificationAlgorithmForCategory", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.UserData"/></returns>
            public Android.Service.Autofill.UserData Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.UserData>("build", "()Landroid/service/autofill/UserData;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#add(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Service.Autofill.UserData.Builder"/></returns>
            public Android.Service.Autofill.UserData.Builder Add(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecuteWithSignature<Android.Service.Autofill.UserData.Builder>("add", "(Ljava/lang/String;Ljava/lang/String;)Landroid/service/autofill/UserData$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#setFieldClassificationAlgorithm(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Service.Autofill.UserData.Builder"/></returns>
            public Android.Service.Autofill.UserData.Builder SetFieldClassificationAlgorithm(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                return IExecuteWithSignature<Android.Service.Autofill.UserData.Builder>("setFieldClassificationAlgorithm", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/service/autofill/UserData$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#setFieldClassificationAlgorithmForCategory(java.lang.String,java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Service.Autofill.UserData.Builder"/></returns>
            public Android.Service.Autofill.UserData.Builder SetFieldClassificationAlgorithmForCategory(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
            {
                return IExecuteWithSignature<Android.Service.Autofill.UserData.Builder>("setFieldClassificationAlgorithmForCategory", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/service/autofill/UserData$Builder;", arg0, arg1, arg2);
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