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

namespace Android.Adservices.Ondevicepersonalization
{
    #region WebTriggerOutput
    public partial class WebTriggerOutput
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.html#getRequestLogRecord()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.RequestLogRecord"/></returns>
        public Android.Adservices.Ondevicepersonalization.RequestLogRecord GetRequestLogRecord()
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.RequestLogRecord>("getRequestLogRecord", "()Landroid/adservices/ondevicepersonalization/RequestLogRecord;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.html#getEventLogRecords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord> GetEventLogRecords()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord>>("getEventLogRecords", "()Ljava/util/List;");
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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.WebTriggerOutput"/></returns>
            public Android.Adservices.Ondevicepersonalization.WebTriggerOutput Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.WebTriggerOutput>("build", "()Landroid/adservices/ondevicepersonalization/WebTriggerOutput;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.Builder.html#addEventLogRecord(android.adservices.ondevicepersonalization.EventLogRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.EventLogRecord"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder AddEventLogRecord(Android.Adservices.Ondevicepersonalization.EventLogRecord arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder>("addEventLogRecord", "(Landroid/adservices/ondevicepersonalization/EventLogRecord;)Landroid/adservices/ondevicepersonalization/WebTriggerOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.Builder.html#setEventLogRecords(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder SetEventLogRecords(Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder>("setEventLogRecords", "(Ljava/util/List;)Landroid/adservices/ondevicepersonalization/WebTriggerOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/WebTriggerOutput.Builder.html#setRequestLogRecord(android.adservices.ondevicepersonalization.RequestLogRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestLogRecord"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder SetRequestLogRecord(Android.Adservices.Ondevicepersonalization.RequestLogRecord arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.WebTriggerOutput.Builder>("setRequestLogRecord", "(Landroid/adservices/ondevicepersonalization/RequestLogRecord;)Landroid/adservices/ondevicepersonalization/WebTriggerOutput$Builder;", arg0);
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