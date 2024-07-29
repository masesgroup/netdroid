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

namespace Android.Telephony
{
    #region SubscriptionPlan
    public partial class SubscriptionPlan
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#LIMIT_BEHAVIOR_BILLED"/>
        /// </summary>
        public static int LIMIT_BEHAVIOR_BILLED { get { if (!_LIMIT_BEHAVIOR_BILLEDReady) { _LIMIT_BEHAVIOR_BILLEDContent = SGetField<int>(LocalBridgeClazz, "LIMIT_BEHAVIOR_BILLED"); _LIMIT_BEHAVIOR_BILLEDReady = true; } return _LIMIT_BEHAVIOR_BILLEDContent; } }
        private static int _LIMIT_BEHAVIOR_BILLEDContent = default;
        private static bool _LIMIT_BEHAVIOR_BILLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#LIMIT_BEHAVIOR_DISABLED"/>
        /// </summary>
        public static int LIMIT_BEHAVIOR_DISABLED { get { if (!_LIMIT_BEHAVIOR_DISABLEDReady) { _LIMIT_BEHAVIOR_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "LIMIT_BEHAVIOR_DISABLED"); _LIMIT_BEHAVIOR_DISABLEDReady = true; } return _LIMIT_BEHAVIOR_DISABLEDContent; } }
        private static int _LIMIT_BEHAVIOR_DISABLEDContent = default;
        private static bool _LIMIT_BEHAVIOR_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#LIMIT_BEHAVIOR_THROTTLED"/>
        /// </summary>
        public static int LIMIT_BEHAVIOR_THROTTLED { get { if (!_LIMIT_BEHAVIOR_THROTTLEDReady) { _LIMIT_BEHAVIOR_THROTTLEDContent = SGetField<int>(LocalBridgeClazz, "LIMIT_BEHAVIOR_THROTTLED"); _LIMIT_BEHAVIOR_THROTTLEDReady = true; } return _LIMIT_BEHAVIOR_THROTTLEDContent; } }
        private static int _LIMIT_BEHAVIOR_THROTTLEDContent = default;
        private static bool _LIMIT_BEHAVIOR_THROTTLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#LIMIT_BEHAVIOR_UNKNOWN"/>
        /// </summary>
        public static int LIMIT_BEHAVIOR_UNKNOWN { get { if (!_LIMIT_BEHAVIOR_UNKNOWNReady) { _LIMIT_BEHAVIOR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "LIMIT_BEHAVIOR_UNKNOWN"); _LIMIT_BEHAVIOR_UNKNOWNReady = true; } return _LIMIT_BEHAVIOR_UNKNOWNContent; } }
        private static int _LIMIT_BEHAVIOR_UNKNOWNContent = default;
        private static bool _LIMIT_BEHAVIOR_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#BYTES_UNKNOWN"/>
        /// </summary>
        public static long BYTES_UNKNOWN { get { if (!_BYTES_UNKNOWNReady) { _BYTES_UNKNOWNContent = SGetField<long>(LocalBridgeClazz, "BYTES_UNKNOWN"); _BYTES_UNKNOWNReady = true; } return _BYTES_UNKNOWNContent; } }
        private static long _BYTES_UNKNOWNContent = default;
        private static bool _BYTES_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#BYTES_UNLIMITED"/>
        /// </summary>
        public static long BYTES_UNLIMITED { get { if (!_BYTES_UNLIMITEDReady) { _BYTES_UNLIMITEDContent = SGetField<long>(LocalBridgeClazz, "BYTES_UNLIMITED"); _BYTES_UNLIMITEDReady = true; } return _BYTES_UNLIMITEDContent; } }
        private static long _BYTES_UNLIMITEDContent = default;
        private static bool _BYTES_UNLIMITEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#TIME_UNKNOWN"/>
        /// </summary>
        public static long TIME_UNKNOWN { get { if (!_TIME_UNKNOWNReady) { _TIME_UNKNOWNContent = SGetField<long>(LocalBridgeClazz, "TIME_UNKNOWN"); _TIME_UNKNOWNReady = true; } return _TIME_UNKNOWNContent; } }
        private static long _TIME_UNKNOWNContent = default;
        private static bool _TIME_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getDataLimitBehavior()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDataLimitBehavior()
        {
            return IExecuteWithSignature<int>("getDataLimitBehavior", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getNetworkTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetNetworkTypes()
        {
            return IExecuteWithSignatureArray<int>("getNetworkTypes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getSummary()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSummary()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSummary", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getDataLimitBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDataLimitBytes()
        {
            return IExecuteWithSignature<long>("getDataLimitBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getDataUsageBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDataUsageBytes()
        {
            return IExecuteWithSignature<long>("getDataUsageBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#getDataUsageTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDataUsageTime()
        {
            return IExecuteWithSignature<long>("getDataUsageTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#createNonrecurring(java.time.ZonedDateTime,java.time.ZonedDateTime)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZonedDateTime"/></param>
            /// <param name="arg1"><see cref="Java.Time.ZonedDateTime"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public static Android.Telephony.SubscriptionPlan.Builder CreateNonrecurring(Java.Time.ZonedDateTime arg0, Java.Time.ZonedDateTime arg1)
            {
                return SExecute<Android.Telephony.SubscriptionPlan.Builder>(LocalBridgeClazz, "createNonrecurring", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#createRecurring(java.time.ZonedDateTime,java.time.Period)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZonedDateTime"/></param>
            /// <param name="arg1"><see cref="Java.Time.Period"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public static Android.Telephony.SubscriptionPlan.Builder CreateRecurring(Java.Time.ZonedDateTime arg0, Java.Time.Period arg1)
            {
                return SExecute<Android.Telephony.SubscriptionPlan.Builder>(LocalBridgeClazz, "createRecurring", arg0, arg1);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan"/></returns>
            public Android.Telephony.SubscriptionPlan Build()
            {
                return IExecuteWithSignature<Android.Telephony.SubscriptionPlan>("build", "()Landroid/telephony/SubscriptionPlan;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#resetNetworkTypes()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder ResetNetworkTypes()
            {
                return IExecuteWithSignature<Android.Telephony.SubscriptionPlan.Builder>("resetNetworkTypes", "()Landroid/telephony/SubscriptionPlan$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#setDataLimit(long,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder SetDataLimit(long arg0, int arg1)
            {
                return IExecute<Android.Telephony.SubscriptionPlan.Builder>("setDataLimit", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#setDataUsage(long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder SetDataUsage(long arg0, long arg1)
            {
                return IExecute<Android.Telephony.SubscriptionPlan.Builder>("setDataUsage", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#setNetworkTypes(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder SetNetworkTypes(int[] arg0)
            {
                return IExecuteWithSignature<Android.Telephony.SubscriptionPlan.Builder>("setNetworkTypes", "([I)Landroid/telephony/SubscriptionPlan$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#setSummary(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder SetSummary(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Telephony.SubscriptionPlan.Builder>("setSummary", "(Ljava/lang/CharSequence;)Landroid/telephony/SubscriptionPlan$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionPlan.Builder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Telephony.SubscriptionPlan.Builder"/></returns>
            public Android.Telephony.SubscriptionPlan.Builder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Telephony.SubscriptionPlan.Builder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/telephony/SubscriptionPlan$Builder;", arg0);
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