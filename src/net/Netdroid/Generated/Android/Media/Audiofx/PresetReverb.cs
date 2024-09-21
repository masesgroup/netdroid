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
    #region PresetReverb declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html"/>
    /// </summary>
    public partial class PresetReverb : Android.Media.Audiofx.AudioEffect
    {
        const string _bridgeClassName = "android.media.audiofx.PresetReverb";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PresetReverb() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PresetReverb(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.OnParameterChangeListener.html"/>
        /// </summary>
        public partial class OnParameterChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnParameterChangeListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.media.audiofx.PresetReverb_OnParameterChangeListener";
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

            const string _bridgeClassName = "android.media.audiofx.PresetReverb$OnParameterChangeListener";
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
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.Settings.html"/>
        /// </summary>
        public partial class Settings : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Settings>
        {
            const string _bridgeClassName = "android.media.audiofx.PresetReverb$Settings";
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

    #region PresetReverb implementation
    public partial class PresetReverb
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public PresetReverb(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PARAM_PRESET"/>
        /// </summary>
        public static int PARAM_PRESET { get { if (!_PARAM_PRESETReady) { _PARAM_PRESETContent = SGetField<int>(LocalBridgeClazz, "PARAM_PRESET"); _PARAM_PRESETReady = true; } return _PARAM_PRESETContent; } }
        private static int _PARAM_PRESETContent = default;
        private static bool _PARAM_PRESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_LARGEHALL"/>
        /// </summary>
        public static short PRESET_LARGEHALL { get { if (!_PRESET_LARGEHALLReady) { _PRESET_LARGEHALLContent = SGetField<short>(LocalBridgeClazz, "PRESET_LARGEHALL"); _PRESET_LARGEHALLReady = true; } return _PRESET_LARGEHALLContent; } }
        private static short _PRESET_LARGEHALLContent = default;
        private static bool _PRESET_LARGEHALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_LARGEROOM"/>
        /// </summary>
        public static short PRESET_LARGEROOM { get { if (!_PRESET_LARGEROOMReady) { _PRESET_LARGEROOMContent = SGetField<short>(LocalBridgeClazz, "PRESET_LARGEROOM"); _PRESET_LARGEROOMReady = true; } return _PRESET_LARGEROOMContent; } }
        private static short _PRESET_LARGEROOMContent = default;
        private static bool _PRESET_LARGEROOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_MEDIUMHALL"/>
        /// </summary>
        public static short PRESET_MEDIUMHALL { get { if (!_PRESET_MEDIUMHALLReady) { _PRESET_MEDIUMHALLContent = SGetField<short>(LocalBridgeClazz, "PRESET_MEDIUMHALL"); _PRESET_MEDIUMHALLReady = true; } return _PRESET_MEDIUMHALLContent; } }
        private static short _PRESET_MEDIUMHALLContent = default;
        private static bool _PRESET_MEDIUMHALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_MEDIUMROOM"/>
        /// </summary>
        public static short PRESET_MEDIUMROOM { get { if (!_PRESET_MEDIUMROOMReady) { _PRESET_MEDIUMROOMContent = SGetField<short>(LocalBridgeClazz, "PRESET_MEDIUMROOM"); _PRESET_MEDIUMROOMReady = true; } return _PRESET_MEDIUMROOMContent; } }
        private static short _PRESET_MEDIUMROOMContent = default;
        private static bool _PRESET_MEDIUMROOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_NONE"/>
        /// </summary>
        public static short PRESET_NONE { get { if (!_PRESET_NONEReady) { _PRESET_NONEContent = SGetField<short>(LocalBridgeClazz, "PRESET_NONE"); _PRESET_NONEReady = true; } return _PRESET_NONEContent; } }
        private static short _PRESET_NONEContent = default;
        private static bool _PRESET_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_PLATE"/>
        /// </summary>
        public static short PRESET_PLATE { get { if (!_PRESET_PLATEReady) { _PRESET_PLATEContent = SGetField<short>(LocalBridgeClazz, "PRESET_PLATE"); _PRESET_PLATEReady = true; } return _PRESET_PLATEContent; } }
        private static short _PRESET_PLATEContent = default;
        private static bool _PRESET_PLATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#PRESET_SMALLROOM"/>
        /// </summary>
        public static short PRESET_SMALLROOM { get { if (!_PRESET_SMALLROOMReady) { _PRESET_SMALLROOMContent = SGetField<short>(LocalBridgeClazz, "PRESET_SMALLROOM"); _PRESET_SMALLROOMReady = true; } return _PRESET_SMALLROOMContent; } }
        private static short _PRESET_SMALLROOMContent = default;
        private static bool _PRESET_SMALLROOMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Audiofx.PresetReverb.Settings"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public Android.Media.Audiofx.PresetReverb.Settings GetProperties()
        {
            return IExecuteWithSignature<Android.Media.Audiofx.PresetReverb.Settings>("getProperties", "()Landroid/media/audiofx/PresetReverb$Settings;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#getPreset()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetPreset()
        {
            return IExecuteWithSignature<short>("getPreset", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#setParameterListener(android.media.audiofx.PresetReverb.OnParameterChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.PresetReverb.OnParameterChangeListener"/></param>
        public void SetParameterListener(Android.Media.Audiofx.PresetReverb.OnParameterChangeListener arg0)
        {
            IExecuteWithSignature("setParameterListener", "(Landroid/media/audiofx/PresetReverb$OnParameterChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#setPreset(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetPreset(short arg0)
        {
            IExecuteWithSignature("setPreset", "(S)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.html#setProperties(android.media.audiofx.PresetReverb.Settings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.PresetReverb.Settings"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetProperties(Android.Media.Audiofx.PresetReverb.Settings arg0)
        {
            IExecuteWithSignature("setProperties", "(Landroid/media/audiofx/PresetReverb$Settings;)V", arg0);
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
            /// Handler for <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.PresetReverb,int,int,short)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnParameterChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.Audiofx.PresetReverb, int, int, short> OnOnParameterChange { get; set; } = null;

            bool hasOverrideOnParameterChange = true;
            void OnParameterChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnParameterChange = true;
                var methodToExecute = (OnOnParameterChange != null) ? OnOnParameterChange : OnParameterChange;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Media.Audiofx.PresetReverb>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<short>(3));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnParameterChange;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.PresetReverb,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.PresetReverb"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            public virtual void OnParameterChange(Android.Media.Audiofx.PresetReverb arg0, int arg1, int arg2, short arg3)
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.PresetReverb,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.PresetReverb"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            public override void OnParameterChange(Android.Media.Audiofx.PresetReverb arg0, int arg1, int arg2, short arg3)
            {
                IExecute("onParameterChange", arg0, arg1, arg2, arg3);
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.Settings.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/PresetReverb.Settings.html#preset"/>
            /// </summary>
            public short preset { get { return IGetField<short>("preset"); } set { ISetField("preset", value); } }

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