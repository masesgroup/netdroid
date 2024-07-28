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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Animation
{
    #region TimeAnimator
    public partial class TimeAnimator
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
        /// <see href="https://developer.android.com/reference/android/animation/TimeAnimator.html#setTimeListener(android.animation.TimeAnimator.TimeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TimeAnimator.TimeListener"/></param>
        public void SetTimeListener(Android.Animation.TimeAnimator.TimeListener arg0)
        {
            IExecuteWithSignature("setTimeListener", "(Landroid/animation/TimeAnimator$TimeListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region TimeListener
        public partial class TimeListener
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
            /// Handlers initializer for <see cref="TimeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onTimeUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.TimeAnimator>>>(OnTimeUpdateEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/TimeAnimator.TimeListener.html#onTimeUpdate(android.animation.TimeAnimator,long,long)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnTimeUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.TimeAnimator, long, long> OnOnTimeUpdate { get; set; } = null;

            void OnTimeUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.TimeAnimator>> data)
            {
                var methodToExecute = (OnOnTimeUpdate != null) ? OnOnTimeUpdate : OnTimeUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0), data.EventData.GetAt<long>(1));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/TimeAnimator.TimeListener.html#onTimeUpdate(android.animation.TimeAnimator,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.TimeAnimator"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public virtual void OnTimeUpdate(Android.Animation.TimeAnimator arg0, long arg1, long arg2)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TimeListenerDirect
        public partial class TimeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/animation/TimeAnimator.TimeListener.html#onTimeUpdate(android.animation.TimeAnimator,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.TimeAnimator"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public override void OnTimeUpdate(Android.Animation.TimeAnimator arg0, long arg1, long arg2)
            {
                IExecute("onTimeUpdate", arg0, arg1, arg2);
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