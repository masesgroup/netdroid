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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region ImageFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html"/>
    /// </summary>
    public partial class ImageFormat : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageFormat>
    {
        const string _bridgeClassName = "android.graphics.ImageFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ImageFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ImageFormat(params object[] args) : base(args) { }
    
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

    #region ImageFormat implementation
    public partial class ImageFormat
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#DEPTH_JPEG"/>
        /// </summary>
        public static int DEPTH_JPEG { get { if (!_DEPTH_JPEGReady) { _DEPTH_JPEGContent = SGetField<int>(LocalBridgeClazz, "DEPTH_JPEG"); _DEPTH_JPEGReady = true; } return _DEPTH_JPEGContent; } }
        private static int _DEPTH_JPEGContent = default;
        private static bool _DEPTH_JPEGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#DEPTH_POINT_CLOUD"/>
        /// </summary>
        public static int DEPTH_POINT_CLOUD { get { if (!_DEPTH_POINT_CLOUDReady) { _DEPTH_POINT_CLOUDContent = SGetField<int>(LocalBridgeClazz, "DEPTH_POINT_CLOUD"); _DEPTH_POINT_CLOUDReady = true; } return _DEPTH_POINT_CLOUDContent; } }
        private static int _DEPTH_POINT_CLOUDContent = default;
        private static bool _DEPTH_POINT_CLOUDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#DEPTH16"/>
        /// </summary>
        public static int DEPTH16 { get { if (!_DEPTH16Ready) { _DEPTH16Content = SGetField<int>(LocalBridgeClazz, "DEPTH16"); _DEPTH16Ready = true; } return _DEPTH16Content; } }
        private static int _DEPTH16Content = default;
        private static bool _DEPTH16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#FLEX_RGB_888"/>
        /// </summary>
        public static int FLEX_RGB_888 { get { if (!_FLEX_RGB_888Ready) { _FLEX_RGB_888Content = SGetField<int>(LocalBridgeClazz, "FLEX_RGB_888"); _FLEX_RGB_888Ready = true; } return _FLEX_RGB_888Content; } }
        private static int _FLEX_RGB_888Content = default;
        private static bool _FLEX_RGB_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#FLEX_RGBA_8888"/>
        /// </summary>
        public static int FLEX_RGBA_8888 { get { if (!_FLEX_RGBA_8888Ready) { _FLEX_RGBA_8888Content = SGetField<int>(LocalBridgeClazz, "FLEX_RGBA_8888"); _FLEX_RGBA_8888Ready = true; } return _FLEX_RGBA_8888Content; } }
        private static int _FLEX_RGBA_8888Content = default;
        private static bool _FLEX_RGBA_8888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#HEIC"/>
        /// </summary>
        public static int HEIC { get { if (!_HEICReady) { _HEICContent = SGetField<int>(LocalBridgeClazz, "HEIC"); _HEICReady = true; } return _HEICContent; } }
        private static int _HEICContent = default;
        private static bool _HEICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#JPEG"/>
        /// </summary>
        public static int JPEG { get { if (!_JPEGReady) { _JPEGContent = SGetField<int>(LocalBridgeClazz, "JPEG"); _JPEGReady = true; } return _JPEGContent; } }
        private static int _JPEGContent = default;
        private static bool _JPEGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#JPEG_R"/>
        /// </summary>
        public static int JPEG_R { get { if (!_JPEG_RReady) { _JPEG_RContent = SGetField<int>(LocalBridgeClazz, "JPEG_R"); _JPEG_RReady = true; } return _JPEG_RContent; } }
        private static int _JPEG_RContent = default;
        private static bool _JPEG_RReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#NV16"/>
        /// </summary>
        public static int NV16 { get { if (!_NV16Ready) { _NV16Content = SGetField<int>(LocalBridgeClazz, "NV16"); _NV16Ready = true; } return _NV16Content; } }
        private static int _NV16Content = default;
        private static bool _NV16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#NV21"/>
        /// </summary>
        public static int NV21 { get { if (!_NV21Ready) { _NV21Content = SGetField<int>(LocalBridgeClazz, "NV21"); _NV21Ready = true; } return _NV21Content; } }
        private static int _NV21Content = default;
        private static bool _NV21Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#PRIVATE"/>
        /// </summary>
        public static int PRIVATE { get { if (!_PRIVATEReady) { _PRIVATEContent = SGetField<int>(LocalBridgeClazz, "PRIVATE"); _PRIVATEReady = true; } return _PRIVATEContent; } }
        private static int _PRIVATEContent = default;
        private static bool _PRIVATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#RAW_PRIVATE"/>
        /// </summary>
        public static int RAW_PRIVATE { get { if (!_RAW_PRIVATEReady) { _RAW_PRIVATEContent = SGetField<int>(LocalBridgeClazz, "RAW_PRIVATE"); _RAW_PRIVATEReady = true; } return _RAW_PRIVATEContent; } }
        private static int _RAW_PRIVATEContent = default;
        private static bool _RAW_PRIVATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#RAW_SENSOR"/>
        /// </summary>
        public static int RAW_SENSOR { get { if (!_RAW_SENSORReady) { _RAW_SENSORContent = SGetField<int>(LocalBridgeClazz, "RAW_SENSOR"); _RAW_SENSORReady = true; } return _RAW_SENSORContent; } }
        private static int _RAW_SENSORContent = default;
        private static bool _RAW_SENSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#RAW10"/>
        /// </summary>
        public static int RAW10 { get { if (!_RAW10Ready) { _RAW10Content = SGetField<int>(LocalBridgeClazz, "RAW10"); _RAW10Ready = true; } return _RAW10Content; } }
        private static int _RAW10Content = default;
        private static bool _RAW10Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#RAW12"/>
        /// </summary>
        public static int RAW12 { get { if (!_RAW12Ready) { _RAW12Content = SGetField<int>(LocalBridgeClazz, "RAW12"); _RAW12Ready = true; } return _RAW12Content; } }
        private static int _RAW12Content = default;
        private static bool _RAW12Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#RGB_565"/>
        /// </summary>
        public static int RGB_565 { get { if (!_RGB_565Ready) { _RGB_565Content = SGetField<int>(LocalBridgeClazz, "RGB_565"); _RGB_565Ready = true; } return _RGB_565Content; } }
        private static int _RGB_565Content = default;
        private static bool _RGB_565Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#UNKNOWN"/>
        /// </summary>
        public static int UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static int _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#Y8"/>
        /// </summary>
        public static int Y8 { get { if (!_Y8Ready) { _Y8Content = SGetField<int>(LocalBridgeClazz, "Y8"); _Y8Ready = true; } return _Y8Content; } }
        private static int _Y8Content = default;
        private static bool _Y8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YCBCR_P010"/>
        /// </summary>
        public static int YCBCR_P010 { get { if (!_YCBCR_P010Ready) { _YCBCR_P010Content = SGetField<int>(LocalBridgeClazz, "YCBCR_P010"); _YCBCR_P010Ready = true; } return _YCBCR_P010Content; } }
        private static int _YCBCR_P010Content = default;
        private static bool _YCBCR_P010Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YUV_420_888"/>
        /// </summary>
        public static int YUV_420_888 { get { if (!_YUV_420_888Ready) { _YUV_420_888Content = SGetField<int>(LocalBridgeClazz, "YUV_420_888"); _YUV_420_888Ready = true; } return _YUV_420_888Content; } }
        private static int _YUV_420_888Content = default;
        private static bool _YUV_420_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YUV_422_888"/>
        /// </summary>
        public static int YUV_422_888 { get { if (!_YUV_422_888Ready) { _YUV_422_888Content = SGetField<int>(LocalBridgeClazz, "YUV_422_888"); _YUV_422_888Ready = true; } return _YUV_422_888Content; } }
        private static int _YUV_422_888Content = default;
        private static bool _YUV_422_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YUV_444_888"/>
        /// </summary>
        public static int YUV_444_888 { get { if (!_YUV_444_888Ready) { _YUV_444_888Content = SGetField<int>(LocalBridgeClazz, "YUV_444_888"); _YUV_444_888Ready = true; } return _YUV_444_888Content; } }
        private static int _YUV_444_888Content = default;
        private static bool _YUV_444_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YUY2"/>
        /// </summary>
        public static int YUY2 { get { if (!_YUY2Ready) { _YUY2Content = SGetField<int>(LocalBridgeClazz, "YUY2"); _YUY2Ready = true; } return _YUY2Content; } }
        private static int _YUY2Content = default;
        private static bool _YUY2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#YV12"/>
        /// </summary>
        public static int YV12 { get { if (!_YV12Ready) { _YV12Content = SGetField<int>(LocalBridgeClazz, "YV12"); _YV12Ready = true; } return _YV12Content; } }
        private static int _YV12Content = default;
        private static bool _YV12Ready = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ImageFormat.html#getBitsPerPixel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetBitsPerPixel(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getBitsPerPixel", "(I)I", arg0);
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