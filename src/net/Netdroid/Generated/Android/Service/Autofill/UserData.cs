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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Autofill
{
    #region UserData
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
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
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
                return IExecute<Android.Service.Autofill.UserData.Builder>("add", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/UserData.Builder.html#setFieldClassificationAlgorithm(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Service.Autofill.UserData.Builder"/></returns>
            public Android.Service.Autofill.UserData.Builder SetFieldClassificationAlgorithm(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                return IExecute<Android.Service.Autofill.UserData.Builder>("setFieldClassificationAlgorithm", arg0, arg1);
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
                return IExecute<Android.Service.Autofill.UserData.Builder>("setFieldClassificationAlgorithmForCategory", arg0, arg1, arg2);
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