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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Location
{
    #region LocationRequest
    public partial class LocationRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#QUALITY_BALANCED_POWER_ACCURACY"/>
        /// </summary>
        public static int QUALITY_BALANCED_POWER_ACCURACY { get { if (!_QUALITY_BALANCED_POWER_ACCURACYReady) { _QUALITY_BALANCED_POWER_ACCURACYContent = SGetField<int>(LocalBridgeClazz, "QUALITY_BALANCED_POWER_ACCURACY"); _QUALITY_BALANCED_POWER_ACCURACYReady = true; } return _QUALITY_BALANCED_POWER_ACCURACYContent; } }
        private static int _QUALITY_BALANCED_POWER_ACCURACYContent = default;
        private static bool _QUALITY_BALANCED_POWER_ACCURACYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#QUALITY_HIGH_ACCURACY"/>
        /// </summary>
        public static int QUALITY_HIGH_ACCURACY { get { if (!_QUALITY_HIGH_ACCURACYReady) { _QUALITY_HIGH_ACCURACYContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_ACCURACY"); _QUALITY_HIGH_ACCURACYReady = true; } return _QUALITY_HIGH_ACCURACYContent; } }
        private static int _QUALITY_HIGH_ACCURACYContent = default;
        private static bool _QUALITY_HIGH_ACCURACYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#QUALITY_LOW_POWER"/>
        /// </summary>
        public static int QUALITY_LOW_POWER { get { if (!_QUALITY_LOW_POWERReady) { _QUALITY_LOW_POWERContent = SGetField<int>(LocalBridgeClazz, "QUALITY_LOW_POWER"); _QUALITY_LOW_POWERReady = true; } return _QUALITY_LOW_POWERContent; } }
        private static int _QUALITY_LOW_POWERContent = default;
        private static bool _QUALITY_LOW_POWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#PASSIVE_INTERVAL"/>
        /// </summary>
        public static long PASSIVE_INTERVAL { get { if (!_PASSIVE_INTERVALReady) { _PASSIVE_INTERVALContent = SGetField<long>(LocalBridgeClazz, "PASSIVE_INTERVAL"); _PASSIVE_INTERVALReady = true; } return _PASSIVE_INTERVALContent; } }
        private static long _PASSIVE_INTERVALContent = default;
        private static bool _PASSIVE_INTERVALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getMinUpdateDistanceMeters()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMinUpdateDistanceMeters()
        {
            return IExecuteWithSignature<float>("getMinUpdateDistanceMeters", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getMaxUpdates()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxUpdates()
        {
            return IExecuteWithSignature<int>("getMaxUpdates", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getQuality()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetQuality()
        {
            return IExecuteWithSignature<int>("getQuality", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getDurationMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDurationMillis()
        {
            return IExecuteWithSignature<long>("getDurationMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getIntervalMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetIntervalMillis()
        {
            return IExecuteWithSignature<long>("getIntervalMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getMaxUpdateDelayMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMaxUpdateDelayMillis()
        {
            return IExecuteWithSignature<long>("getMaxUpdateDelayMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#getMinUpdateIntervalMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMinUpdateIntervalMillis()
        {
            return IExecuteWithSignature<long>("getMinUpdateIntervalMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/LocationRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#%3Cinit%3E(android.location.LocationRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.LocationRequest"/></param>
            public Builder(Android.Location.LocationRequest arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#%3Cinit%3E(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public Builder(long arg0)
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
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.LocationRequest"/></returns>
            public Android.Location.LocationRequest Build()
            {
                return IExecuteWithSignature<Android.Location.LocationRequest>("build", "()Landroid/location/LocationRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#clearMinUpdateIntervalMillis()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder ClearMinUpdateIntervalMillis()
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("clearMinUpdateIntervalMillis", "()Landroid/location/LocationRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setDurationMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetDurationMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setDurationMillis", "(J)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setIntervalMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetIntervalMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setIntervalMillis", "(J)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setMaxUpdateDelayMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetMaxUpdateDelayMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setMaxUpdateDelayMillis", "(J)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setMaxUpdates(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetMaxUpdates(int arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setMaxUpdates", "(I)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setMinUpdateDistanceMeters(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetMinUpdateDistanceMeters(float arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setMinUpdateDistanceMeters", "(F)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setMinUpdateIntervalMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetMinUpdateIntervalMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setMinUpdateIntervalMillis", "(J)Landroid/location/LocationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/LocationRequest.Builder.html#setQuality(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Location.LocationRequest.Builder"/></returns>
            public Android.Location.LocationRequest.Builder SetQuality(int arg0)
            {
                return IExecuteWithSignature<Android.Location.LocationRequest.Builder>("setQuality", "(I)Landroid/location/LocationRequest$Builder;", arg0);
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