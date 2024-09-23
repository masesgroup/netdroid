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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region PixelFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html"/>
    /// </summary>
    public partial class PixelFormat : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PixelFormat>
    {
        const string _bridgeClassName = "android.graphics.PixelFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PixelFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PixelFormat(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region PixelFormat implementation
    public partial class PixelFormat
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#bitsPerPixel"/>
        /// </summary>
        public int bitsPerPixel { get { return IGetField<int>("bitsPerPixel"); } set { ISetField("bitsPerPixel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#bytesPerPixel"/>
        /// </summary>
        public int bytesPerPixel { get { return IGetField<int>("bytesPerPixel"); } set { ISetField("bytesPerPixel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#A_8"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int A_8 { get { if (!_A_8Ready) { _A_8Content = SGetField<int>(LocalBridgeClazz, "A_8"); _A_8Ready = true; } return _A_8Content; } }
        private static int _A_8Content = default;
        private static bool _A_8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#JPEG"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int JPEG { get { if (!_JPEGReady) { _JPEGContent = SGetField<int>(LocalBridgeClazz, "JPEG"); _JPEGReady = true; } return _JPEGContent; } }
        private static int _JPEGContent = default;
        private static bool _JPEGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#L_8"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int L_8 { get { if (!_L_8Ready) { _L_8Content = SGetField<int>(LocalBridgeClazz, "L_8"); _L_8Ready = true; } return _L_8Content; } }
        private static int _L_8Content = default;
        private static bool _L_8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#LA_88"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int LA_88 { get { if (!_LA_88Ready) { _LA_88Content = SGetField<int>(LocalBridgeClazz, "LA_88"); _LA_88Ready = true; } return _LA_88Content; } }
        private static int _LA_88Content = default;
        private static bool _LA_88Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#OPAQUE"/>
        /// </summary>
        public static int OPAQUE { get { if (!_OPAQUEReady) { _OPAQUEContent = SGetField<int>(LocalBridgeClazz, "OPAQUE"); _OPAQUEReady = true; } return _OPAQUEContent; } }
        private static int _OPAQUEContent = default;
        private static bool _OPAQUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGB_332"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int RGB_332 { get { if (!_RGB_332Ready) { _RGB_332Content = SGetField<int>(LocalBridgeClazz, "RGB_332"); _RGB_332Ready = true; } return _RGB_332Content; } }
        private static int _RGB_332Content = default;
        private static bool _RGB_332Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGB_565"/>
        /// </summary>
        public static int RGB_565 { get { if (!_RGB_565Ready) { _RGB_565Content = SGetField<int>(LocalBridgeClazz, "RGB_565"); _RGB_565Ready = true; } return _RGB_565Content; } }
        private static int _RGB_565Content = default;
        private static bool _RGB_565Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGB_888"/>
        /// </summary>
        public static int RGB_888 { get { if (!_RGB_888Ready) { _RGB_888Content = SGetField<int>(LocalBridgeClazz, "RGB_888"); _RGB_888Ready = true; } return _RGB_888Content; } }
        private static int _RGB_888Content = default;
        private static bool _RGB_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBA_1010102"/>
        /// </summary>
        public static int RGBA_1010102 { get { if (!_RGBA_1010102Ready) { _RGBA_1010102Content = SGetField<int>(LocalBridgeClazz, "RGBA_1010102"); _RGBA_1010102Ready = true; } return _RGBA_1010102Content; } }
        private static int _RGBA_1010102Content = default;
        private static bool _RGBA_1010102Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBA_4444"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int RGBA_4444 { get { if (!_RGBA_4444Ready) { _RGBA_4444Content = SGetField<int>(LocalBridgeClazz, "RGBA_4444"); _RGBA_4444Ready = true; } return _RGBA_4444Content; } }
        private static int _RGBA_4444Content = default;
        private static bool _RGBA_4444Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBA_5551"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int RGBA_5551 { get { if (!_RGBA_5551Ready) { _RGBA_5551Content = SGetField<int>(LocalBridgeClazz, "RGBA_5551"); _RGBA_5551Ready = true; } return _RGBA_5551Content; } }
        private static int _RGBA_5551Content = default;
        private static bool _RGBA_5551Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBA_8888"/>
        /// </summary>
        public static int RGBA_8888 { get { if (!_RGBA_8888Ready) { _RGBA_8888Content = SGetField<int>(LocalBridgeClazz, "RGBA_8888"); _RGBA_8888Ready = true; } return _RGBA_8888Content; } }
        private static int _RGBA_8888Content = default;
        private static bool _RGBA_8888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBA_F16"/>
        /// </summary>
        public static int RGBA_F16 { get { if (!_RGBA_F16Ready) { _RGBA_F16Content = SGetField<int>(LocalBridgeClazz, "RGBA_F16"); _RGBA_F16Ready = true; } return _RGBA_F16Content; } }
        private static int _RGBA_F16Content = default;
        private static bool _RGBA_F16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#RGBX_8888"/>
        /// </summary>
        public static int RGBX_8888 { get { if (!_RGBX_8888Ready) { _RGBX_8888Content = SGetField<int>(LocalBridgeClazz, "RGBX_8888"); _RGBX_8888Ready = true; } return _RGBX_8888Content; } }
        private static int _RGBX_8888Content = default;
        private static bool _RGBX_8888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#TRANSLUCENT"/>
        /// </summary>
        public static int TRANSLUCENT { get { if (!_TRANSLUCENTReady) { _TRANSLUCENTContent = SGetField<int>(LocalBridgeClazz, "TRANSLUCENT"); _TRANSLUCENTReady = true; } return _TRANSLUCENTContent; } }
        private static int _TRANSLUCENTContent = default;
        private static bool _TRANSLUCENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#TRANSPARENT"/>
        /// </summary>
        public static int TRANSPARENT { get { if (!_TRANSPARENTReady) { _TRANSPARENTContent = SGetField<int>(LocalBridgeClazz, "TRANSPARENT"); _TRANSPARENTReady = true; } return _TRANSPARENTContent; } }
        private static int _TRANSPARENTContent = default;
        private static bool _TRANSPARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#UNKNOWN"/>
        /// </summary>
        public static int UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static int _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#YCbCr_420_SP"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int YCbCr_420_SP { get { if (!_YCbCr_420_SPReady) { _YCbCr_420_SPContent = SGetField<int>(LocalBridgeClazz, "YCbCr_420_SP"); _YCbCr_420_SPReady = true; } return _YCbCr_420_SPContent; } }
        private static int _YCbCr_420_SPContent = default;
        private static bool _YCbCr_420_SPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#YCbCr_422_I"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int YCbCr_422_I { get { if (!_YCbCr_422_IReady) { _YCbCr_422_IContent = SGetField<int>(LocalBridgeClazz, "YCbCr_422_I"); _YCbCr_422_IReady = true; } return _YCbCr_422_IContent; } }
        private static int _YCbCr_422_IContent = default;
        private static bool _YCbCr_422_IReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#YCbCr_422_SP"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int YCbCr_422_SP { get { if (!_YCbCr_422_SPReady) { _YCbCr_422_SPContent = SGetField<int>(LocalBridgeClazz, "YCbCr_422_SP"); _YCbCr_422_SPReady = true; } return _YCbCr_422_SPContent; } }
        private static int _YCbCr_422_SPContent = default;
        private static bool _YCbCr_422_SPReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#formatHasAlpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool FormatHasAlpha(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "formatHasAlpha", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PixelFormat.html#getPixelFormatInfo(int,android.graphics.PixelFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.PixelFormat"/></param>
        public static void GetPixelFormatInfo(int arg0, Android.Graphics.PixelFormat arg1)
        {
            SExecute(LocalBridgeClazz, "getPixelFormatInfo", arg0, arg1);
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