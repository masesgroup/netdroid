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
    #region Validators
    public partial class Validators
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Validators.html#and(android.service.autofill.Validator[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.Validator"/></param>
        /// <returns><see cref="Android.Service.Autofill.Validator"/></returns>
        public static Android.Service.Autofill.Validator And(params Android.Service.Autofill.Validator[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Android.Service.Autofill.Validator>(LocalBridgeClazz, "and", "([Landroid/service/autofill/Validator;)Landroid/service/autofill/Validator;"); else return SExecuteWithSignature<Android.Service.Autofill.Validator>(LocalBridgeClazz, "and", "([Landroid/service/autofill/Validator;)Landroid/service/autofill/Validator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Validators.html#not(android.service.autofill.Validator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.Validator"/></param>
        /// <returns><see cref="Android.Service.Autofill.Validator"/></returns>
        public static Android.Service.Autofill.Validator Not(Android.Service.Autofill.Validator arg0)
        {
            return SExecuteWithSignature<Android.Service.Autofill.Validator>(LocalBridgeClazz, "not", "(Landroid/service/autofill/Validator;)Landroid/service/autofill/Validator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Validators.html#or(android.service.autofill.Validator[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.Validator"/></param>
        /// <returns><see cref="Android.Service.Autofill.Validator"/></returns>
        public static Android.Service.Autofill.Validator Or(params Android.Service.Autofill.Validator[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Android.Service.Autofill.Validator>(LocalBridgeClazz, "or", "([Landroid/service/autofill/Validator;)Landroid/service/autofill/Validator;"); else return SExecuteWithSignature<Android.Service.Autofill.Validator>(LocalBridgeClazz, "or", "([Landroid/service/autofill/Validator;)Landroid/service/autofill/Validator;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}