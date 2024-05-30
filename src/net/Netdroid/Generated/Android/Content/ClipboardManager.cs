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

namespace Android.Content
{
    #region ClipboardManager
    public partial class ClipboardManager
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
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#getPrimaryClip()"/> <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#setPrimaryClip(android.content.ClipData)"/>
        /// </summary>
        public Android.Content.ClipData PrimaryClip
        {
            get { return IExecuteWithSignature<Android.Content.ClipData>("getPrimaryClip", "()Landroid/content/ClipData;"); } set { IExecuteWithSignature("setPrimaryClip", "(Landroid/content/ClipData;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#getPrimaryClipDescription()"/> 
        /// </summary>
        public Android.Content.ClipDescription PrimaryClipDescription
        {
            get { return IExecuteWithSignature<Android.Content.ClipDescription>("getPrimaryClipDescription", "()Landroid/content/ClipDescription;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#hasPrimaryClip()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPrimaryClip()
        {
            return IExecuteWithSignature<bool>("hasPrimaryClip", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#addPrimaryClipChangedListener(android.content.ClipboardManager.OnPrimaryClipChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipboardManager.OnPrimaryClipChangedListener"/></param>
        public void AddPrimaryClipChangedListener(Android.Content.ClipboardManager.OnPrimaryClipChangedListener arg0)
        {
            IExecuteWithSignature("addPrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#clearPrimaryClip()"/>
        /// </summary>
        public void ClearPrimaryClip()
        {
            IExecuteWithSignature("clearPrimaryClip", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#removePrimaryClipChangedListener(android.content.ClipboardManager.OnPrimaryClipChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipboardManager.OnPrimaryClipChangedListener"/></param>
        public void RemovePrimaryClipChangedListener(Android.Content.ClipboardManager.OnPrimaryClipChangedListener arg0)
        {
            IExecuteWithSignature("removePrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnPrimaryClipChangedListener
        public partial class OnPrimaryClipChangedListener
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
            /// Handlers initializer for <see cref="OnPrimaryClipChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onPrimaryClipChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnPrimaryClipChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPrimaryClipChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnOnPrimaryClipChanged { get; set; } = null;

            void OnPrimaryClipChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnPrimaryClipChanged != null) ? OnOnPrimaryClipChanged : OnPrimaryClipChanged;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            public virtual void OnPrimaryClipChanged()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnPrimaryClipChangedListenerDirect
        public partial class OnPrimaryClipChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            public override void OnPrimaryClipChanged()
            {
                IExecuteWithSignature("onPrimaryClipChanged", "()V");
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