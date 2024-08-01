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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Adselection
{
    #region AdSelectionOutcome
    public partial class AdSelectionOutcome
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#NO_OUTCOME"/>
        /// </summary>
        public static Android.Adservices.Adselection.AdSelectionOutcome NO_OUTCOME { get { if (!_NO_OUTCOMEReady) { _NO_OUTCOMEContent = SGetField<Android.Adservices.Adselection.AdSelectionOutcome>(LocalBridgeClazz, "NO_OUTCOME"); _NO_OUTCOMEReady = true; } return _NO_OUTCOMEContent; } }
        private static Android.Adservices.Adselection.AdSelectionOutcome _NO_OUTCOMEContent = default;
        private static bool _NO_OUTCOMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#getRenderUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetRenderUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getRenderUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#hasOutcome()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasOutcome()
        {
            return IExecuteWithSignature<bool>("hasOutcome", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#getAdSelectionId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAdSelectionId()
        {
            return IExecuteWithSignature<long>("getAdSelectionId", "()J");
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
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionOutcome"/></returns>
            public Android.Adservices.Adselection.AdSelectionOutcome Build()
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionOutcome>("build", "()Landroid/adservices/adselection/AdSelectionOutcome;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.Builder.html#setAdSelectionId(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionOutcome.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionOutcome.Builder SetAdSelectionId(long arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionOutcome.Builder>("setAdSelectionId", "(J)Landroid/adservices/adselection/AdSelectionOutcome$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.Builder.html#setRenderUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.AdSelectionOutcome.Builder"/></returns>
            public Android.Adservices.Adselection.AdSelectionOutcome.Builder SetRenderUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionOutcome.Builder>("setRenderUri", "(Landroid/net/Uri;)Landroid/adservices/adselection/AdSelectionOutcome$Builder;", arg0);
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