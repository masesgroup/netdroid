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

namespace Android.Media.Audiofx
{
    #region Equalizer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html"/>
    /// </summary>
    public partial class Equalizer : Android.Media.Audiofx.AudioEffect
    {
        const string _bridgeClassName = "android.media.audiofx.Equalizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Equalizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Equalizer(params object[] args) : base(args) { }

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
        #region OnParameterChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.OnParameterChangeListener.html"/>
        /// </summary>
        public partial class OnParameterChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnParameterChangeListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.media.audiofx.Equalizer_OnParameterChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnParameterChangeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnParameterChangeListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnParameterChangeListenerDirect : OnParameterChangeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.media.audiofx.Equalizer$OnParameterChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

        #region Settings declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.Settings.html"/>
        /// </summary>
        public partial class Settings : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Settings>
        {
            const string _bridgeClassName = "android.media.audiofx.Equalizer$Settings";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Settings() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Settings(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Equalizer implementation
    public partial class Equalizer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public Equalizer(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_BAND_FREQ_RANGE"/>
        /// </summary>
        public static int PARAM_BAND_FREQ_RANGE { get { if (!_PARAM_BAND_FREQ_RANGEReady) { _PARAM_BAND_FREQ_RANGEContent = SGetField<int>(LocalBridgeClazz, "PARAM_BAND_FREQ_RANGE"); _PARAM_BAND_FREQ_RANGEReady = true; } return _PARAM_BAND_FREQ_RANGEContent; } }
        private static int _PARAM_BAND_FREQ_RANGEContent = default;
        private static bool _PARAM_BAND_FREQ_RANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_BAND_LEVEL"/>
        /// </summary>
        public static int PARAM_BAND_LEVEL { get { if (!_PARAM_BAND_LEVELReady) { _PARAM_BAND_LEVELContent = SGetField<int>(LocalBridgeClazz, "PARAM_BAND_LEVEL"); _PARAM_BAND_LEVELReady = true; } return _PARAM_BAND_LEVELContent; } }
        private static int _PARAM_BAND_LEVELContent = default;
        private static bool _PARAM_BAND_LEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_CENTER_FREQ"/>
        /// </summary>
        public static int PARAM_CENTER_FREQ { get { if (!_PARAM_CENTER_FREQReady) { _PARAM_CENTER_FREQContent = SGetField<int>(LocalBridgeClazz, "PARAM_CENTER_FREQ"); _PARAM_CENTER_FREQReady = true; } return _PARAM_CENTER_FREQContent; } }
        private static int _PARAM_CENTER_FREQContent = default;
        private static bool _PARAM_CENTER_FREQReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_CURRENT_PRESET"/>
        /// </summary>
        public static int PARAM_CURRENT_PRESET { get { if (!_PARAM_CURRENT_PRESETReady) { _PARAM_CURRENT_PRESETContent = SGetField<int>(LocalBridgeClazz, "PARAM_CURRENT_PRESET"); _PARAM_CURRENT_PRESETReady = true; } return _PARAM_CURRENT_PRESETContent; } }
        private static int _PARAM_CURRENT_PRESETContent = default;
        private static bool _PARAM_CURRENT_PRESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_GET_BAND"/>
        /// </summary>
        public static int PARAM_GET_BAND { get { if (!_PARAM_GET_BANDReady) { _PARAM_GET_BANDContent = SGetField<int>(LocalBridgeClazz, "PARAM_GET_BAND"); _PARAM_GET_BANDReady = true; } return _PARAM_GET_BANDContent; } }
        private static int _PARAM_GET_BANDContent = default;
        private static bool _PARAM_GET_BANDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_GET_NUM_OF_PRESETS"/>
        /// </summary>
        public static int PARAM_GET_NUM_OF_PRESETS { get { if (!_PARAM_GET_NUM_OF_PRESETSReady) { _PARAM_GET_NUM_OF_PRESETSContent = SGetField<int>(LocalBridgeClazz, "PARAM_GET_NUM_OF_PRESETS"); _PARAM_GET_NUM_OF_PRESETSReady = true; } return _PARAM_GET_NUM_OF_PRESETSContent; } }
        private static int _PARAM_GET_NUM_OF_PRESETSContent = default;
        private static bool _PARAM_GET_NUM_OF_PRESETSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_GET_PRESET_NAME"/>
        /// </summary>
        public static int PARAM_GET_PRESET_NAME { get { if (!_PARAM_GET_PRESET_NAMEReady) { _PARAM_GET_PRESET_NAMEContent = SGetField<int>(LocalBridgeClazz, "PARAM_GET_PRESET_NAME"); _PARAM_GET_PRESET_NAMEReady = true; } return _PARAM_GET_PRESET_NAMEContent; } }
        private static int _PARAM_GET_PRESET_NAMEContent = default;
        private static bool _PARAM_GET_PRESET_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_LEVEL_RANGE"/>
        /// </summary>
        public static int PARAM_LEVEL_RANGE { get { if (!_PARAM_LEVEL_RANGEReady) { _PARAM_LEVEL_RANGEContent = SGetField<int>(LocalBridgeClazz, "PARAM_LEVEL_RANGE"); _PARAM_LEVEL_RANGEReady = true; } return _PARAM_LEVEL_RANGEContent; } }
        private static int _PARAM_LEVEL_RANGEContent = default;
        private static bool _PARAM_LEVEL_RANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_NUM_BANDS"/>
        /// </summary>
        public static int PARAM_NUM_BANDS { get { if (!_PARAM_NUM_BANDSReady) { _PARAM_NUM_BANDSContent = SGetField<int>(LocalBridgeClazz, "PARAM_NUM_BANDS"); _PARAM_NUM_BANDSReady = true; } return _PARAM_NUM_BANDSContent; } }
        private static int _PARAM_NUM_BANDSContent = default;
        private static bool _PARAM_NUM_BANDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#PARAM_STRING_SIZE_MAX"/>
        /// </summary>
        public static int PARAM_STRING_SIZE_MAX { get { if (!_PARAM_STRING_SIZE_MAXReady) { _PARAM_STRING_SIZE_MAXContent = SGetField<int>(LocalBridgeClazz, "PARAM_STRING_SIZE_MAX"); _PARAM_STRING_SIZE_MAXReady = true; } return _PARAM_STRING_SIZE_MAXContent; } }
        private static int _PARAM_STRING_SIZE_MAXContent = default;
        private static bool _PARAM_STRING_SIZE_MAXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Audiofx.Equalizer.Settings"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public Android.Media.Audiofx.Equalizer.Settings GetProperties()
        {
            return IExecuteWithSignature<Android.Media.Audiofx.Equalizer.Settings>("getProperties", "()Landroid/media/audiofx/Equalizer$Settings;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getCenterFreq(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public int GetCenterFreq(short arg0)
        {
            return IExecuteWithSignature<int>("getCenterFreq", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getBandFreqRange(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public int[] GetBandFreqRange(short arg0)
        {
            return IExecuteWithSignatureArray<int>("getBandFreqRange", "(S)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getPresetName(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPresetName(short arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getPresetName", "(S)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getBand(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetBand(int arg0)
        {
            return IExecuteWithSignature<short>("getBand", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getBandLevel(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetBandLevel(short arg0)
        {
            return IExecuteWithSignature<short>("getBandLevel", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getCurrentPreset()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetCurrentPreset()
        {
            return IExecuteWithSignature<short>("getCurrentPreset", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getNumberOfBands()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetNumberOfBands()
        {
            return IExecuteWithSignature<short>("getNumberOfBands", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getNumberOfPresets()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetNumberOfPresets()
        {
            return IExecuteWithSignature<short>("getNumberOfPresets", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#getBandLevelRange()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short[] GetBandLevelRange()
        {
            return IExecuteWithSignatureArray<short>("getBandLevelRange", "()[S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#setBandLevel(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetBandLevel(short arg0, short arg1)
        {
            IExecuteWithSignature("setBandLevel", "(SS)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#setParameterListener(android.media.audiofx.Equalizer.OnParameterChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.Equalizer.OnParameterChangeListener"/></param>
        public void SetParameterListener(Android.Media.Audiofx.Equalizer.OnParameterChangeListener arg0)
        {
            IExecuteWithSignature("setParameterListener", "(Landroid/media/audiofx/Equalizer$OnParameterChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#setProperties(android.media.audiofx.Equalizer.Settings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.Equalizer.Settings"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetProperties(Android.Media.Audiofx.Equalizer.Settings arg0)
        {
            IExecuteWithSignature("setProperties", "(Landroid/media/audiofx/Equalizer$Settings;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.html#usePreset(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void UsePreset(short arg0)
        {
            IExecuteWithSignature("usePreset", "(S)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnParameterChangeListener implementation
        public partial class OnParameterChangeListener
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
            /// Handlers initializer for <see cref="OnParameterChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onParameterChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnParameterChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Equalizer,int,int,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnParameterChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.Audiofx.Equalizer, int, int, int, int> OnOnParameterChange { get; set; } = null;

            bool hasOverrideOnParameterChange = true;
            void OnParameterChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnParameterChange = true;
                var methodToExecute = (OnOnParameterChange != null) ? OnOnParameterChange : OnParameterChange;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Media.Audiofx.Equalizer>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnParameterChange;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Equalizer,int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.Equalizer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            public virtual void OnParameterChange(Android.Media.Audiofx.Equalizer arg0, int arg1, int arg2, int arg3, int arg4)
            {
                hasOverrideOnParameterChange = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnParameterChangeListenerDirect implementation
        public partial class OnParameterChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Equalizer,int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.Equalizer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            public override void OnParameterChange(Android.Media.Audiofx.Equalizer arg0, int arg1, int arg2, int arg3, int arg4)
            {
                IExecuteWithSignature("onParameterChange", "(Landroid/media/audiofx/Equalizer;IIII)V", arg0, arg1, arg2, arg3, arg4);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Settings implementation
        public partial class Settings
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.Settings.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Settings(Java.Lang.String arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.Settings.html#curPreset"/>
            /// </summary>
            public short curPreset { get { return IGetField<short>("curPreset"); } set { ISetField("curPreset", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.Settings.html#numBands"/>
            /// </summary>
            public short numBands { get { return IGetField<short>("numBands"); } set { ISetField("numBands", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Equalizer.Settings.html#bandLevels"/>
            /// </summary>
            public short[] bandLevels { get { return IGetFieldArray<short>("bandLevels"); } set { ISetField("bandLevels", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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