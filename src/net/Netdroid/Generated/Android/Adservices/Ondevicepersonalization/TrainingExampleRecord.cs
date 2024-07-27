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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Ondevicepersonalization
{
    #region TrainingExampleRecord
    public partial class TrainingExampleRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.html#getResumptionToken()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetResumptionToken()
        {
            return IExecuteWithSignatureArray<byte>("getResumptionToken", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.html#getTrainingExample()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetTrainingExample()
        {
            return IExecuteWithSignatureArray<byte>("getTrainingExample", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExampleRecord"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExampleRecord Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord>("build", "()Landroid/adservices/ondevicepersonalization/TrainingExampleRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.Builder.html#setResumptionToken(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder SetResumptionToken(params byte[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder>("setResumptionToken", "([B)Landroid/adservices/ondevicepersonalization/TrainingExampleRecord$Builder;"); else return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder>("setResumptionToken", "([B)Landroid/adservices/ondevicepersonalization/TrainingExampleRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExampleRecord.Builder.html#setTrainingExample(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder SetTrainingExample(params byte[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder>("setTrainingExample", "([B)Landroid/adservices/ondevicepersonalization/TrainingExampleRecord$Builder;"); else return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord.Builder>("setTrainingExample", "([B)Landroid/adservices/ondevicepersonalization/TrainingExampleRecord$Builder;", arg0);
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