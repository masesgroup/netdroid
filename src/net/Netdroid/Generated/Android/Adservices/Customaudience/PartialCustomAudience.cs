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

namespace Android.Adservices.Customaudience
{
    #region PartialCustomAudience
    public partial class PartialCustomAudience
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#getUserBiddingSignals()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdSelectionSignals"/></returns>
        public Android.Adservices.Common.AdSelectionSignals GetUserBiddingSignals()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdSelectionSignals>("getUserBiddingSignals", "()Landroid/adservices/common/AdSelectionSignals;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#getActivationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetActivationTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getActivationTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#getExpirationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetExpirationTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getExpirationTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
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
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Customaudience.PartialCustomAudience"/></returns>
            public Android.Adservices.Customaudience.PartialCustomAudience Build()
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.PartialCustomAudience>("build", "()Landroid/adservices/customaudience/PartialCustomAudience;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.Builder.html#setActivationTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.PartialCustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.PartialCustomAudience.Builder SetActivationTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.PartialCustomAudience.Builder>("setActivationTime", "(Ljava/time/Instant;)Landroid/adservices/customaudience/PartialCustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.Builder.html#setExpirationTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.PartialCustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.PartialCustomAudience.Builder SetExpirationTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.PartialCustomAudience.Builder>("setExpirationTime", "(Ljava/time/Instant;)Landroid/adservices/customaudience/PartialCustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/PartialCustomAudience.Builder.html#setUserBiddingSignals(android.adservices.common.AdSelectionSignals)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.PartialCustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.PartialCustomAudience.Builder SetUserBiddingSignals(Android.Adservices.Common.AdSelectionSignals arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.PartialCustomAudience.Builder>("setUserBiddingSignals", "(Landroid/adservices/common/AdSelectionSignals;)Landroid/adservices/customaudience/PartialCustomAudience$Builder;", arg0);
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