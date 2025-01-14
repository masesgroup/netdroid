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

namespace Android.Graphics.Fonts
{
    #region FontStyle declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html"/>
    /// </summary>
    public partial class FontStyle : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FontStyle>
    {
        const string _bridgeClassName = "android.graphics.fonts.FontStyle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FontStyle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FontStyle(params object[] args) : base(args) { }
    
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

    #region FontStyle implementation
    public partial class FontStyle
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FontStyle(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_SLANT_ITALIC"/>
        /// </summary>
        public static int FONT_SLANT_ITALIC { get { if (!_FONT_SLANT_ITALICReady) { _FONT_SLANT_ITALICContent = SGetField<int>(LocalBridgeClazz, "FONT_SLANT_ITALIC"); _FONT_SLANT_ITALICReady = true; } return _FONT_SLANT_ITALICContent; } }
        private static int _FONT_SLANT_ITALICContent = default;
        private static bool _FONT_SLANT_ITALICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_SLANT_UPRIGHT"/>
        /// </summary>
        public static int FONT_SLANT_UPRIGHT { get { if (!_FONT_SLANT_UPRIGHTReady) { _FONT_SLANT_UPRIGHTContent = SGetField<int>(LocalBridgeClazz, "FONT_SLANT_UPRIGHT"); _FONT_SLANT_UPRIGHTReady = true; } return _FONT_SLANT_UPRIGHTContent; } }
        private static int _FONT_SLANT_UPRIGHTContent = default;
        private static bool _FONT_SLANT_UPRIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_BLACK"/>
        /// </summary>
        public static int FONT_WEIGHT_BLACK { get { if (!_FONT_WEIGHT_BLACKReady) { _FONT_WEIGHT_BLACKContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_BLACK"); _FONT_WEIGHT_BLACKReady = true; } return _FONT_WEIGHT_BLACKContent; } }
        private static int _FONT_WEIGHT_BLACKContent = default;
        private static bool _FONT_WEIGHT_BLACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_BOLD"/>
        /// </summary>
        public static int FONT_WEIGHT_BOLD { get { if (!_FONT_WEIGHT_BOLDReady) { _FONT_WEIGHT_BOLDContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_BOLD"); _FONT_WEIGHT_BOLDReady = true; } return _FONT_WEIGHT_BOLDContent; } }
        private static int _FONT_WEIGHT_BOLDContent = default;
        private static bool _FONT_WEIGHT_BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_EXTRA_BOLD"/>
        /// </summary>
        public static int FONT_WEIGHT_EXTRA_BOLD { get { if (!_FONT_WEIGHT_EXTRA_BOLDReady) { _FONT_WEIGHT_EXTRA_BOLDContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_EXTRA_BOLD"); _FONT_WEIGHT_EXTRA_BOLDReady = true; } return _FONT_WEIGHT_EXTRA_BOLDContent; } }
        private static int _FONT_WEIGHT_EXTRA_BOLDContent = default;
        private static bool _FONT_WEIGHT_EXTRA_BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_EXTRA_LIGHT"/>
        /// </summary>
        public static int FONT_WEIGHT_EXTRA_LIGHT { get { if (!_FONT_WEIGHT_EXTRA_LIGHTReady) { _FONT_WEIGHT_EXTRA_LIGHTContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_EXTRA_LIGHT"); _FONT_WEIGHT_EXTRA_LIGHTReady = true; } return _FONT_WEIGHT_EXTRA_LIGHTContent; } }
        private static int _FONT_WEIGHT_EXTRA_LIGHTContent = default;
        private static bool _FONT_WEIGHT_EXTRA_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_LIGHT"/>
        /// </summary>
        public static int FONT_WEIGHT_LIGHT { get { if (!_FONT_WEIGHT_LIGHTReady) { _FONT_WEIGHT_LIGHTContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_LIGHT"); _FONT_WEIGHT_LIGHTReady = true; } return _FONT_WEIGHT_LIGHTContent; } }
        private static int _FONT_WEIGHT_LIGHTContent = default;
        private static bool _FONT_WEIGHT_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_MAX"/>
        /// </summary>
        public static int FONT_WEIGHT_MAX { get { if (!_FONT_WEIGHT_MAXReady) { _FONT_WEIGHT_MAXContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_MAX"); _FONT_WEIGHT_MAXReady = true; } return _FONT_WEIGHT_MAXContent; } }
        private static int _FONT_WEIGHT_MAXContent = default;
        private static bool _FONT_WEIGHT_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_MEDIUM"/>
        /// </summary>
        public static int FONT_WEIGHT_MEDIUM { get { if (!_FONT_WEIGHT_MEDIUMReady) { _FONT_WEIGHT_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_MEDIUM"); _FONT_WEIGHT_MEDIUMReady = true; } return _FONT_WEIGHT_MEDIUMContent; } }
        private static int _FONT_WEIGHT_MEDIUMContent = default;
        private static bool _FONT_WEIGHT_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_MIN"/>
        /// </summary>
        public static int FONT_WEIGHT_MIN { get { if (!_FONT_WEIGHT_MINReady) { _FONT_WEIGHT_MINContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_MIN"); _FONT_WEIGHT_MINReady = true; } return _FONT_WEIGHT_MINContent; } }
        private static int _FONT_WEIGHT_MINContent = default;
        private static bool _FONT_WEIGHT_MINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_NORMAL"/>
        /// </summary>
        public static int FONT_WEIGHT_NORMAL { get { if (!_FONT_WEIGHT_NORMALReady) { _FONT_WEIGHT_NORMALContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_NORMAL"); _FONT_WEIGHT_NORMALReady = true; } return _FONT_WEIGHT_NORMALContent; } }
        private static int _FONT_WEIGHT_NORMALContent = default;
        private static bool _FONT_WEIGHT_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_SEMI_BOLD"/>
        /// </summary>
        public static int FONT_WEIGHT_SEMI_BOLD { get { if (!_FONT_WEIGHT_SEMI_BOLDReady) { _FONT_WEIGHT_SEMI_BOLDContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_SEMI_BOLD"); _FONT_WEIGHT_SEMI_BOLDReady = true; } return _FONT_WEIGHT_SEMI_BOLDContent; } }
        private static int _FONT_WEIGHT_SEMI_BOLDContent = default;
        private static bool _FONT_WEIGHT_SEMI_BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_THIN"/>
        /// </summary>
        public static int FONT_WEIGHT_THIN { get { if (!_FONT_WEIGHT_THINReady) { _FONT_WEIGHT_THINContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_THIN"); _FONT_WEIGHT_THINReady = true; } return _FONT_WEIGHT_THINContent; } }
        private static int _FONT_WEIGHT_THINContent = default;
        private static bool _FONT_WEIGHT_THINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#FONT_WEIGHT_UNSPECIFIED"/>
        /// </summary>
        public static int FONT_WEIGHT_UNSPECIFIED { get { if (!_FONT_WEIGHT_UNSPECIFIEDReady) { _FONT_WEIGHT_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "FONT_WEIGHT_UNSPECIFIED"); _FONT_WEIGHT_UNSPECIFIEDReady = true; } return _FONT_WEIGHT_UNSPECIFIEDContent; } }
        private static int _FONT_WEIGHT_UNSPECIFIEDContent = default;
        private static bool _FONT_WEIGHT_UNSPECIFIEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#getSlant()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSlant()
        {
            return IExecuteWithSignature<int>("getSlant", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontStyle.html#getWeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWeight()
        {
            return IExecuteWithSignature<int>("getWeight", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}