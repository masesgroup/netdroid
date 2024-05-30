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
    #region FillResponse
    public partial class FillResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#FLAG_DELAY_FILL"/>
        /// </summary>
        public static int FLAG_DELAY_FILL { get { if (!_FLAG_DELAY_FILLReady) { _FLAG_DELAY_FILLContent = SGetField<int>(LocalBridgeClazz, "FLAG_DELAY_FILL"); _FLAG_DELAY_FILLReady = true; } return _FLAG_DELAY_FILLContent; } }
        private static int _FLAG_DELAY_FILLContent = default;
        private static bool _FLAG_DELAY_FILLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#FLAG_DISABLE_ACTIVITY_ONLY"/>
        /// </summary>
        public static int FLAG_DISABLE_ACTIVITY_ONLY { get { if (!_FLAG_DISABLE_ACTIVITY_ONLYReady) { _FLAG_DISABLE_ACTIVITY_ONLYContent = SGetField<int>(LocalBridgeClazz, "FLAG_DISABLE_ACTIVITY_ONLY"); _FLAG_DISABLE_ACTIVITY_ONLYReady = true; } return _FLAG_DISABLE_ACTIVITY_ONLYContent; } }
        private static int _FLAG_DISABLE_ACTIVITY_ONLYContent = default;
        private static bool _FLAG_DISABLE_ACTIVITY_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#FLAG_TRACK_CONTEXT_COMMITED"/>
        /// </summary>
        public static int FLAG_TRACK_CONTEXT_COMMITED { get { if (!_FLAG_TRACK_CONTEXT_COMMITEDReady) { _FLAG_TRACK_CONTEXT_COMMITEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_TRACK_CONTEXT_COMMITED"); _FLAG_TRACK_CONTEXT_COMMITEDReady = true; } return _FLAG_TRACK_CONTEXT_COMMITEDContent; } }
        private static int _FLAG_TRACK_CONTEXT_COMMITEDContent = default;
        private static bool _FLAG_TRACK_CONTEXT_COMMITEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.FillResponse"/></returns>
            public Android.Service.Autofill.FillResponse Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse>("build", "()Landroid/service/autofill/FillResponse;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#addDataset(android.service.autofill.Dataset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Dataset"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder AddDataset(Android.Service.Autofill.Dataset arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("addDataset", "(Landroid/service/autofill/Dataset;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#disableAutofill(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder DisableAutofill(long arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("disableAutofill", "(J)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setAuthentication(android.view.autofill.AutofillId[],android.content.IntentSender,android.service.autofill.Presentations)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.Content.IntentSender"/></param>
            /// <param name="arg2"><see cref="Android.Service.Autofill.Presentations"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetAuthentication(Android.View.Autofill.AutofillId[] arg0, Android.Content.IntentSender arg1, Android.Service.Autofill.Presentations arg2)
            {
                return IExecute<Android.Service.Autofill.FillResponse.Builder>("setAuthentication", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setClientState(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetClientState(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setClientState", "(Landroid/os/Bundle;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setDetectedFieldClassifications(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetDetectedFieldClassifications(Java.Util.Set<Android.Service.Assist.Classification.FieldClassification> arg0)
            {
                return IExecute<Android.Service.Autofill.FillResponse.Builder>("setDetectedFieldClassifications", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setDialogHeader(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetDialogHeader(Android.Widget.RemoteViews arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setDialogHeader", "(Landroid/widget/RemoteViews;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setFieldClassificationIds(android.view.autofill.AutofillId[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetFieldClassificationIds(params Android.View.Autofill.AutofillId[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFieldClassificationIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;"); else return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFieldClassificationIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setFillDialogTriggerIds(android.view.autofill.AutofillId[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetFillDialogTriggerIds(params Android.View.Autofill.AutofillId[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFillDialogTriggerIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;"); else return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFillDialogTriggerIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetFlags(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFlags", "(I)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setFooter(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetFooter(Android.Widget.RemoteViews arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setFooter", "(Landroid/widget/RemoteViews;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setHeader(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetHeader(Android.Widget.RemoteViews arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setHeader", "(Landroid/widget/RemoteViews;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setIconResourceId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetIconResourceId(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setIconResourceId", "(I)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setIgnoredIds(android.view.autofill.AutofillId[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetIgnoredIds(params Android.View.Autofill.AutofillId[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setIgnoredIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;"); else return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setIgnoredIds", "([Landroid/view/autofill/AutofillId;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setPresentationCancelIds(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetPresentationCancelIds(int[] arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setPresentationCancelIds", "([I)Landroid/service/autofill/FillResponse$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setSaveInfo(android.service.autofill.SaveInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.SaveInfo"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetSaveInfo(Android.Service.Autofill.SaveInfo arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setSaveInfo", "(Landroid/service/autofill/SaveInfo;)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setServiceDisplayNameResourceId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetServiceDisplayNameResourceId(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setServiceDisplayNameResourceId", "(I)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setShowFillDialogIcon(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetShowFillDialogIcon(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setShowFillDialogIcon", "(Z)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setShowSaveDialogIcon(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetShowSaveDialogIcon(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setShowSaveDialogIcon", "(Z)Landroid/service/autofill/FillResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/FillResponse.Builder.html#setUserData(android.service.autofill.UserData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.UserData"/></param>
            /// <returns><see cref="Android.Service.Autofill.FillResponse.Builder"/></returns>
            public Android.Service.Autofill.FillResponse.Builder SetUserData(Android.Service.Autofill.UserData arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.FillResponse.Builder>("setUserData", "(Landroid/service/autofill/UserData;)Landroid/service/autofill/FillResponse$Builder;", arg0);
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