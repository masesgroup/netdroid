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

namespace Android.Location
{
    #region Address
    public partial class Address
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public Address(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#hasLatitude()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLatitude()
        {
            return IExecuteWithSignature<bool>("hasLatitude", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#hasLongitude()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLongitude()
        {
            return IExecuteWithSignature<bool>("hasLongitude", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getLatitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLatitude()
        {
            return IExecuteWithSignature<double>("getLatitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getLongitude()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetLongitude()
        {
            return IExecuteWithSignature<double>("getLongitude", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getMaxAddressLineIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxAddressLineIndex()
        {
            return IExecuteWithSignature<int>("getMaxAddressLineIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getAddressLine(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAddressLine(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAddressLine", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getAdminArea()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAdminArea()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAdminArea", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getCountryCode()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCountryCode()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCountryCode", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getCountryName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCountryName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCountryName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getFeatureName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFeatureName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFeatureName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getLocality()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLocality()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLocality", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getPhone()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPhone()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPhone", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getPostalCode()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPostalCode()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPostalCode", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getPremises()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPremises()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPremises", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getSubAdminArea()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSubAdminArea()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubAdminArea", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getSubLocality()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSubLocality()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubLocality", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getSubThoroughfare()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSubThoroughfare()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubThoroughfare", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getThoroughfare()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetThoroughfare()
        {
            return IExecuteWithSignature<Java.Lang.String>("getThoroughfare", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getUrl()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUrl()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUrl", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#clearLatitude()"/>
        /// </summary>
        public void ClearLatitude()
        {
            IExecuteWithSignature("clearLatitude", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#clearLongitude()"/>
        /// </summary>
        public void ClearLongitude()
        {
            IExecuteWithSignature("clearLongitude", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setAddressLine(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetAddressLine(int arg0, Java.Lang.String arg1)
        {
            IExecute("setAddressLine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setAdminArea(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetAdminArea(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setAdminArea", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setCountryCode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetCountryCode(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setCountryCode", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setCountryName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetCountryName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setCountryName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setFeatureName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetFeatureName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setFeatureName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setLatitude(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetLatitude(double arg0)
        {
            IExecuteWithSignature("setLatitude", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setLocality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetLocality(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setLocality", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setLongitude(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetLongitude(double arg0)
        {
            IExecuteWithSignature("setLongitude", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setPhone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPhone(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPhone", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setPostalCode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPostalCode(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPostalCode", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setPremises(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPremises(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPremises", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setSubAdminArea(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSubAdminArea(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubAdminArea", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setSubLocality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSubLocality(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubLocality", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setSubThoroughfare(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSubThoroughfare(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubThoroughfare", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setThoroughfare(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetThoroughfare(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setThoroughfare", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#setUrl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetUrl(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setUrl", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Address.html#writeToParcel(android.os.Parcel,int)"/>
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