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

namespace Android.Telephony
{
    #region AvailableNetworkInfo
    public partial class AvailableNetworkInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#%3Cinit%3E(int,int,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public AvailableNetworkInfo(int arg0, int arg1, Java.Util.List<Java.Lang.String> arg2, Java.Util.List<Java.Lang.Integer> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#PRIORITY_HIGH"/>
        /// </summary>
        public static int PRIORITY_HIGH { get { if (!_PRIORITY_HIGHReady) { _PRIORITY_HIGHContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_HIGH"); _PRIORITY_HIGHReady = true; } return _PRIORITY_HIGHContent; } }
        private static int _PRIORITY_HIGHContent = default;
        private static bool _PRIORITY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#PRIORITY_LOW"/>
        /// </summary>
        public static int PRIORITY_LOW { get { if (!_PRIORITY_LOWReady) { _PRIORITY_LOWContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_LOW"); _PRIORITY_LOWReady = true; } return _PRIORITY_LOWContent; } }
        private static int _PRIORITY_LOWContent = default;
        private static bool _PRIORITY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#PRIORITY_MED"/>
        /// </summary>
        public static int PRIORITY_MED { get { if (!_PRIORITY_MEDReady) { _PRIORITY_MEDContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_MED"); _PRIORITY_MEDReady = true; } return _PRIORITY_MEDContent; } }
        private static int _PRIORITY_MEDContent = default;
        private static bool _PRIORITY_MEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#getPriority()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriority()
        {
            return IExecuteWithSignature<int>("getPriority", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#getSubId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubId()
        {
            return IExecuteWithSignature<int>("getSubId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#getRadioAccessSpecifiers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telephony.RadioAccessSpecifier> GetRadioAccessSpecifiers()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telephony.RadioAccessSpecifier>>("getRadioAccessSpecifiers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#getBands()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetBands()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getBands", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#getMccMncs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetMccMncs()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getMccMncs", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.AvailableNetworkInfo"/></returns>
            public Android.Telephony.AvailableNetworkInfo Build()
            {
                return IExecuteWithSignature<Android.Telephony.AvailableNetworkInfo>("build", "()Landroid/telephony/AvailableNetworkInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.Builder.html#setMccMncs(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Telephony.AvailableNetworkInfo.Builder"/></returns>
            public Android.Telephony.AvailableNetworkInfo.Builder SetMccMncs(Java.Util.List<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.Telephony.AvailableNetworkInfo.Builder>("setMccMncs", "(Ljava/util/List;)Landroid/telephony/AvailableNetworkInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.Builder.html#setPriority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.AvailableNetworkInfo.Builder"/></returns>
            public Android.Telephony.AvailableNetworkInfo.Builder SetPriority(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.AvailableNetworkInfo.Builder>("setPriority", "(I)Landroid/telephony/AvailableNetworkInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/AvailableNetworkInfo.Builder.html#setRadioAccessSpecifiers(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Telephony.AvailableNetworkInfo.Builder"/></returns>
            public Android.Telephony.AvailableNetworkInfo.Builder SetRadioAccessSpecifiers(Java.Util.List<Android.Telephony.RadioAccessSpecifier> arg0)
            {
                return IExecuteWithSignature<Android.Telephony.AvailableNetworkInfo.Builder>("setRadioAccessSpecifiers", "(Ljava/util/List;)Landroid/telephony/AvailableNetworkInfo$Builder;", arg0);
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