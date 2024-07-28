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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region BlendMode
    public partial class BlendMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#CLEAR"/>
        /// </summary>
        public static Android.Graphics.BlendMode CLEAR { get { if (!_CLEARReady) { _CLEARContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "CLEAR"); _CLEARReady = true; } return _CLEARContent; } }
        private static Android.Graphics.BlendMode _CLEARContent = default;
        private static bool _CLEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#COLOR"/>
        /// </summary>
        public static Android.Graphics.BlendMode COLOR { get { if (!_COLORReady) { _COLORContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "COLOR"); _COLORReady = true; } return _COLORContent; } }
        private static Android.Graphics.BlendMode _COLORContent = default;
        private static bool _COLORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#COLOR_BURN"/>
        /// </summary>
        public static Android.Graphics.BlendMode COLOR_BURN { get { if (!_COLOR_BURNReady) { _COLOR_BURNContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "COLOR_BURN"); _COLOR_BURNReady = true; } return _COLOR_BURNContent; } }
        private static Android.Graphics.BlendMode _COLOR_BURNContent = default;
        private static bool _COLOR_BURNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#COLOR_DODGE"/>
        /// </summary>
        public static Android.Graphics.BlendMode COLOR_DODGE { get { if (!_COLOR_DODGEReady) { _COLOR_DODGEContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "COLOR_DODGE"); _COLOR_DODGEReady = true; } return _COLOR_DODGEContent; } }
        private static Android.Graphics.BlendMode _COLOR_DODGEContent = default;
        private static bool _COLOR_DODGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DARKEN"/>
        /// </summary>
        public static Android.Graphics.BlendMode DARKEN { get { if (!_DARKENReady) { _DARKENContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DARKEN"); _DARKENReady = true; } return _DARKENContent; } }
        private static Android.Graphics.BlendMode _DARKENContent = default;
        private static bool _DARKENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DIFFERENCE"/>
        /// </summary>
        public static Android.Graphics.BlendMode DIFFERENCE { get { if (!_DIFFERENCEReady) { _DIFFERENCEContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DIFFERENCE"); _DIFFERENCEReady = true; } return _DIFFERENCEContent; } }
        private static Android.Graphics.BlendMode _DIFFERENCEContent = default;
        private static bool _DIFFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DST"/>
        /// </summary>
        public static Android.Graphics.BlendMode DST { get { if (!_DSTReady) { _DSTContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DST"); _DSTReady = true; } return _DSTContent; } }
        private static Android.Graphics.BlendMode _DSTContent = default;
        private static bool _DSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DST_ATOP"/>
        /// </summary>
        public static Android.Graphics.BlendMode DST_ATOP { get { if (!_DST_ATOPReady) { _DST_ATOPContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DST_ATOP"); _DST_ATOPReady = true; } return _DST_ATOPContent; } }
        private static Android.Graphics.BlendMode _DST_ATOPContent = default;
        private static bool _DST_ATOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DST_IN"/>
        /// </summary>
        public static Android.Graphics.BlendMode DST_IN { get { if (!_DST_INReady) { _DST_INContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DST_IN"); _DST_INReady = true; } return _DST_INContent; } }
        private static Android.Graphics.BlendMode _DST_INContent = default;
        private static bool _DST_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DST_OUT"/>
        /// </summary>
        public static Android.Graphics.BlendMode DST_OUT { get { if (!_DST_OUTReady) { _DST_OUTContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DST_OUT"); _DST_OUTReady = true; } return _DST_OUTContent; } }
        private static Android.Graphics.BlendMode _DST_OUTContent = default;
        private static bool _DST_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#DST_OVER"/>
        /// </summary>
        public static Android.Graphics.BlendMode DST_OVER { get { if (!_DST_OVERReady) { _DST_OVERContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "DST_OVER"); _DST_OVERReady = true; } return _DST_OVERContent; } }
        private static Android.Graphics.BlendMode _DST_OVERContent = default;
        private static bool _DST_OVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#EXCLUSION"/>
        /// </summary>
        public static Android.Graphics.BlendMode EXCLUSION { get { if (!_EXCLUSIONReady) { _EXCLUSIONContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "EXCLUSION"); _EXCLUSIONReady = true; } return _EXCLUSIONContent; } }
        private static Android.Graphics.BlendMode _EXCLUSIONContent = default;
        private static bool _EXCLUSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#HARD_LIGHT"/>
        /// </summary>
        public static Android.Graphics.BlendMode HARD_LIGHT { get { if (!_HARD_LIGHTReady) { _HARD_LIGHTContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "HARD_LIGHT"); _HARD_LIGHTReady = true; } return _HARD_LIGHTContent; } }
        private static Android.Graphics.BlendMode _HARD_LIGHTContent = default;
        private static bool _HARD_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#HUE"/>
        /// </summary>
        public static Android.Graphics.BlendMode HUE { get { if (!_HUEReady) { _HUEContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "HUE"); _HUEReady = true; } return _HUEContent; } }
        private static Android.Graphics.BlendMode _HUEContent = default;
        private static bool _HUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#LIGHTEN"/>
        /// </summary>
        public static Android.Graphics.BlendMode LIGHTEN { get { if (!_LIGHTENReady) { _LIGHTENContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "LIGHTEN"); _LIGHTENReady = true; } return _LIGHTENContent; } }
        private static Android.Graphics.BlendMode _LIGHTENContent = default;
        private static bool _LIGHTENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#LUMINOSITY"/>
        /// </summary>
        public static Android.Graphics.BlendMode LUMINOSITY { get { if (!_LUMINOSITYReady) { _LUMINOSITYContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "LUMINOSITY"); _LUMINOSITYReady = true; } return _LUMINOSITYContent; } }
        private static Android.Graphics.BlendMode _LUMINOSITYContent = default;
        private static bool _LUMINOSITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#MODULATE"/>
        /// </summary>
        public static Android.Graphics.BlendMode MODULATE { get { if (!_MODULATEReady) { _MODULATEContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "MODULATE"); _MODULATEReady = true; } return _MODULATEContent; } }
        private static Android.Graphics.BlendMode _MODULATEContent = default;
        private static bool _MODULATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#MULTIPLY"/>
        /// </summary>
        public static Android.Graphics.BlendMode MULTIPLY { get { if (!_MULTIPLYReady) { _MULTIPLYContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "MULTIPLY"); _MULTIPLYReady = true; } return _MULTIPLYContent; } }
        private static Android.Graphics.BlendMode _MULTIPLYContent = default;
        private static bool _MULTIPLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#OVERLAY"/>
        /// </summary>
        public static Android.Graphics.BlendMode OVERLAY { get { if (!_OVERLAYReady) { _OVERLAYContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "OVERLAY"); _OVERLAYReady = true; } return _OVERLAYContent; } }
        private static Android.Graphics.BlendMode _OVERLAYContent = default;
        private static bool _OVERLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#PLUS"/>
        /// </summary>
        public static Android.Graphics.BlendMode PLUS { get { if (!_PLUSReady) { _PLUSContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "PLUS"); _PLUSReady = true; } return _PLUSContent; } }
        private static Android.Graphics.BlendMode _PLUSContent = default;
        private static bool _PLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SATURATION"/>
        /// </summary>
        public static Android.Graphics.BlendMode SATURATION { get { if (!_SATURATIONReady) { _SATURATIONContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SATURATION"); _SATURATIONReady = true; } return _SATURATIONContent; } }
        private static Android.Graphics.BlendMode _SATURATIONContent = default;
        private static bool _SATURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SCREEN"/>
        /// </summary>
        public static Android.Graphics.BlendMode SCREEN { get { if (!_SCREENReady) { _SCREENContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SCREEN"); _SCREENReady = true; } return _SCREENContent; } }
        private static Android.Graphics.BlendMode _SCREENContent = default;
        private static bool _SCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SOFT_LIGHT"/>
        /// </summary>
        public static Android.Graphics.BlendMode SOFT_LIGHT { get { if (!_SOFT_LIGHTReady) { _SOFT_LIGHTContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SOFT_LIGHT"); _SOFT_LIGHTReady = true; } return _SOFT_LIGHTContent; } }
        private static Android.Graphics.BlendMode _SOFT_LIGHTContent = default;
        private static bool _SOFT_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SRC"/>
        /// </summary>
        public static Android.Graphics.BlendMode SRC { get { if (!_SRCReady) { _SRCContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SRC"); _SRCReady = true; } return _SRCContent; } }
        private static Android.Graphics.BlendMode _SRCContent = default;
        private static bool _SRCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SRC_ATOP"/>
        /// </summary>
        public static Android.Graphics.BlendMode SRC_ATOP { get { if (!_SRC_ATOPReady) { _SRC_ATOPContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SRC_ATOP"); _SRC_ATOPReady = true; } return _SRC_ATOPContent; } }
        private static Android.Graphics.BlendMode _SRC_ATOPContent = default;
        private static bool _SRC_ATOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SRC_IN"/>
        /// </summary>
        public static Android.Graphics.BlendMode SRC_IN { get { if (!_SRC_INReady) { _SRC_INContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SRC_IN"); _SRC_INReady = true; } return _SRC_INContent; } }
        private static Android.Graphics.BlendMode _SRC_INContent = default;
        private static bool _SRC_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SRC_OUT"/>
        /// </summary>
        public static Android.Graphics.BlendMode SRC_OUT { get { if (!_SRC_OUTReady) { _SRC_OUTContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SRC_OUT"); _SRC_OUTReady = true; } return _SRC_OUTContent; } }
        private static Android.Graphics.BlendMode _SRC_OUTContent = default;
        private static bool _SRC_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#SRC_OVER"/>
        /// </summary>
        public static Android.Graphics.BlendMode SRC_OVER { get { if (!_SRC_OVERReady) { _SRC_OVERContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "SRC_OVER"); _SRC_OVERReady = true; } return _SRC_OVERContent; } }
        private static Android.Graphics.BlendMode _SRC_OVERContent = default;
        private static bool _SRC_OVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#XOR"/>
        /// </summary>
        public static Android.Graphics.BlendMode XOR { get { if (!_XORReady) { _XORContent = SGetField<Android.Graphics.BlendMode>(LocalBridgeClazz, "XOR"); _XORReady = true; } return _XORContent; } }
        private static Android.Graphics.BlendMode _XORContent = default;
        private static bool _XORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public static Android.Graphics.BlendMode ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.BlendMode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/BlendMode;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BlendMode.html#values()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public static Android.Graphics.BlendMode[] Values()
        {
            return SExecuteWithSignatureArray<Android.Graphics.BlendMode>(LocalBridgeClazz, "values", "()[Landroid/graphics/BlendMode;");
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