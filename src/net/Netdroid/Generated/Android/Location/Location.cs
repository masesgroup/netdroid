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

namespace Android.Location
{
    #region Location
    public partial class Location
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#%3Cinit%3E(android.location.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Location.Location"/></param>
        public Location(Android.Location.Location arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Location(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#FORMAT_DEGREES"/>
        /// </summary>
        public static int FORMAT_DEGREES { get { if (!_FORMAT_DEGREESReady) { _FORMAT_DEGREESContent = SGetField<int>(LocalBridgeClazz, "FORMAT_DEGREES"); _FORMAT_DEGREESReady = true; } return _FORMAT_DEGREESContent; } }
        private static int _FORMAT_DEGREESContent = default;
        private static bool _FORMAT_DEGREESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#FORMAT_MINUTES"/>
        /// </summary>
        public static int FORMAT_MINUTES { get { if (!_FORMAT_MINUTESReady) { _FORMAT_MINUTESContent = SGetField<int>(LocalBridgeClazz, "FORMAT_MINUTES"); _FORMAT_MINUTESReady = true; } return _FORMAT_MINUTESContent; } }
        private static int _FORMAT_MINUTESContent = default;
        private static bool _FORMAT_MINUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#FORMAT_SECONDS"/>
        /// </summary>
        public static int FORMAT_SECONDS { get { if (!_FORMAT_SECONDSReady) { _FORMAT_SECONDSContent = SGetField<int>(LocalBridgeClazz, "FORMAT_SECONDS"); _FORMAT_SECONDSReady = true; } return _FORMAT_SECONDSContent; } }
        private static int _FORMAT_SECONDSContent = default;
        private static bool _FORMAT_SECONDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#convert(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Convert(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "convert", "(Ljava/lang/String;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#convert(double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Convert(double arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "convert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#distanceBetween(double,double,double,double,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public static void DistanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4)
        {
            SExecute(LocalBridgeClazz, "distanceBetween", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasAccuracy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAccuracy()
        {
            return IExecuteWithSignature<bool>("hasAccuracy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasAltitude()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAltitude()
        {
            return IExecuteWithSignature<bool>("hasAltitude", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasBearing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBearing()
        {
            return IExecuteWithSignature<bool>("hasBearing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasBearingAccuracy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBearingAccuracy()
        {
            return IExecuteWithSignature<bool>("hasBearingAccuracy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasElapsedRealtimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasElapsedRealtimeUncertaintyNanos()
        {
            return IExecuteWithSignature<bool>("hasElapsedRealtimeUncertaintyNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasMslAltitude()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMslAltitude()
        {
            return IExecuteWithSignature<bool>("hasMslAltitude", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasMslAltitudeAccuracy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMslAltitudeAccuracy()
        {
            return IExecuteWithSignature<bool>("hasMslAltitudeAccuracy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasSpeed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSpeed()
        {
            return IExecuteWithSignature<bool>("hasSpeed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasSpeedAccuracy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSpeedAccuracy()
        {
            return IExecuteWithSignature<bool>("hasSpeedAccuracy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#hasVerticalAccuracy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasVerticalAccuracy()
        {
            return IExecuteWithSignature<bool>("hasVerticalAccuracy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#isComplete()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsComplete()
        {
            return IExecuteWithSignature<bool>("isComplete", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#isFromMockProvider()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsFromMockProvider()
        {
            return IExecuteWithSignature<bool>("isFromMockProvider", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#isMock()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMock()
        {
            return IExecuteWithSignature<bool>("isMock", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getAltitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetAltitude()
        {
            return IExecuteWithSignature<double>("getAltitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getElapsedRealtimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetElapsedRealtimeUncertaintyNanos()
        {
            return IExecuteWithSignature<double>("getElapsedRealtimeUncertaintyNanos", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getLatitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLatitude()
        {
            return IExecuteWithSignature<double>("getLatitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getLongitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLongitude()
        {
            return IExecuteWithSignature<double>("getLongitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getMslAltitudeMeters()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetMslAltitudeMeters()
        {
            return IExecuteWithSignature<double>("getMslAltitudeMeters", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#bearingTo(android.location.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Location.Location"/></param>
        /// <returns><see cref="float"/></returns>
        public float BearingTo(Android.Location.Location arg0)
        {
            return IExecuteWithSignature<float>("bearingTo", "(Landroid/location/Location;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#distanceTo(android.location.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Location.Location"/></param>
        /// <returns><see cref="float"/></returns>
        public float DistanceTo(Android.Location.Location arg0)
        {
            return IExecuteWithSignature<float>("distanceTo", "(Landroid/location/Location;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getAccuracy()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetAccuracy()
        {
            return IExecuteWithSignature<float>("getAccuracy", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getBearing()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetBearing()
        {
            return IExecuteWithSignature<float>("getBearing", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getBearingAccuracyDegrees()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetBearingAccuracyDegrees()
        {
            return IExecuteWithSignature<float>("getBearingAccuracyDegrees", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getMslAltitudeAccuracyMeters()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMslAltitudeAccuracyMeters()
        {
            return IExecuteWithSignature<float>("getMslAltitudeAccuracyMeters", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getSpeed()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetSpeed()
        {
            return IExecuteWithSignature<float>("getSpeed", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getSpeedAccuracyMetersPerSecond()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetSpeedAccuracyMetersPerSecond()
        {
            return IExecuteWithSignature<float>("getSpeedAccuracyMetersPerSecond", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getVerticalAccuracyMeters()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetVerticalAccuracyMeters()
        {
            return IExecuteWithSignature<float>("getVerticalAccuracyMeters", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProvider()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProvider", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getElapsedRealtimeAgeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedRealtimeAgeMillis()
        {
            return IExecuteWithSignature<long>("getElapsedRealtimeAgeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getElapsedRealtimeAgeMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedRealtimeAgeMillis(long arg0)
        {
            return IExecuteWithSignature<long>("getElapsedRealtimeAgeMillis", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getElapsedRealtimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedRealtimeMillis()
        {
            return IExecuteWithSignature<long>("getElapsedRealtimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getElapsedRealtimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedRealtimeNanos()
        {
            return IExecuteWithSignature<long>("getElapsedRealtimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#getTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTime()
        {
            return IExecuteWithSignature<long>("getTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeAccuracy()"/>
        /// </summary>
        public void RemoveAccuracy()
        {
            IExecuteWithSignature("removeAccuracy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeAltitude()"/>
        /// </summary>
        public void RemoveAltitude()
        {
            IExecuteWithSignature("removeAltitude", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeBearing()"/>
        /// </summary>
        public void RemoveBearing()
        {
            IExecuteWithSignature("removeBearing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeBearingAccuracy()"/>
        /// </summary>
        public void RemoveBearingAccuracy()
        {
            IExecuteWithSignature("removeBearingAccuracy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeElapsedRealtimeUncertaintyNanos()"/>
        /// </summary>
        public void RemoveElapsedRealtimeUncertaintyNanos()
        {
            IExecuteWithSignature("removeElapsedRealtimeUncertaintyNanos", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeMslAltitude()"/>
        /// </summary>
        public void RemoveMslAltitude()
        {
            IExecuteWithSignature("removeMslAltitude", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeMslAltitudeAccuracy()"/>
        /// </summary>
        public void RemoveMslAltitudeAccuracy()
        {
            IExecuteWithSignature("removeMslAltitudeAccuracy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeSpeed()"/>
        /// </summary>
        public void RemoveSpeed()
        {
            IExecuteWithSignature("removeSpeed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeSpeedAccuracy()"/>
        /// </summary>
        public void RemoveSpeedAccuracy()
        {
            IExecuteWithSignature("removeSpeedAccuracy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#removeVerticalAccuracy()"/>
        /// </summary>
        public void RemoveVerticalAccuracy()
        {
            IExecuteWithSignature("removeVerticalAccuracy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#set(android.location.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Location.Location"/></param>
        public void Set(Android.Location.Location arg0)
        {
            IExecuteWithSignature("set", "(Landroid/location/Location;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setAccuracy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAccuracy(float arg0)
        {
            IExecuteWithSignature("setAccuracy", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setAltitude(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetAltitude(double arg0)
        {
            IExecuteWithSignature("setAltitude", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setBearing(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetBearing(float arg0)
        {
            IExecuteWithSignature("setBearing", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setBearingAccuracyDegrees(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetBearingAccuracyDegrees(float arg0)
        {
            IExecuteWithSignature("setBearingAccuracyDegrees", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setElapsedRealtimeNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetElapsedRealtimeNanos(long arg0)
        {
            IExecuteWithSignature("setElapsedRealtimeNanos", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setElapsedRealtimeUncertaintyNanos(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetElapsedRealtimeUncertaintyNanos(double arg0)
        {
            IExecuteWithSignature("setElapsedRealtimeUncertaintyNanos", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setLatitude(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetLatitude(double arg0)
        {
            IExecuteWithSignature("setLatitude", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setLongitude(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetLongitude(double arg0)
        {
            IExecuteWithSignature("setLongitude", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setMock(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMock(bool arg0)
        {
            IExecuteWithSignature("setMock", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setMslAltitudeAccuracyMeters(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetMslAltitudeAccuracyMeters(float arg0)
        {
            IExecuteWithSignature("setMslAltitudeAccuracyMeters", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setMslAltitudeMeters(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetMslAltitudeMeters(double arg0)
        {
            IExecuteWithSignature("setMslAltitudeMeters", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setProvider(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetProvider(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setProvider", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setSpeed(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetSpeed(float arg0)
        {
            IExecuteWithSignature("setSpeed", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setSpeedAccuracyMetersPerSecond(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetSpeedAccuracyMetersPerSecond(float arg0)
        {
            IExecuteWithSignature("setSpeedAccuracyMetersPerSecond", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetTime(long arg0)
        {
            IExecuteWithSignature("setTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#setVerticalAccuracyMeters(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetVerticalAccuracyMeters(float arg0)
        {
            IExecuteWithSignature("setVerticalAccuracyMeters", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Location.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}