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

namespace Android.Adservices.Topics
{
    #region GetTopicsRequest
    public partial class GetTopicsRequest
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
        /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsRequest.html#getAdsSdkName()"/> 
        /// </summary>
        public Java.Lang.String AdsSdkName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAdsSdkName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsRequest.html#shouldRecordObservation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldRecordObservation()
        {
            return IExecuteWithSignature<bool>("shouldRecordObservation", "()Z");
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
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Topics.GetTopicsRequest"/></returns>
            public Android.Adservices.Topics.GetTopicsRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Topics.GetTopicsRequest>("build", "()Landroid/adservices/topics/GetTopicsRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsRequest.Builder.html#setAdsSdkName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Adservices.Topics.GetTopicsRequest.Builder"/></returns>
            public Android.Adservices.Topics.GetTopicsRequest.Builder SetAdsSdkName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Topics.GetTopicsRequest.Builder>("setAdsSdkName", "(Ljava/lang/String;)Landroid/adservices/topics/GetTopicsRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsRequest.Builder.html#setShouldRecordObservation(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Adservices.Topics.GetTopicsRequest.Builder"/></returns>
            public Android.Adservices.Topics.GetTopicsRequest.Builder SetShouldRecordObservation(bool arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Topics.GetTopicsRequest.Builder>("setShouldRecordObservation", "(Z)Landroid/adservices/topics/GetTopicsRequest$Builder;", arg0);
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