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

namespace Android.Adservices.Common
{
    #region FrequencyCapFilters
    public partial class FrequencyCapFilters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#AD_EVENT_TYPE_CLICK"/>
        /// </summary>
        public static int AD_EVENT_TYPE_CLICK { get { if (!_AD_EVENT_TYPE_CLICKReady) { _AD_EVENT_TYPE_CLICKContent = SGetField<int>(LocalBridgeClazz, "AD_EVENT_TYPE_CLICK"); _AD_EVENT_TYPE_CLICKReady = true; } return _AD_EVENT_TYPE_CLICKContent; } }
        private static int _AD_EVENT_TYPE_CLICKContent = default;
        private static bool _AD_EVENT_TYPE_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#AD_EVENT_TYPE_IMPRESSION"/>
        /// </summary>
        public static int AD_EVENT_TYPE_IMPRESSION { get { if (!_AD_EVENT_TYPE_IMPRESSIONReady) { _AD_EVENT_TYPE_IMPRESSIONContent = SGetField<int>(LocalBridgeClazz, "AD_EVENT_TYPE_IMPRESSION"); _AD_EVENT_TYPE_IMPRESSIONReady = true; } return _AD_EVENT_TYPE_IMPRESSIONContent; } }
        private static int _AD_EVENT_TYPE_IMPRESSIONContent = default;
        private static bool _AD_EVENT_TYPE_IMPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#AD_EVENT_TYPE_VIEW"/>
        /// </summary>
        public static int AD_EVENT_TYPE_VIEW { get { if (!_AD_EVENT_TYPE_VIEWReady) { _AD_EVENT_TYPE_VIEWContent = SGetField<int>(LocalBridgeClazz, "AD_EVENT_TYPE_VIEW"); _AD_EVENT_TYPE_VIEWReady = true; } return _AD_EVENT_TYPE_VIEWContent; } }
        private static int _AD_EVENT_TYPE_VIEWContent = default;
        private static bool _AD_EVENT_TYPE_VIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#AD_EVENT_TYPE_WIN"/>
        /// </summary>
        public static int AD_EVENT_TYPE_WIN { get { if (!_AD_EVENT_TYPE_WINReady) { _AD_EVENT_TYPE_WINContent = SGetField<int>(LocalBridgeClazz, "AD_EVENT_TYPE_WIN"); _AD_EVENT_TYPE_WINReady = true; } return _AD_EVENT_TYPE_WINContent; } }
        private static int _AD_EVENT_TYPE_WINContent = default;
        private static bool _AD_EVENT_TYPE_WINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#getKeyedFrequencyCapsForClickEvents()"/> 
        /// </summary>
        public Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> KeyedFrequencyCapsForClickEvents
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap>>("getKeyedFrequencyCapsForClickEvents", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#getKeyedFrequencyCapsForImpressionEvents()"/> 
        /// </summary>
        public Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> KeyedFrequencyCapsForImpressionEvents
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap>>("getKeyedFrequencyCapsForImpressionEvents", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#getKeyedFrequencyCapsForViewEvents()"/> 
        /// </summary>
        public Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> KeyedFrequencyCapsForViewEvents
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap>>("getKeyedFrequencyCapsForViewEvents", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#getKeyedFrequencyCapsForWinEvents()"/> 
        /// </summary>
        public Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> KeyedFrequencyCapsForWinEvents
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap>>("getKeyedFrequencyCapsForWinEvents", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Common.FrequencyCapFilters"/></returns>
            public Android.Adservices.Common.FrequencyCapFilters Build()
            {
                return IExecuteWithSignature<Android.Adservices.Common.FrequencyCapFilters>("build", "()Landroid/adservices/common/FrequencyCapFilters;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.Builder.html#setKeyedFrequencyCapsForClickEvents(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Common.FrequencyCapFilters.Builder"/></returns>
            public Android.Adservices.Common.FrequencyCapFilters.Builder SetKeyedFrequencyCapsForClickEvents(Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Common.FrequencyCapFilters.Builder>("setKeyedFrequencyCapsForClickEvents", "(Ljava/util/List;)Landroid/adservices/common/FrequencyCapFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.Builder.html#setKeyedFrequencyCapsForImpressionEvents(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Common.FrequencyCapFilters.Builder"/></returns>
            public Android.Adservices.Common.FrequencyCapFilters.Builder SetKeyedFrequencyCapsForImpressionEvents(Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Common.FrequencyCapFilters.Builder>("setKeyedFrequencyCapsForImpressionEvents", "(Ljava/util/List;)Landroid/adservices/common/FrequencyCapFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.Builder.html#setKeyedFrequencyCapsForViewEvents(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Common.FrequencyCapFilters.Builder"/></returns>
            public Android.Adservices.Common.FrequencyCapFilters.Builder SetKeyedFrequencyCapsForViewEvents(Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Common.FrequencyCapFilters.Builder>("setKeyedFrequencyCapsForViewEvents", "(Ljava/util/List;)Landroid/adservices/common/FrequencyCapFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/common/FrequencyCapFilters.Builder.html#setKeyedFrequencyCapsForWinEvents(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Common.FrequencyCapFilters.Builder"/></returns>
            public Android.Adservices.Common.FrequencyCapFilters.Builder SetKeyedFrequencyCapsForWinEvents(Java.Util.List<Android.Adservices.Common.KeyedFrequencyCap> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Common.FrequencyCapFilters.Builder>("setKeyedFrequencyCapsForWinEvents", "(Ljava/util/List;)Landroid/adservices/common/FrequencyCapFilters$Builder;", arg0);
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