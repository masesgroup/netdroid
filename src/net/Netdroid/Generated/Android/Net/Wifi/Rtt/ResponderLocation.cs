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

namespace Android.Net.Wifi.Rtt
{
    #region ResponderLocation
    public partial class ResponderLocation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#ALTITUDE_FLOORS"/>
        /// </summary>
        public static int ALTITUDE_FLOORS { get { if (!_ALTITUDE_FLOORSReady) { _ALTITUDE_FLOORSContent = SGetField<int>(LocalBridgeClazz, "ALTITUDE_FLOORS"); _ALTITUDE_FLOORSReady = true; } return _ALTITUDE_FLOORSContent; } }
        private static int _ALTITUDE_FLOORSContent = default;
        private static bool _ALTITUDE_FLOORSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#ALTITUDE_METERS"/>
        /// </summary>
        public static int ALTITUDE_METERS { get { if (!_ALTITUDE_METERSReady) { _ALTITUDE_METERSContent = SGetField<int>(LocalBridgeClazz, "ALTITUDE_METERS"); _ALTITUDE_METERSReady = true; } return _ALTITUDE_METERSContent; } }
        private static int _ALTITUDE_METERSContent = default;
        private static bool _ALTITUDE_METERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#ALTITUDE_UNDEFINED"/>
        /// </summary>
        public static int ALTITUDE_UNDEFINED { get { if (!_ALTITUDE_UNDEFINEDReady) { _ALTITUDE_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "ALTITUDE_UNDEFINED"); _ALTITUDE_UNDEFINEDReady = true; } return _ALTITUDE_UNDEFINEDContent; } }
        private static int _ALTITUDE_UNDEFINEDContent = default;
        private static bool _ALTITUDE_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#DATUM_NAD83_MLLW"/>
        /// </summary>
        public static int DATUM_NAD83_MLLW { get { if (!_DATUM_NAD83_MLLWReady) { _DATUM_NAD83_MLLWContent = SGetField<int>(LocalBridgeClazz, "DATUM_NAD83_MLLW"); _DATUM_NAD83_MLLWReady = true; } return _DATUM_NAD83_MLLWContent; } }
        private static int _DATUM_NAD83_MLLWContent = default;
        private static bool _DATUM_NAD83_MLLWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#DATUM_NAD83_NAV88"/>
        /// </summary>
        public static int DATUM_NAD83_NAV88 { get { if (!_DATUM_NAD83_NAV88Ready) { _DATUM_NAD83_NAV88Content = SGetField<int>(LocalBridgeClazz, "DATUM_NAD83_NAV88"); _DATUM_NAD83_NAV88Ready = true; } return _DATUM_NAD83_NAV88Content; } }
        private static int _DATUM_NAD83_NAV88Content = default;
        private static bool _DATUM_NAD83_NAV88Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#DATUM_UNDEFINED"/>
        /// </summary>
        public static int DATUM_UNDEFINED { get { if (!_DATUM_UNDEFINEDReady) { _DATUM_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "DATUM_UNDEFINED"); _DATUM_UNDEFINEDReady = true; } return _DATUM_UNDEFINEDContent; } }
        private static int _DATUM_UNDEFINEDContent = default;
        private static bool _DATUM_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#DATUM_WGS84"/>
        /// </summary>
        public static int DATUM_WGS84 { get { if (!_DATUM_WGS84Ready) { _DATUM_WGS84Content = SGetField<int>(LocalBridgeClazz, "DATUM_WGS84"); _DATUM_WGS84Ready = true; } return _DATUM_WGS84Content; } }
        private static int _DATUM_WGS84Content = default;
        private static bool _DATUM_WGS84Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#LCI_VERSION_1"/>
        /// </summary>
        public static int LCI_VERSION_1 { get { if (!_LCI_VERSION_1Ready) { _LCI_VERSION_1Content = SGetField<int>(LocalBridgeClazz, "LCI_VERSION_1"); _LCI_VERSION_1Ready = true; } return _LCI_VERSION_1Content; } }
        private static int _LCI_VERSION_1Content = default;
        private static bool _LCI_VERSION_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#LOCATION_FIXED"/>
        /// </summary>
        public static int LOCATION_FIXED { get { if (!_LOCATION_FIXEDReady) { _LOCATION_FIXEDContent = SGetField<int>(LocalBridgeClazz, "LOCATION_FIXED"); _LOCATION_FIXEDReady = true; } return _LOCATION_FIXEDContent; } }
        private static int _LOCATION_FIXEDContent = default;
        private static bool _LOCATION_FIXEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#LOCATION_MOVEMENT_UNKNOWN"/>
        /// </summary>
        public static int LOCATION_MOVEMENT_UNKNOWN { get { if (!_LOCATION_MOVEMENT_UNKNOWNReady) { _LOCATION_MOVEMENT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MOVEMENT_UNKNOWN"); _LOCATION_MOVEMENT_UNKNOWNReady = true; } return _LOCATION_MOVEMENT_UNKNOWNContent; } }
        private static int _LOCATION_MOVEMENT_UNKNOWNContent = default;
        private static bool _LOCATION_MOVEMENT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#LOCATION_RESERVED"/>
        /// </summary>
        public static int LOCATION_RESERVED { get { if (!_LOCATION_RESERVEDReady) { _LOCATION_RESERVEDContent = SGetField<int>(LocalBridgeClazz, "LOCATION_RESERVED"); _LOCATION_RESERVEDReady = true; } return _LOCATION_RESERVEDContent; } }
        private static int _LOCATION_RESERVEDContent = default;
        private static bool _LOCATION_RESERVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#LOCATION_VARIABLE"/>
        /// </summary>
        public static int LOCATION_VARIABLE { get { if (!_LOCATION_VARIABLEReady) { _LOCATION_VARIABLEContent = SGetField<int>(LocalBridgeClazz, "LOCATION_VARIABLE"); _LOCATION_VARIABLEReady = true; } return _LOCATION_VARIABLEContent; } }
        private static int _LOCATION_VARIABLEContent = default;
        private static bool _LOCATION_VARIABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#toCivicLocationAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Location.Address"/></returns>
        public Android.Location.Address ToCivicLocationAddress()
        {
            return IExecuteWithSignature<Android.Location.Address>("toCivicLocationAddress", "()Landroid/location/Address;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#toLocation()"/>
        /// </summary>
        /// <returns><see cref="Android.Location.Location"/></returns>
        public Android.Location.Location ToLocation()
        {
            return IExecuteWithSignature<Android.Location.Location>("toLocation", "()Landroid/location/Location;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getMapImageUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetMapImageUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getMapImageUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#toCivicLocationSparseArray()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<Java.Lang.String> ToCivicLocationSparseArray()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<Java.Lang.String>>("toCivicLocationSparseArray", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getRegisteredLocationAgreementIndication()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetRegisteredLocationAgreementIndication()
        {
            return IExecuteWithSignature<bool>("getRegisteredLocationAgreementIndication", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#isLciSubelementValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLciSubelementValid()
        {
            return IExecuteWithSignature<bool>("isLciSubelementValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#isZaxisSubelementValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsZaxisSubelementValid()
        {
            return IExecuteWithSignature<bool>("isZaxisSubelementValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getAltitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetAltitude()
        {
            return IExecuteWithSignature<double>("getAltitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getAltitudeUncertainty()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetAltitudeUncertainty()
        {
            return IExecuteWithSignature<double>("getAltitudeUncertainty", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getFloorNumber()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetFloorNumber()
        {
            return IExecuteWithSignature<double>("getFloorNumber", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getHeightAboveFloorMeters()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetHeightAboveFloorMeters()
        {
            return IExecuteWithSignature<double>("getHeightAboveFloorMeters", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getHeightAboveFloorUncertaintyMeters()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetHeightAboveFloorUncertaintyMeters()
        {
            return IExecuteWithSignature<double>("getHeightAboveFloorUncertaintyMeters", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getLatitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLatitude()
        {
            return IExecuteWithSignature<double>("getLatitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getLatitudeUncertainty()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLatitudeUncertainty()
        {
            return IExecuteWithSignature<double>("getLatitudeUncertainty", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getLongitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLongitude()
        {
            return IExecuteWithSignature<double>("getLongitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getLongitudeUncertainty()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLongitudeUncertainty()
        {
            return IExecuteWithSignature<double>("getLongitudeUncertainty", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getAltitudeType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAltitudeType()
        {
            return IExecuteWithSignature<int>("getAltitudeType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getDatum()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDatum()
        {
            return IExecuteWithSignature<int>("getDatum", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getExpectedToMove()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetExpectedToMove()
        {
            return IExecuteWithSignature<int>("getExpectedToMove", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getLciVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLciVersion()
        {
            return IExecuteWithSignature<int>("getLciVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getMapImageMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMapImageMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMapImageMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#getColocatedBssids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.MacAddress> GetColocatedBssids()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.MacAddress>>("getColocatedBssids", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderLocation.html#writeToParcel(android.os.Parcel,int)"/>
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