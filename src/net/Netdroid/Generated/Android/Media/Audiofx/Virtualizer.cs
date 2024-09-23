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
    #region Virtualizer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class Virtualizer : Android.Media.Audiofx.AudioEffect
    {
        const string _bridgeClassName = "android.media.audiofx.Virtualizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Virtualizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Virtualizer(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.OnParameterChangeListener.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class OnParameterChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnParameterChangeListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.media.audiofx.Virtualizer_OnParameterChangeListener";
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
        
            const string _bridgeClassName = "android.media.audiofx.Virtualizer$OnParameterChangeListener";
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
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.Settings.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Settings : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Settings>
        {
            const string _bridgeClassName = "android.media.audiofx.Virtualizer$Settings";
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

    #region Virtualizer implementation
    public partial class Virtualizer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public Virtualizer(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#PARAM_STRENGTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PARAM_STRENGTH { get { if (!_PARAM_STRENGTHReady) { _PARAM_STRENGTHContent = SGetField<int>(LocalBridgeClazz, "PARAM_STRENGTH"); _PARAM_STRENGTHReady = true; } return _PARAM_STRENGTHContent; } }
        private static int _PARAM_STRENGTHContent = default;
        private static bool _PARAM_STRENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#PARAM_STRENGTH_SUPPORTED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PARAM_STRENGTH_SUPPORTED { get { if (!_PARAM_STRENGTH_SUPPORTEDReady) { _PARAM_STRENGTH_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "PARAM_STRENGTH_SUPPORTED"); _PARAM_STRENGTH_SUPPORTEDReady = true; } return _PARAM_STRENGTH_SUPPORTEDContent; } }
        private static int _PARAM_STRENGTH_SUPPORTEDContent = default;
        private static bool _PARAM_STRENGTH_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#VIRTUALIZATION_MODE_AUTO"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int VIRTUALIZATION_MODE_AUTO { get { if (!_VIRTUALIZATION_MODE_AUTOReady) { _VIRTUALIZATION_MODE_AUTOContent = SGetField<int>(LocalBridgeClazz, "VIRTUALIZATION_MODE_AUTO"); _VIRTUALIZATION_MODE_AUTOReady = true; } return _VIRTUALIZATION_MODE_AUTOContent; } }
        private static int _VIRTUALIZATION_MODE_AUTOContent = default;
        private static bool _VIRTUALIZATION_MODE_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#VIRTUALIZATION_MODE_BINAURAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int VIRTUALIZATION_MODE_BINAURAL { get { if (!_VIRTUALIZATION_MODE_BINAURALReady) { _VIRTUALIZATION_MODE_BINAURALContent = SGetField<int>(LocalBridgeClazz, "VIRTUALIZATION_MODE_BINAURAL"); _VIRTUALIZATION_MODE_BINAURALReady = true; } return _VIRTUALIZATION_MODE_BINAURALContent; } }
        private static int _VIRTUALIZATION_MODE_BINAURALContent = default;
        private static bool _VIRTUALIZATION_MODE_BINAURALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#VIRTUALIZATION_MODE_OFF"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int VIRTUALIZATION_MODE_OFF { get { if (!_VIRTUALIZATION_MODE_OFFReady) { _VIRTUALIZATION_MODE_OFFContent = SGetField<int>(LocalBridgeClazz, "VIRTUALIZATION_MODE_OFF"); _VIRTUALIZATION_MODE_OFFReady = true; } return _VIRTUALIZATION_MODE_OFFContent; } }
        private static int _VIRTUALIZATION_MODE_OFFContent = default;
        private static bool _VIRTUALIZATION_MODE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#VIRTUALIZATION_MODE_TRANSAURAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int VIRTUALIZATION_MODE_TRANSAURAL { get { if (!_VIRTUALIZATION_MODE_TRANSAURALReady) { _VIRTUALIZATION_MODE_TRANSAURALContent = SGetField<int>(LocalBridgeClazz, "VIRTUALIZATION_MODE_TRANSAURAL"); _VIRTUALIZATION_MODE_TRANSAURALReady = true; } return _VIRTUALIZATION_MODE_TRANSAURALContent; } }
        private static int _VIRTUALIZATION_MODE_TRANSAURALContent = default;
        private static bool _VIRTUALIZATION_MODE_TRANSAURALReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Audiofx.Virtualizer.Settings"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public Android.Media.Audiofx.Virtualizer.Settings GetProperties()
        {
            return IExecuteWithSignature<Android.Media.Audiofx.Virtualizer.Settings>("getProperties", "()Landroid/media/audiofx/Virtualizer$Settings;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#canVirtualize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public bool CanVirtualize(int arg0, int arg1)
        {
            return IExecute<bool>("canVirtualize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#forceVirtualizationMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public bool ForceVirtualizationMode(int arg0)
        {
            return IExecuteWithSignature<bool>("forceVirtualizationMode", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#getSpeakerAngles(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public bool GetSpeakerAngles(int arg0, int arg1, int[] arg2)
        {
            return IExecute<bool>("getSpeakerAngles", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#getStrengthSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetStrengthSupported()
        {
            return IExecuteWithSignature<bool>("getStrengthSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#getVirtualizationMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public int GetVirtualizationMode()
        {
            return IExecuteWithSignature<int>("getVirtualizationMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#getRoundedStrength()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public short GetRoundedStrength()
        {
            return IExecuteWithSignature<short>("getRoundedStrength", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#setParameterListener(android.media.audiofx.Virtualizer.OnParameterChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.Virtualizer.OnParameterChangeListener"/></param>
        [global::System.Obsolete()]
        public void SetParameterListener(Android.Media.Audiofx.Virtualizer.OnParameterChangeListener arg0)
        {
            IExecuteWithSignature("setParameterListener", "(Landroid/media/audiofx/Virtualizer$OnParameterChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#setProperties(android.media.audiofx.Virtualizer.Settings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.Virtualizer.Settings"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public void SetProperties(Android.Media.Audiofx.Virtualizer.Settings arg0)
        {
            IExecuteWithSignature("setProperties", "(Landroid/media/audiofx/Virtualizer$Settings;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.html#setStrength(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        [global::System.Obsolete()]
        public void SetStrength(short arg0)
        {
            IExecuteWithSignature("setStrength", "(S)V", arg0);
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
            /// Handler for <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Virtualizer,int,int,short)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnParameterChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.Audiofx.Virtualizer, int, int, short> OnOnParameterChange { get; set; } = null;
            
            bool hasOverrideOnParameterChange = true;
            void OnParameterChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnParameterChange = true;
                var methodToExecute = (OnOnParameterChange != null) ? OnOnParameterChange : OnParameterChange;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Media.Audiofx.Virtualizer>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<short>(3));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnParameterChange;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Virtualizer,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.Virtualizer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            [global::System.Obsolete()]
            public virtual void OnParameterChange(Android.Media.Audiofx.Virtualizer arg0, int arg1, int arg2, short arg3)
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.Virtualizer,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.Virtualizer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            [global::System.Obsolete()]
            public override void OnParameterChange(Android.Media.Audiofx.Virtualizer arg0, int arg1, int arg2, short arg3)
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.Settings.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public Settings(Java.Lang.String arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/Virtualizer.Settings.html#strength"/>
            /// </summary>
            [global::System.Obsolete()]
            public short strength { get { return IGetField<short>("strength"); } set { ISetField("strength", value); } }
        
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