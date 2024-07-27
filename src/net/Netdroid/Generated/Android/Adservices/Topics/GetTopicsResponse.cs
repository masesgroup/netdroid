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

namespace Android.Adservices.Topics
{
    #region GetTopicsResponse
    public partial class GetTopicsResponse
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
        /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsResponse.html#getEncryptedTopics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Topics.EncryptedTopic> GetEncryptedTopics()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Topics.EncryptedTopic>>("getEncryptedTopics", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsResponse.html#getTopics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Topics.Topic> GetTopics()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Topics.Topic>>("getTopics", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsResponse.Builder.html#%3Cinit%3E(java.util.List,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public Builder(Java.Util.List<Android.Adservices.Topics.Topic> arg0, Java.Util.List<Android.Adservices.Topics.EncryptedTopic> arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsResponse.Builder.html#%3Cinit%3E(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            [global::System.Obsolete()]
            public Builder(Java.Util.List<Android.Adservices.Topics.Topic> arg0)
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
            /// <see href="https://developer.android.com/reference/android/adservices/topics/GetTopicsResponse.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Topics.GetTopicsResponse"/></returns>
            public Android.Adservices.Topics.GetTopicsResponse Build()
            {
                return IExecuteWithSignature<Android.Adservices.Topics.GetTopicsResponse>("build", "()Landroid/adservices/topics/GetTopicsResponse;");
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