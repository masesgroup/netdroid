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

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#getAdSelectionId()"/> 
        /// </summary>
        public long AdSelectionId
        {
            get { return IExecuteWithSignature<long>("getAdSelectionId", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AdSelectionOutcome.html#getRenderUri()"/> 
        /// </summary>
        public Android.Net.Uri RenderUri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getRenderUri", "()Landroid/net/Uri;"); }
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