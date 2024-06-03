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

namespace Android.Adservices.Customaudience
{
    #region JoinCustomAudienceRequest
    public partial class JoinCustomAudienceRequest
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
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/JoinCustomAudienceRequest.html#getCustomAudience()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience"/></returns>
        public Android.Adservices.Customaudience.CustomAudience GetCustomAudience()
        {
            return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience>("getCustomAudience", "()Landroid/adservices/customaudience/CustomAudience;");
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
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/JoinCustomAudienceRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Customaudience.JoinCustomAudienceRequest"/></returns>
            public Android.Adservices.Customaudience.JoinCustomAudienceRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.JoinCustomAudienceRequest>("build", "()Landroid/adservices/customaudience/JoinCustomAudienceRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/JoinCustomAudienceRequest.Builder.html#setCustomAudience(android.adservices.customaudience.CustomAudience)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Customaudience.CustomAudience"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.JoinCustomAudienceRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.JoinCustomAudienceRequest.Builder SetCustomAudience(Android.Adservices.Customaudience.CustomAudience arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.JoinCustomAudienceRequest.Builder>("setCustomAudience", "(Landroid/adservices/customaudience/CustomAudience;)Landroid/adservices/customaudience/JoinCustomAudienceRequest$Builder;", arg0);
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