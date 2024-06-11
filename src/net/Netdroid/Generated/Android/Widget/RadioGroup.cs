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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region RadioGroup
    public partial class RadioGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public RadioGroup(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public RadioGroup(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#getCheckedRadioButtonId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCheckedRadioButtonId()
        {
            return IExecuteWithSignature<int>("getCheckedRadioButtonId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#check(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Check(int arg0)
        {
            IExecuteWithSignature("check", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#clearCheck()"/>
        /// </summary>
        public void ClearCheck()
        {
            IExecuteWithSignature("clearCheck", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.html#setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.RadioGroup.OnCheckedChangeListener"/></param>
        public void SetOnCheckedChangeListener(Android.Widget.RadioGroup.OnCheckedChangeListener arg0)
        {
            IExecuteWithSignature("setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LayoutParams
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.MarginLayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.MarginLayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.MarginLayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.LayoutParams.html#%3Cinit%3E(int,int,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            public LayoutParams(int arg0, int arg1, float arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public LayoutParams(int arg0, int arg1)
                : base(arg0, arg1)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnCheckedChangeListener
        public partial class OnCheckedChangeListener
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
            /// Handlers initializer for <see cref="OnCheckedChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onCheckedChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.RadioGroup>>>(OnCheckedChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/RadioGroup.OnCheckedChangeListener.html#onCheckedChanged(android.widget.RadioGroup,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnCheckedChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.RadioGroup, int> OnOnCheckedChanged { get; set; } = null;

            void OnCheckedChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.RadioGroup>> data)
            {
                var methodToExecute = (OnOnCheckedChanged != null) ? OnOnCheckedChanged : OnCheckedChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.OnCheckedChangeListener.html#onCheckedChanged(android.widget.RadioGroup,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RadioGroup"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public virtual void OnCheckedChanged(Android.Widget.RadioGroup arg0, int arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnCheckedChangeListenerDirect
        public partial class OnCheckedChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/RadioGroup.OnCheckedChangeListener.html#onCheckedChanged(android.widget.RadioGroup,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RadioGroup"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public override void OnCheckedChanged(Android.Widget.RadioGroup arg0, int arg1)
            {
                IExecute("onCheckedChanged", arg0, arg1);
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