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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Location
{
    #region GnssMeasurementRequest
    public partial class GnssMeasurementRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#PASSIVE_INTERVAL"/>
        /// </summary>
        public static int PASSIVE_INTERVAL { get { if (!_PASSIVE_INTERVALReady) { _PASSIVE_INTERVALContent = SGetField<int>(LocalBridgeClazz, "PASSIVE_INTERVAL"); _PASSIVE_INTERVALReady = true; } return _PASSIVE_INTERVALContent; } }
        private static int _PASSIVE_INTERVALContent = default;
        private static bool _PASSIVE_INTERVALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#isFullTracking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullTracking()
        {
            return IExecuteWithSignature<bool>("isFullTracking", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#getIntervalMillis()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIntervalMillis()
        {
            return IExecuteWithSignature<int>("getIntervalMillis", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.Builder.html#%3Cinit%3E(android.location.GnssMeasurementRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssMeasurementRequest"/></param>
            public Builder(Android.Location.GnssMeasurementRequest arg0)
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
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssMeasurementRequest"/></returns>
            public Android.Location.GnssMeasurementRequest Build()
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementRequest>("build", "()Landroid/location/GnssMeasurementRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.Builder.html#setFullTracking(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementRequest.Builder"/></returns>
            public Android.Location.GnssMeasurementRequest.Builder SetFullTracking(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementRequest.Builder>("setFullTracking", "(Z)Landroid/location/GnssMeasurementRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementRequest.Builder.html#setIntervalMillis(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementRequest.Builder"/></returns>
            public Android.Location.GnssMeasurementRequest.Builder SetIntervalMillis(int arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementRequest.Builder>("setIntervalMillis", "(I)Landroid/location/GnssMeasurementRequest$Builder;", arg0);
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