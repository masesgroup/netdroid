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

namespace Android.Media
{
    #region Spatializer
    public partial class Spatializer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNEL"/>
        /// </summary>
        public static int SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNEL { get { if (!_SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELReady) { _SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELContent = SGetField<int>(LocalBridgeClazz, "SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNEL"); _SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELReady = true; } return _SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELContent; } }
        private static int _SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELContent = default;
        private static bool _SPATIALIZER_IMMERSIVE_LEVEL_MULTICHANNELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#SPATIALIZER_IMMERSIVE_LEVEL_NONE"/>
        /// </summary>
        public static int SPATIALIZER_IMMERSIVE_LEVEL_NONE { get { if (!_SPATIALIZER_IMMERSIVE_LEVEL_NONEReady) { _SPATIALIZER_IMMERSIVE_LEVEL_NONEContent = SGetField<int>(LocalBridgeClazz, "SPATIALIZER_IMMERSIVE_LEVEL_NONE"); _SPATIALIZER_IMMERSIVE_LEVEL_NONEReady = true; } return _SPATIALIZER_IMMERSIVE_LEVEL_NONEContent; } }
        private static int _SPATIALIZER_IMMERSIVE_LEVEL_NONEContent = default;
        private static bool _SPATIALIZER_IMMERSIVE_LEVEL_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#SPATIALIZER_IMMERSIVE_LEVEL_OTHER"/>
        /// </summary>
        public static int SPATIALIZER_IMMERSIVE_LEVEL_OTHER { get { if (!_SPATIALIZER_IMMERSIVE_LEVEL_OTHERReady) { _SPATIALIZER_IMMERSIVE_LEVEL_OTHERContent = SGetField<int>(LocalBridgeClazz, "SPATIALIZER_IMMERSIVE_LEVEL_OTHER"); _SPATIALIZER_IMMERSIVE_LEVEL_OTHERReady = true; } return _SPATIALIZER_IMMERSIVE_LEVEL_OTHERContent; } }
        private static int _SPATIALIZER_IMMERSIVE_LEVEL_OTHERContent = default;
        private static bool _SPATIALIZER_IMMERSIVE_LEVEL_OTHERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#getImmersiveAudioLevel()"/> 
        /// </summary>
        public int ImmersiveAudioLevel
        {
            get { return IExecuteWithSignature<int>("getImmersiveAudioLevel", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#canBeSpatialized(android.media.AudioAttributes,android.media.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioAttributes"/></param>
        /// <param name="arg1"><see cref="Android.Media.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanBeSpatialized(Android.Media.AudioAttributes arg0, Android.Media.AudioFormat arg1)
        {
            return IExecute<bool>("canBeSpatialized", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAvailable()
        {
            return IExecuteWithSignature<bool>("isAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#isHeadTrackerAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHeadTrackerAvailable()
        {
            return IExecuteWithSignature<bool>("isHeadTrackerAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#addOnHeadTrackerAvailableListener(java.util.concurrent.Executor,android.media.Spatializer.OnHeadTrackerAvailableListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Media.Spatializer.OnHeadTrackerAvailableListener"/></param>
        public void AddOnHeadTrackerAvailableListener(Java.Util.Concurrent.Executor arg0, Android.Media.Spatializer.OnHeadTrackerAvailableListener arg1)
        {
            IExecute("addOnHeadTrackerAvailableListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#addOnSpatializerStateChangedListener(java.util.concurrent.Executor,android.media.Spatializer.OnSpatializerStateChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Media.Spatializer.OnSpatializerStateChangedListener"/></param>
        public void AddOnSpatializerStateChangedListener(Java.Util.Concurrent.Executor arg0, Android.Media.Spatializer.OnSpatializerStateChangedListener arg1)
        {
            IExecute("addOnSpatializerStateChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#removeOnHeadTrackerAvailableListener(android.media.Spatializer.OnHeadTrackerAvailableListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Spatializer.OnHeadTrackerAvailableListener"/></param>
        public void RemoveOnHeadTrackerAvailableListener(Android.Media.Spatializer.OnHeadTrackerAvailableListener arg0)
        {
            IExecuteWithSignature("removeOnHeadTrackerAvailableListener", "(Landroid/media/Spatializer$OnHeadTrackerAvailableListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Spatializer.html#removeOnSpatializerStateChangedListener(android.media.Spatializer.OnSpatializerStateChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Spatializer.OnSpatializerStateChangedListener"/></param>
        public void RemoveOnSpatializerStateChangedListener(Android.Media.Spatializer.OnSpatializerStateChangedListener arg0)
        {
            IExecuteWithSignature("removeOnSpatializerStateChangedListener", "(Landroid/media/Spatializer$OnSpatializerStateChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnHeadTrackerAvailableListener
        public partial class OnHeadTrackerAvailableListener
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
            /// Handlers initializer for <see cref="OnHeadTrackerAvailableListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onHeadTrackerAvailableChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>>>(OnHeadTrackerAvailableChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/Spatializer.OnHeadTrackerAvailableListener.html#onHeadTrackerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnHeadTrackerAvailableChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Media.Spatializer, bool> OnOnHeadTrackerAvailableChanged { get; set; } = null;

            void OnHeadTrackerAvailableChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>> data)
            {
                var methodToExecute = (OnOnHeadTrackerAvailableChanged != null) ? OnOnHeadTrackerAvailableChanged : OnHeadTrackerAvailableChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnHeadTrackerAvailableListener.html#onHeadTrackerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public virtual void OnHeadTrackerAvailableChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnHeadTrackerAvailableListenerDirect
        public partial class OnHeadTrackerAvailableListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnHeadTrackerAvailableListener.html#onHeadTrackerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnHeadTrackerAvailableChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                IExecute("onHeadTrackerAvailableChanged", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSpatializerStateChangedListener
        public partial class OnSpatializerStateChangedListener
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
            /// Handlers initializer for <see cref="OnSpatializerStateChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSpatializerAvailableChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>>>(OnSpatializerAvailableChangedEventHandler));
                AddEventHandler("onSpatializerEnabledChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>>>(OnSpatializerEnabledChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSpatializerAvailableChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Media.Spatializer, bool> OnOnSpatializerAvailableChanged { get; set; } = null;

            void OnSpatializerAvailableChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>> data)
            {
                var methodToExecute = (OnOnSpatializerAvailableChanged != null) ? OnOnSpatializerAvailableChanged : OnSpatializerAvailableChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public virtual void OnSpatializerAvailableChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerEnabledChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSpatializerEnabledChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Media.Spatializer, bool> OnOnSpatializerEnabledChanged { get; set; } = null;

            void OnSpatializerEnabledChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Spatializer>> data)
            {
                var methodToExecute = (OnOnSpatializerEnabledChanged != null) ? OnOnSpatializerEnabledChanged : OnSpatializerEnabledChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerEnabledChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public virtual void OnSpatializerEnabledChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSpatializerStateChangedListenerDirect
        public partial class OnSpatializerStateChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerAvailableChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnSpatializerAvailableChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                IExecute("onSpatializerAvailableChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Spatializer.OnSpatializerStateChangedListener.html#onSpatializerEnabledChanged(android.media.Spatializer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Spatializer"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnSpatializerEnabledChanged(Android.Media.Spatializer arg0, bool arg1)
            {
                IExecute("onSpatializerEnabledChanged", arg0, arg1);
            }

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