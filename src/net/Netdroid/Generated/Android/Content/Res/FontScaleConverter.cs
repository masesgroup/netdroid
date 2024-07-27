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

namespace Android.Content.Res
{
    #region IFontScaleConverter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFontScaleConverter
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FontScaleConverter
    public partial class FontScaleConverter : Android.Content.Res.IFontScaleConverter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/FontScaleConverter.html#forScale(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Content.Res.FontScaleConverter"/></returns>
        public static Android.Content.Res.FontScaleConverter ForScale(float arg0)
        {
            return SExecuteWithSignature<Android.Content.Res.FontScaleConverter>(LocalBridgeClazz, "forScale", "(F)Landroid/content/res/FontScaleConverter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/FontScaleConverter.html#isNonLinearFontScalingActive(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNonLinearFontScalingActive(float arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNonLinearFontScalingActive", "(F)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/FontScaleConverter.html#convertDpToSp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float ConvertDpToSp(float arg0)
        {
            return IExecuteWithSignature<float>("convertDpToSp", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/FontScaleConverter.html#convertSpToDp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float ConvertSpToDp(float arg0)
        {
            return IExecuteWithSignature<float>("convertSpToDp", "(F)F", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}