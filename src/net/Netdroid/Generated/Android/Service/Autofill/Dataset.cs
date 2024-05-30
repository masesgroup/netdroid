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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Autofill
{
    #region Dataset
    public partial class Dataset
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#%3Cinit%3E(android.service.autofill.Presentations)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Presentations"/></param>
            public Builder(Android.Service.Autofill.Presentations arg0)
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.Dataset"/></returns>
            public Android.Service.Autofill.Dataset Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset>("build", "()Landroid/service/autofill/Dataset;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setAuthentication(android.content.IntentSender)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetAuthentication(Android.Content.IntentSender arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setAuthentication", "(Landroid/content/IntentSender;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setField(android.view.autofill.AutofillId,android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetField(Android.View.Autofill.AutofillId arg0, Android.Service.Autofill.Field arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setField", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setField(java.lang.String,android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetField(Java.Lang.String arg0, Android.Service.Autofill.Field arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setField", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setFieldForAllHints(android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetFieldForAllHints(Android.Service.Autofill.Field arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setFieldForAllHints", "(Landroid/service/autofill/Field;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setId", "(Ljava/lang/String;)Landroid/service/autofill/Dataset$Builder;", arg0);
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