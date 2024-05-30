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

namespace Android.Widget
{
    #region Chronometer
    public partial class Chronometer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public Chronometer(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getBase()"/> <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setBase(long)"/>
        /// </summary>
        public long Base
        {
            get { return IExecuteWithSignature<long>("getBase", "()J"); } set { IExecuteWithSignature("setBase", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getFormat()"/> <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setFormat(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Format
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFormat", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getOnChronometerTickListener()"/> 
        /// </summary>
        public Android.Widget.Chronometer.OnChronometerTickListener GetOnChronometerTickListener
        {
            get { return IExecuteWithSignature<Android.Widget.Chronometer.OnChronometerTickListener>("getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#isCountDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCountDown()
        {
            return IExecuteWithSignature<bool>("isCountDown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#isTheFinalCountDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTheFinalCountDown()
        {
            return IExecuteWithSignature<bool>("isTheFinalCountDown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setCountDown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCountDown(bool arg0)
        {
            IExecuteWithSignature("setCountDown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.Chronometer.OnChronometerTickListener"/></param>
        public void SetOnChronometerTickListener(Android.Widget.Chronometer.OnChronometerTickListener arg0)
        {
            IExecuteWithSignature("setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes
        #region OnChronometerTickListener
        public partial class OnChronometerTickListener
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
            /// Handlers initializer for <see cref="OnChronometerTickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onChronometerTick", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.Chronometer>>>(OnChronometerTickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnChronometerTick"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Widget.Chronometer> OnOnChronometerTick { get; set; } = null;

            void OnChronometerTickEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.Chronometer>> data)
            {
                var methodToExecute = (OnOnChronometerTick != null) ? OnOnChronometerTick : OnChronometerTick;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.Chronometer"/></param>
            public virtual void OnChronometerTick(Android.Widget.Chronometer arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnChronometerTickListenerDirect
        public partial class OnChronometerTickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.Chronometer"/></param>
            public override void OnChronometerTick(Android.Widget.Chronometer arg0)
            {
                IExecuteWithSignature("onChronometerTick", "(Landroid/widget/Chronometer;)V", arg0);
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