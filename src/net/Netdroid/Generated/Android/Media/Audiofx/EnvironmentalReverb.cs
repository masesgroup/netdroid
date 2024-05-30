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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media.Audiofx
{
    #region EnvironmentalReverb
    public partial class EnvironmentalReverb
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public EnvironmentalReverb(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_DECAY_HF_RATIO"/>
        /// </summary>
        public static int PARAM_DECAY_HF_RATIO { get { if (!_PARAM_DECAY_HF_RATIOReady) { _PARAM_DECAY_HF_RATIOContent = SGetField<int>(LocalBridgeClazz, "PARAM_DECAY_HF_RATIO"); _PARAM_DECAY_HF_RATIOReady = true; } return _PARAM_DECAY_HF_RATIOContent; } }
        private static int _PARAM_DECAY_HF_RATIOContent = default;
        private static bool _PARAM_DECAY_HF_RATIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_DECAY_TIME"/>
        /// </summary>
        public static int PARAM_DECAY_TIME { get { if (!_PARAM_DECAY_TIMEReady) { _PARAM_DECAY_TIMEContent = SGetField<int>(LocalBridgeClazz, "PARAM_DECAY_TIME"); _PARAM_DECAY_TIMEReady = true; } return _PARAM_DECAY_TIMEContent; } }
        private static int _PARAM_DECAY_TIMEContent = default;
        private static bool _PARAM_DECAY_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_DENSITY"/>
        /// </summary>
        public static int PARAM_DENSITY { get { if (!_PARAM_DENSITYReady) { _PARAM_DENSITYContent = SGetField<int>(LocalBridgeClazz, "PARAM_DENSITY"); _PARAM_DENSITYReady = true; } return _PARAM_DENSITYContent; } }
        private static int _PARAM_DENSITYContent = default;
        private static bool _PARAM_DENSITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_DIFFUSION"/>
        /// </summary>
        public static int PARAM_DIFFUSION { get { if (!_PARAM_DIFFUSIONReady) { _PARAM_DIFFUSIONContent = SGetField<int>(LocalBridgeClazz, "PARAM_DIFFUSION"); _PARAM_DIFFUSIONReady = true; } return _PARAM_DIFFUSIONContent; } }
        private static int _PARAM_DIFFUSIONContent = default;
        private static bool _PARAM_DIFFUSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_REFLECTIONS_DELAY"/>
        /// </summary>
        public static int PARAM_REFLECTIONS_DELAY { get { if (!_PARAM_REFLECTIONS_DELAYReady) { _PARAM_REFLECTIONS_DELAYContent = SGetField<int>(LocalBridgeClazz, "PARAM_REFLECTIONS_DELAY"); _PARAM_REFLECTIONS_DELAYReady = true; } return _PARAM_REFLECTIONS_DELAYContent; } }
        private static int _PARAM_REFLECTIONS_DELAYContent = default;
        private static bool _PARAM_REFLECTIONS_DELAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_REFLECTIONS_LEVEL"/>
        /// </summary>
        public static int PARAM_REFLECTIONS_LEVEL { get { if (!_PARAM_REFLECTIONS_LEVELReady) { _PARAM_REFLECTIONS_LEVELContent = SGetField<int>(LocalBridgeClazz, "PARAM_REFLECTIONS_LEVEL"); _PARAM_REFLECTIONS_LEVELReady = true; } return _PARAM_REFLECTIONS_LEVELContent; } }
        private static int _PARAM_REFLECTIONS_LEVELContent = default;
        private static bool _PARAM_REFLECTIONS_LEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_REVERB_DELAY"/>
        /// </summary>
        public static int PARAM_REVERB_DELAY { get { if (!_PARAM_REVERB_DELAYReady) { _PARAM_REVERB_DELAYContent = SGetField<int>(LocalBridgeClazz, "PARAM_REVERB_DELAY"); _PARAM_REVERB_DELAYReady = true; } return _PARAM_REVERB_DELAYContent; } }
        private static int _PARAM_REVERB_DELAYContent = default;
        private static bool _PARAM_REVERB_DELAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_REVERB_LEVEL"/>
        /// </summary>
        public static int PARAM_REVERB_LEVEL { get { if (!_PARAM_REVERB_LEVELReady) { _PARAM_REVERB_LEVELContent = SGetField<int>(LocalBridgeClazz, "PARAM_REVERB_LEVEL"); _PARAM_REVERB_LEVELReady = true; } return _PARAM_REVERB_LEVELContent; } }
        private static int _PARAM_REVERB_LEVELContent = default;
        private static bool _PARAM_REVERB_LEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_ROOM_HF_LEVEL"/>
        /// </summary>
        public static int PARAM_ROOM_HF_LEVEL { get { if (!_PARAM_ROOM_HF_LEVELReady) { _PARAM_ROOM_HF_LEVELContent = SGetField<int>(LocalBridgeClazz, "PARAM_ROOM_HF_LEVEL"); _PARAM_ROOM_HF_LEVELReady = true; } return _PARAM_ROOM_HF_LEVELContent; } }
        private static int _PARAM_ROOM_HF_LEVELContent = default;
        private static bool _PARAM_ROOM_HF_LEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#PARAM_ROOM_LEVEL"/>
        /// </summary>
        public static int PARAM_ROOM_LEVEL { get { if (!_PARAM_ROOM_LEVELReady) { _PARAM_ROOM_LEVELContent = SGetField<int>(LocalBridgeClazz, "PARAM_ROOM_LEVEL"); _PARAM_ROOM_LEVELReady = true; } return _PARAM_ROOM_LEVELContent; } }
        private static int _PARAM_ROOM_LEVELContent = default;
        private static bool _PARAM_ROOM_LEVELReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getDecayHFRatio()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setDecayHFRatio(short)"/>
        /// </summary>
        public short DecayHFRatio
        {
            get { return IExecuteWithSignature<short>("getDecayHFRatio", "()S"); } set { IExecuteWithSignature("setDecayHFRatio", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getDecayTime()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setDecayTime(int)"/>
        /// </summary>
        public int DecayTime
        {
            get { return IExecuteWithSignature<int>("getDecayTime", "()I"); } set { IExecuteWithSignature("setDecayTime", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getDensity()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setDensity(short)"/>
        /// </summary>
        public short Density
        {
            get { return IExecuteWithSignature<short>("getDensity", "()S"); } set { IExecuteWithSignature("setDensity", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getDiffusion()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setDiffusion(short)"/>
        /// </summary>
        public short Diffusion
        {
            get { return IExecuteWithSignature<short>("getDiffusion", "()S"); } set { IExecuteWithSignature("setDiffusion", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getProperties()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setProperties(android.media.audiofx.EnvironmentalReverb.Settings)"/>
        /// </summary>
        public Android.Media.Audiofx.EnvironmentalReverb.Settings Properties
        {
            get { return IExecuteWithSignature<Android.Media.Audiofx.EnvironmentalReverb.Settings>("getProperties", "()Landroid/media/audiofx/EnvironmentalReverb$Settings;"); } set { IExecuteWithSignature("setProperties", "(Landroid/media/audiofx/EnvironmentalReverb$Settings;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getReflectionsDelay()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setReflectionsDelay(int)"/>
        /// </summary>
        public int ReflectionsDelay
        {
            get { return IExecuteWithSignature<int>("getReflectionsDelay", "()I"); } set { IExecuteWithSignature("setReflectionsDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getReflectionsLevel()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setReflectionsLevel(short)"/>
        /// </summary>
        public short ReflectionsLevel
        {
            get { return IExecuteWithSignature<short>("getReflectionsLevel", "()S"); } set { IExecuteWithSignature("setReflectionsLevel", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getReverbDelay()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setReverbDelay(int)"/>
        /// </summary>
        public int ReverbDelay
        {
            get { return IExecuteWithSignature<int>("getReverbDelay", "()I"); } set { IExecuteWithSignature("setReverbDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getReverbLevel()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setReverbLevel(short)"/>
        /// </summary>
        public short ReverbLevel
        {
            get { return IExecuteWithSignature<short>("getReverbLevel", "()S"); } set { IExecuteWithSignature("setReverbLevel", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getRoomHFLevel()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setRoomHFLevel(short)"/>
        /// </summary>
        public short RoomHFLevel
        {
            get { return IExecuteWithSignature<short>("getRoomHFLevel", "()S"); } set { IExecuteWithSignature("setRoomHFLevel", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#getRoomLevel()"/> <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setRoomLevel(short)"/>
        /// </summary>
        public short RoomLevel
        {
            get { return IExecuteWithSignature<short>("getRoomLevel", "()S"); } set { IExecuteWithSignature("setRoomLevel", "(S)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.html#setParameterListener(android.media.audiofx.EnvironmentalReverb.OnParameterChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.EnvironmentalReverb.OnParameterChangeListener"/></param>
        public void SetParameterListener(Android.Media.Audiofx.EnvironmentalReverb.OnParameterChangeListener arg0)
        {
            IExecuteWithSignature("setParameterListener", "(Landroid/media/audiofx/EnvironmentalReverb$OnParameterChangeListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnParameterChangeListener
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
                AddEventHandler("onParameterChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Audiofx.EnvironmentalReverb>>>(OnParameterChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.EnvironmentalReverb,int,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnParameterChange"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Media.Audiofx.EnvironmentalReverb, int, int, int> OnOnParameterChange { get; set; } = null;

            void OnParameterChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Audiofx.EnvironmentalReverb>> data)
            {
                var methodToExecute = (OnOnParameterChange != null) ? OnOnParameterChange : OnParameterChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.EnvironmentalReverb,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.EnvironmentalReverb"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public virtual void OnParameterChange(Android.Media.Audiofx.EnvironmentalReverb arg0, int arg1, int arg2, int arg3)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnParameterChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.EnvironmentalReverb,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.EnvironmentalReverb"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public override void OnParameterChange(Android.Media.Audiofx.EnvironmentalReverb arg0, int arg1, int arg2, int arg3)
            {
                IExecute("onParameterChange", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Settings
        public partial class Settings
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#decayTime"/>
            /// </summary>
            public int decayTime { get { return IGetField<int>("decayTime"); } set { ISetField("decayTime", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#reflectionsDelay"/>
            /// </summary>
            public int reflectionsDelay { get { return IGetField<int>("reflectionsDelay"); } set { ISetField("reflectionsDelay", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#reverbDelay"/>
            /// </summary>
            public int reverbDelay { get { return IGetField<int>("reverbDelay"); } set { ISetField("reverbDelay", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#decayHFRatio"/>
            /// </summary>
            public short decayHFRatio { get { return IGetField<short>("decayHFRatio"); } set { ISetField("decayHFRatio", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#density"/>
            /// </summary>
            public short density { get { return IGetField<short>("density"); } set { ISetField("density", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#diffusion"/>
            /// </summary>
            public short diffusion { get { return IGetField<short>("diffusion"); } set { ISetField("diffusion", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#reflectionsLevel"/>
            /// </summary>
            public short reflectionsLevel { get { return IGetField<short>("reflectionsLevel"); } set { ISetField("reflectionsLevel", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#reverbLevel"/>
            /// </summary>
            public short reverbLevel { get { return IGetField<short>("reverbLevel"); } set { ISetField("reverbLevel", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#roomHFLevel"/>
            /// </summary>
            public short roomHFLevel { get { return IGetField<short>("roomHFLevel"); } set { ISetField("roomHFLevel", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/EnvironmentalReverb.Settings.html#roomLevel"/>
            /// </summary>
            public short roomLevel { get { return IGetField<short>("roomLevel"); } set { ISetField("roomLevel", value); } }

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