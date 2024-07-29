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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Measurement
{
    #region WebSourceParams
    public partial class WebSourceParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.html#getRegistrationUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetRegistrationUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getRegistrationUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.html#isDebugKeyAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDebugKeyAllowed()
        {
            return IExecuteWithSignature<bool>("isDebugKeyAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.Builder.html#%3Cinit%3E(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            public Builder(Android.Net.Uri arg0)
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
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceParams"/></returns>
            public Android.Adservices.Measurement.WebSourceParams Build()
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceParams>("build", "()Landroid/adservices/measurement/WebSourceParams;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceParams.Builder.html#setDebugKeyAllowed(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceParams.Builder"/></returns>
            public Android.Adservices.Measurement.WebSourceParams.Builder SetDebugKeyAllowed(bool arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceParams.Builder>("setDebugKeyAllowed", "(Z)Landroid/adservices/measurement/WebSourceParams$Builder;", arg0);
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