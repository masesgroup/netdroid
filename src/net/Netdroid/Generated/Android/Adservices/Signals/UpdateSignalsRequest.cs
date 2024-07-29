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

namespace Android.Adservices.Signals
{
    #region UpdateSignalsRequest
    public partial class UpdateSignalsRequest
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
        /// <see href="https://developer.android.com/reference/android/adservices/signals/UpdateSignalsRequest.html#getUpdateUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetUpdateUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getUpdateUri", "()Landroid/net/Uri;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/signals/UpdateSignalsRequest.Builder.html#%3Cinit%3E(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            public Builder(Android.Net.Uri arg0)
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
            /// <see href="https://developer.android.com/reference/android/adservices/signals/UpdateSignalsRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Signals.UpdateSignalsRequest"/></returns>
            public Android.Adservices.Signals.UpdateSignalsRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Signals.UpdateSignalsRequest>("build", "()Landroid/adservices/signals/UpdateSignalsRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/signals/UpdateSignalsRequest.Builder.html#setUpdateUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Signals.UpdateSignalsRequest.Builder"/></returns>
            public Android.Adservices.Signals.UpdateSignalsRequest.Builder SetUpdateUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Signals.UpdateSignalsRequest.Builder>("setUpdateUri", "(Landroid/net/Uri;)Landroid/adservices/signals/UpdateSignalsRequest$Builder;", arg0);
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