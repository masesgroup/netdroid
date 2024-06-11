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

namespace Android.Service.Autofill
{
    #region Field
    public partial class Field
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
        /// <see href="https://developer.android.com/reference/android/service/autofill/Field.html#getPresentations()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Autofill.Presentations"/></returns>
        public Android.Service.Autofill.Presentations GetPresentations()
        {
            return IExecuteWithSignature<Android.Service.Autofill.Presentations>("getPresentations", "()Landroid/service/autofill/Presentations;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Field.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Autofill.AutofillValue"/></returns>
        public Android.View.Autofill.AutofillValue GetValue()
        {
            return IExecuteWithSignature<Android.View.Autofill.AutofillValue>("getValue", "()Landroid/view/autofill/AutofillValue;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Field.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public Java.Util.Regex.Pattern GetFilter()
        {
            return IExecuteWithSignature<Java.Util.Regex.Pattern>("getFilter", "()Ljava/util/regex/Pattern;");
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/Field.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.Field"/></returns>
            public Android.Service.Autofill.Field Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.Field>("build", "()Landroid/service/autofill/Field;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Field.Builder.html#setFilter(java.util.regex.Pattern)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <returns><see cref="Android.Service.Autofill.Field.Builder"/></returns>
            public Android.Service.Autofill.Field.Builder SetFilter(Java.Util.Regex.Pattern arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Field.Builder>("setFilter", "(Ljava/util/regex/Pattern;)Landroid/service/autofill/Field$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Field.Builder.html#setPresentations(android.service.autofill.Presentations)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Presentations"/></param>
            /// <returns><see cref="Android.Service.Autofill.Field.Builder"/></returns>
            public Android.Service.Autofill.Field.Builder SetPresentations(Android.Service.Autofill.Presentations arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Field.Builder>("setPresentations", "(Landroid/service/autofill/Presentations;)Landroid/service/autofill/Field$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Field.Builder.html#setValue(android.view.autofill.AutofillValue)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <returns><see cref="Android.Service.Autofill.Field.Builder"/></returns>
            public Android.Service.Autofill.Field.Builder SetValue(Android.View.Autofill.AutofillValue arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Field.Builder>("setValue", "(Landroid/view/autofill/AutofillValue;)Landroid/service/autofill/Field$Builder;", arg0);
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