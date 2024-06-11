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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Autofill
{
    #region VirtualViewFillInfo
    public partial class VirtualViewFillInfo
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
        /// <see href="https://developer.android.com/reference/android/view/autofill/VirtualViewFillInfo.html#getAutofillHints()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetAutofillHints()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getAutofillHints", "()[Ljava/lang/String;");
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
            /// <see href="https://developer.android.com/reference/android/view/autofill/VirtualViewFillInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Autofill.VirtualViewFillInfo"/></returns>
            public Android.View.Autofill.VirtualViewFillInfo Build()
            {
                return IExecuteWithSignature<Android.View.Autofill.VirtualViewFillInfo>("build", "()Landroid/view/autofill/VirtualViewFillInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/VirtualViewFillInfo.Builder.html#setAutofillHints(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Autofill.VirtualViewFillInfo.Builder"/></returns>
            public Android.View.Autofill.VirtualViewFillInfo.Builder SetAutofillHints(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.View.Autofill.VirtualViewFillInfo.Builder>("setAutofillHints", "([Ljava/lang/String;)Landroid/view/autofill/VirtualViewFillInfo$Builder;"); else return IExecuteWithSignature<Android.View.Autofill.VirtualViewFillInfo.Builder>("setAutofillHints", "([Ljava/lang/String;)Landroid/view/autofill/VirtualViewFillInfo$Builder;", arg0);
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