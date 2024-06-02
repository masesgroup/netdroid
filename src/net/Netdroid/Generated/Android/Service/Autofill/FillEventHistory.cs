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

namespace Android.Service.Autofill
{
    #region FillEventHistory
    public partial class FillEventHistory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.html#getClientState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Bundle GetClientState()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getClientState", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.html#getEvents()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Service.Autofill.FillEventHistory.Event> GetEvents()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Service.Autofill.FillEventHistory.Event>>("getEvents", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Event
        public partial class Event
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_DATASET_MATCH"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_DATASET_MATCH { get { if (!_NO_SAVE_UI_REASON_DATASET_MATCHReady) { _NO_SAVE_UI_REASON_DATASET_MATCHContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_DATASET_MATCH"); _NO_SAVE_UI_REASON_DATASET_MATCHReady = true; } return _NO_SAVE_UI_REASON_DATASET_MATCHContent; } }
            private static int _NO_SAVE_UI_REASON_DATASET_MATCHContent = default;
            private static bool _NO_SAVE_UI_REASON_DATASET_MATCHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILED"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILED { get { if (!_NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDReady) { _NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILED"); _NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDReady = true; } return _NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDContent; } }
            private static int _NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDContent = default;
            private static bool _NO_SAVE_UI_REASON_FIELD_VALIDATION_FAILEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_HAS_EMPTY_REQUIRED"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_HAS_EMPTY_REQUIRED { get { if (!_NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDReady) { _NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_HAS_EMPTY_REQUIRED"); _NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDReady = true; } return _NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDContent; } }
            private static int _NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDContent = default;
            private static bool _NO_SAVE_UI_REASON_HAS_EMPTY_REQUIREDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_NO_SAVE_INFO"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_NO_SAVE_INFO { get { if (!_NO_SAVE_UI_REASON_NO_SAVE_INFOReady) { _NO_SAVE_UI_REASON_NO_SAVE_INFOContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_NO_SAVE_INFO"); _NO_SAVE_UI_REASON_NO_SAVE_INFOReady = true; } return _NO_SAVE_UI_REASON_NO_SAVE_INFOContent; } }
            private static int _NO_SAVE_UI_REASON_NO_SAVE_INFOContent = default;
            private static bool _NO_SAVE_UI_REASON_NO_SAVE_INFOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_NO_VALUE_CHANGED"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_NO_VALUE_CHANGED { get { if (!_NO_SAVE_UI_REASON_NO_VALUE_CHANGEDReady) { _NO_SAVE_UI_REASON_NO_VALUE_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_NO_VALUE_CHANGED"); _NO_SAVE_UI_REASON_NO_VALUE_CHANGEDReady = true; } return _NO_SAVE_UI_REASON_NO_VALUE_CHANGEDContent; } }
            private static int _NO_SAVE_UI_REASON_NO_VALUE_CHANGEDContent = default;
            private static bool _NO_SAVE_UI_REASON_NO_VALUE_CHANGEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_NONE"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_NONE { get { if (!_NO_SAVE_UI_REASON_NONEReady) { _NO_SAVE_UI_REASON_NONEContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_NONE"); _NO_SAVE_UI_REASON_NONEReady = true; } return _NO_SAVE_UI_REASON_NONEContent; } }
            private static int _NO_SAVE_UI_REASON_NONEContent = default;
            private static bool _NO_SAVE_UI_REASON_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAG"/>
            /// </summary>
            public static int NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAG { get { if (!_NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGReady) { _NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGContent = SGetField<int>(LocalBridgeClazz, "NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAG"); _NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGReady = true; } return _NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGContent; } }
            private static int _NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGContent = default;
            private static bool _NO_SAVE_UI_REASON_WITH_DELAY_SAVE_FLAGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_AUTHENTICATION_SELECTED"/>
            /// </summary>
            public static int TYPE_AUTHENTICATION_SELECTED { get { if (!_TYPE_AUTHENTICATION_SELECTEDReady) { _TYPE_AUTHENTICATION_SELECTEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_AUTHENTICATION_SELECTED"); _TYPE_AUTHENTICATION_SELECTEDReady = true; } return _TYPE_AUTHENTICATION_SELECTEDContent; } }
            private static int _TYPE_AUTHENTICATION_SELECTEDContent = default;
            private static bool _TYPE_AUTHENTICATION_SELECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_CONTEXT_COMMITTED"/>
            /// </summary>
            public static int TYPE_CONTEXT_COMMITTED { get { if (!_TYPE_CONTEXT_COMMITTEDReady) { _TYPE_CONTEXT_COMMITTEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_CONTEXT_COMMITTED"); _TYPE_CONTEXT_COMMITTEDReady = true; } return _TYPE_CONTEXT_COMMITTEDContent; } }
            private static int _TYPE_CONTEXT_COMMITTEDContent = default;
            private static bool _TYPE_CONTEXT_COMMITTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_DATASET_AUTHENTICATION_SELECTED"/>
            /// </summary>
            public static int TYPE_DATASET_AUTHENTICATION_SELECTED { get { if (!_TYPE_DATASET_AUTHENTICATION_SELECTEDReady) { _TYPE_DATASET_AUTHENTICATION_SELECTEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_DATASET_AUTHENTICATION_SELECTED"); _TYPE_DATASET_AUTHENTICATION_SELECTEDReady = true; } return _TYPE_DATASET_AUTHENTICATION_SELECTEDContent; } }
            private static int _TYPE_DATASET_AUTHENTICATION_SELECTEDContent = default;
            private static bool _TYPE_DATASET_AUTHENTICATION_SELECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_DATASET_SELECTED"/>
            /// </summary>
            public static int TYPE_DATASET_SELECTED { get { if (!_TYPE_DATASET_SELECTEDReady) { _TYPE_DATASET_SELECTEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_DATASET_SELECTED"); _TYPE_DATASET_SELECTEDReady = true; } return _TYPE_DATASET_SELECTEDContent; } }
            private static int _TYPE_DATASET_SELECTEDContent = default;
            private static bool _TYPE_DATASET_SELECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_DATASETS_SHOWN"/>
            /// </summary>
            public static int TYPE_DATASETS_SHOWN { get { if (!_TYPE_DATASETS_SHOWNReady) { _TYPE_DATASETS_SHOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_DATASETS_SHOWN"); _TYPE_DATASETS_SHOWNReady = true; } return _TYPE_DATASETS_SHOWNContent; } }
            private static int _TYPE_DATASETS_SHOWNContent = default;
            private static bool _TYPE_DATASETS_SHOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_SAVE_SHOWN"/>
            /// </summary>
            public static int TYPE_SAVE_SHOWN { get { if (!_TYPE_SAVE_SHOWNReady) { _TYPE_SAVE_SHOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_SAVE_SHOWN"); _TYPE_SAVE_SHOWNReady = true; } return _TYPE_SAVE_SHOWNContent; } }
            private static int _TYPE_SAVE_SHOWNContent = default;
            private static bool _TYPE_SAVE_SHOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#TYPE_VIEW_REQUESTED_AUTOFILL"/>
            /// </summary>
            public static int TYPE_VIEW_REQUESTED_AUTOFILL { get { if (!_TYPE_VIEW_REQUESTED_AUTOFILLReady) { _TYPE_VIEW_REQUESTED_AUTOFILLContent = SGetField<int>(LocalBridgeClazz, "TYPE_VIEW_REQUESTED_AUTOFILL"); _TYPE_VIEW_REQUESTED_AUTOFILLReady = true; } return _TYPE_VIEW_REQUESTED_AUTOFILLContent; } }
            private static int _TYPE_VIEW_REQUESTED_AUTOFILLContent = default;
            private static bool _TYPE_VIEW_REQUESTED_AUTOFILLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#UI_TYPE_DIALOG"/>
            /// </summary>
            public static int UI_TYPE_DIALOG { get { if (!_UI_TYPE_DIALOGReady) { _UI_TYPE_DIALOGContent = SGetField<int>(LocalBridgeClazz, "UI_TYPE_DIALOG"); _UI_TYPE_DIALOGReady = true; } return _UI_TYPE_DIALOGContent; } }
            private static int _UI_TYPE_DIALOGContent = default;
            private static bool _UI_TYPE_DIALOGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#UI_TYPE_INLINE"/>
            /// </summary>
            public static int UI_TYPE_INLINE { get { if (!_UI_TYPE_INLINEReady) { _UI_TYPE_INLINEContent = SGetField<int>(LocalBridgeClazz, "UI_TYPE_INLINE"); _UI_TYPE_INLINEReady = true; } return _UI_TYPE_INLINEContent; } }
            private static int _UI_TYPE_INLINEContent = default;
            private static bool _UI_TYPE_INLINEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#UI_TYPE_MENU"/>
            /// </summary>
            public static int UI_TYPE_MENU { get { if (!_UI_TYPE_MENUReady) { _UI_TYPE_MENUContent = SGetField<int>(LocalBridgeClazz, "UI_TYPE_MENU"); _UI_TYPE_MENUReady = true; } return _UI_TYPE_MENUContent; } }
            private static int _UI_TYPE_MENUContent = default;
            private static bool _UI_TYPE_MENUReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#UI_TYPE_UNKNOWN"/>
            /// </summary>
            public static int UI_TYPE_UNKNOWN { get { if (!_UI_TYPE_UNKNOWNReady) { _UI_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UI_TYPE_UNKNOWN"); _UI_TYPE_UNKNOWNReady = true; } return _UI_TYPE_UNKNOWNContent; } }
            private static int _UI_TYPE_UNKNOWNContent = default;
            private static bool _UI_TYPE_UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getClientState()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetClientState()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getClientState", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getNoSaveUiReason()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetNoSaveUiReason()
            {
                return IExecuteWithSignature<int>("getNoSaveUiReason", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetType()
            {
                return IExecuteWithSignature<int>("getType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getUiType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetUiType()
            {
                return IExecuteWithSignature<int>("getUiType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getDatasetId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDatasetId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDatasetId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getFieldsClassification()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Android.View.Autofill.AutofillId, Android.Service.Autofill.FieldClassification> GetFieldsClassification()
            {
                return IExecuteWithSignature<Java.Util.Map<Android.View.Autofill.AutofillId, Android.Service.Autofill.FieldClassification>>("getFieldsClassification", "()Ljava/util/Map;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getChangedFields()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Android.View.Autofill.AutofillId, Java.Lang.String> GetChangedFields()
            {
                return IExecuteWithSignature<Java.Util.Map<Android.View.Autofill.AutofillId, Java.Lang.String>>("getChangedFields", "()Ljava/util/Map;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getManuallyEnteredField()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Android.View.Autofill.AutofillId, Java.Util.Set<Java.Lang.String>> GetManuallyEnteredField()
            {
                return IExecuteWithSignature<Java.Util.Map<Android.View.Autofill.AutofillId, Java.Util.Set<Java.Lang.String>>>("getManuallyEnteredField", "()Ljava/util/Map;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getIgnoredDatasetIds()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> GetIgnoredDatasetIds()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getIgnoredDatasetIds", "()Ljava/util/Set;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillEventHistory.Event.html#getSelectedDatasetIds()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> GetSelectedDatasetIds()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSelectedDatasetIds", "()Ljava/util/Set;");
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