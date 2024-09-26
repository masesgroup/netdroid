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

namespace Android.Util
{
    #region DisplayMetrics declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html"/>
    /// </summary>
    public partial class DisplayMetrics : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DisplayMetrics>
    {
        const string _bridgeClassName = "android.util.DisplayMetrics";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DisplayMetrics() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DisplayMetrics(params object[] args) : base(args) { }

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

    #region DisplayMetrics implementation
    public partial class DisplayMetrics
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#density"/>
        /// </summary>
        public float density { get { return IGetField<float>("density"); } set { ISetField("density", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#scaledDensity"/>
        /// </summary>
        [global::System.Obsolete()]
        public float scaledDensity { get { return IGetField<float>("scaledDensity"); } set { ISetField("scaledDensity", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#xdpi"/>
        /// </summary>
        public float xdpi { get { return IGetField<float>("xdpi"); } set { ISetField("xdpi", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#ydpi"/>
        /// </summary>
        public float ydpi { get { return IGetField<float>("ydpi"); } set { ISetField("ydpi", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#densityDpi"/>
        /// </summary>
        public int densityDpi { get { return IGetField<int>("densityDpi"); } set { ISetField("densityDpi", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#heightPixels"/>
        /// </summary>
        public int heightPixels { get { return IGetField<int>("heightPixels"); } set { ISetField("heightPixels", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#widthPixels"/>
        /// </summary>
        public int widthPixels { get { return IGetField<int>("widthPixels"); } set { ISetField("widthPixels", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_140"/>
        /// </summary>
        public static int DENSITY_140 { get { if (!_DENSITY_140Ready) { _DENSITY_140Content = SGetField<int>(LocalBridgeClazz, "DENSITY_140"); _DENSITY_140Ready = true; } return _DENSITY_140Content; } }
        private static int _DENSITY_140Content = default;
        private static bool _DENSITY_140Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_180"/>
        /// </summary>
        public static int DENSITY_180 { get { if (!_DENSITY_180Ready) { _DENSITY_180Content = SGetField<int>(LocalBridgeClazz, "DENSITY_180"); _DENSITY_180Ready = true; } return _DENSITY_180Content; } }
        private static int _DENSITY_180Content = default;
        private static bool _DENSITY_180Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_200"/>
        /// </summary>
        public static int DENSITY_200 { get { if (!_DENSITY_200Ready) { _DENSITY_200Content = SGetField<int>(LocalBridgeClazz, "DENSITY_200"); _DENSITY_200Ready = true; } return _DENSITY_200Content; } }
        private static int _DENSITY_200Content = default;
        private static bool _DENSITY_200Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_220"/>
        /// </summary>
        public static int DENSITY_220 { get { if (!_DENSITY_220Ready) { _DENSITY_220Content = SGetField<int>(LocalBridgeClazz, "DENSITY_220"); _DENSITY_220Ready = true; } return _DENSITY_220Content; } }
        private static int _DENSITY_220Content = default;
        private static bool _DENSITY_220Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_260"/>
        /// </summary>
        public static int DENSITY_260 { get { if (!_DENSITY_260Ready) { _DENSITY_260Content = SGetField<int>(LocalBridgeClazz, "DENSITY_260"); _DENSITY_260Ready = true; } return _DENSITY_260Content; } }
        private static int _DENSITY_260Content = default;
        private static bool _DENSITY_260Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_280"/>
        /// </summary>
        public static int DENSITY_280 { get { if (!_DENSITY_280Ready) { _DENSITY_280Content = SGetField<int>(LocalBridgeClazz, "DENSITY_280"); _DENSITY_280Ready = true; } return _DENSITY_280Content; } }
        private static int _DENSITY_280Content = default;
        private static bool _DENSITY_280Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_300"/>
        /// </summary>
        public static int DENSITY_300 { get { if (!_DENSITY_300Ready) { _DENSITY_300Content = SGetField<int>(LocalBridgeClazz, "DENSITY_300"); _DENSITY_300Ready = true; } return _DENSITY_300Content; } }
        private static int _DENSITY_300Content = default;
        private static bool _DENSITY_300Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_340"/>
        /// </summary>
        public static int DENSITY_340 { get { if (!_DENSITY_340Ready) { _DENSITY_340Content = SGetField<int>(LocalBridgeClazz, "DENSITY_340"); _DENSITY_340Ready = true; } return _DENSITY_340Content; } }
        private static int _DENSITY_340Content = default;
        private static bool _DENSITY_340Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_360"/>
        /// </summary>
        public static int DENSITY_360 { get { if (!_DENSITY_360Ready) { _DENSITY_360Content = SGetField<int>(LocalBridgeClazz, "DENSITY_360"); _DENSITY_360Ready = true; } return _DENSITY_360Content; } }
        private static int _DENSITY_360Content = default;
        private static bool _DENSITY_360Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_390"/>
        /// </summary>
        public static int DENSITY_390 { get { if (!_DENSITY_390Ready) { _DENSITY_390Content = SGetField<int>(LocalBridgeClazz, "DENSITY_390"); _DENSITY_390Ready = true; } return _DENSITY_390Content; } }
        private static int _DENSITY_390Content = default;
        private static bool _DENSITY_390Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_400"/>
        /// </summary>
        public static int DENSITY_400 { get { if (!_DENSITY_400Ready) { _DENSITY_400Content = SGetField<int>(LocalBridgeClazz, "DENSITY_400"); _DENSITY_400Ready = true; } return _DENSITY_400Content; } }
        private static int _DENSITY_400Content = default;
        private static bool _DENSITY_400Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_420"/>
        /// </summary>
        public static int DENSITY_420 { get { if (!_DENSITY_420Ready) { _DENSITY_420Content = SGetField<int>(LocalBridgeClazz, "DENSITY_420"); _DENSITY_420Ready = true; } return _DENSITY_420Content; } }
        private static int _DENSITY_420Content = default;
        private static bool _DENSITY_420Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_440"/>
        /// </summary>
        public static int DENSITY_440 { get { if (!_DENSITY_440Ready) { _DENSITY_440Content = SGetField<int>(LocalBridgeClazz, "DENSITY_440"); _DENSITY_440Ready = true; } return _DENSITY_440Content; } }
        private static int _DENSITY_440Content = default;
        private static bool _DENSITY_440Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_450"/>
        /// </summary>
        public static int DENSITY_450 { get { if (!_DENSITY_450Ready) { _DENSITY_450Content = SGetField<int>(LocalBridgeClazz, "DENSITY_450"); _DENSITY_450Ready = true; } return _DENSITY_450Content; } }
        private static int _DENSITY_450Content = default;
        private static bool _DENSITY_450Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_520"/>
        /// </summary>
        public static int DENSITY_520 { get { if (!_DENSITY_520Ready) { _DENSITY_520Content = SGetField<int>(LocalBridgeClazz, "DENSITY_520"); _DENSITY_520Ready = true; } return _DENSITY_520Content; } }
        private static int _DENSITY_520Content = default;
        private static bool _DENSITY_520Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_560"/>
        /// </summary>
        public static int DENSITY_560 { get { if (!_DENSITY_560Ready) { _DENSITY_560Content = SGetField<int>(LocalBridgeClazz, "DENSITY_560"); _DENSITY_560Ready = true; } return _DENSITY_560Content; } }
        private static int _DENSITY_560Content = default;
        private static bool _DENSITY_560Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_600"/>
        /// </summary>
        public static int DENSITY_600 { get { if (!_DENSITY_600Ready) { _DENSITY_600Content = SGetField<int>(LocalBridgeClazz, "DENSITY_600"); _DENSITY_600Ready = true; } return _DENSITY_600Content; } }
        private static int _DENSITY_600Content = default;
        private static bool _DENSITY_600Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_DEFAULT"/>
        /// </summary>
        public static int DENSITY_DEFAULT { get { if (!_DENSITY_DEFAULTReady) { _DENSITY_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DENSITY_DEFAULT"); _DENSITY_DEFAULTReady = true; } return _DENSITY_DEFAULTContent; } }
        private static int _DENSITY_DEFAULTContent = default;
        private static bool _DENSITY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_DEVICE_STABLE"/>
        /// </summary>
        public static int DENSITY_DEVICE_STABLE { get { if (!_DENSITY_DEVICE_STABLEReady) { _DENSITY_DEVICE_STABLEContent = SGetField<int>(LocalBridgeClazz, "DENSITY_DEVICE_STABLE"); _DENSITY_DEVICE_STABLEReady = true; } return _DENSITY_DEVICE_STABLEContent; } }
        private static int _DENSITY_DEVICE_STABLEContent = default;
        private static bool _DENSITY_DEVICE_STABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_HIGH"/>
        /// </summary>
        public static int DENSITY_HIGH { get { if (!_DENSITY_HIGHReady) { _DENSITY_HIGHContent = SGetField<int>(LocalBridgeClazz, "DENSITY_HIGH"); _DENSITY_HIGHReady = true; } return _DENSITY_HIGHContent; } }
        private static int _DENSITY_HIGHContent = default;
        private static bool _DENSITY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_LOW"/>
        /// </summary>
        public static int DENSITY_LOW { get { if (!_DENSITY_LOWReady) { _DENSITY_LOWContent = SGetField<int>(LocalBridgeClazz, "DENSITY_LOW"); _DENSITY_LOWReady = true; } return _DENSITY_LOWContent; } }
        private static int _DENSITY_LOWContent = default;
        private static bool _DENSITY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_MEDIUM"/>
        /// </summary>
        public static int DENSITY_MEDIUM { get { if (!_DENSITY_MEDIUMReady) { _DENSITY_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "DENSITY_MEDIUM"); _DENSITY_MEDIUMReady = true; } return _DENSITY_MEDIUMContent; } }
        private static int _DENSITY_MEDIUMContent = default;
        private static bool _DENSITY_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_TV"/>
        /// </summary>
        public static int DENSITY_TV { get { if (!_DENSITY_TVReady) { _DENSITY_TVContent = SGetField<int>(LocalBridgeClazz, "DENSITY_TV"); _DENSITY_TVReady = true; } return _DENSITY_TVContent; } }
        private static int _DENSITY_TVContent = default;
        private static bool _DENSITY_TVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_XHIGH"/>
        /// </summary>
        public static int DENSITY_XHIGH { get { if (!_DENSITY_XHIGHReady) { _DENSITY_XHIGHContent = SGetField<int>(LocalBridgeClazz, "DENSITY_XHIGH"); _DENSITY_XHIGHReady = true; } return _DENSITY_XHIGHContent; } }
        private static int _DENSITY_XHIGHContent = default;
        private static bool _DENSITY_XHIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_XXHIGH"/>
        /// </summary>
        public static int DENSITY_XXHIGH { get { if (!_DENSITY_XXHIGHReady) { _DENSITY_XXHIGHContent = SGetField<int>(LocalBridgeClazz, "DENSITY_XXHIGH"); _DENSITY_XXHIGHReady = true; } return _DENSITY_XXHIGHContent; } }
        private static int _DENSITY_XXHIGHContent = default;
        private static bool _DENSITY_XXHIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#DENSITY_XXXHIGH"/>
        /// </summary>
        public static int DENSITY_XXXHIGH { get { if (!_DENSITY_XXXHIGHReady) { _DENSITY_XXXHIGHContent = SGetField<int>(LocalBridgeClazz, "DENSITY_XXXHIGH"); _DENSITY_XXXHIGHReady = true; } return _DENSITY_XXXHIGHContent; } }
        private static int _DENSITY_XXXHIGHContent = default;
        private static bool _DENSITY_XXXHIGHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#setTo(android.util.DisplayMetrics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.DisplayMetrics"/></param>
        public void SetTo(Android.Util.DisplayMetrics arg0)
        {
            IExecuteWithSignature("setTo", "(Landroid/util/DisplayMetrics;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/DisplayMetrics.html#setToDefaults()"/>
        /// </summary>
        public void SetToDefaults()
        {
            IExecuteWithSignature("setToDefaults", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}