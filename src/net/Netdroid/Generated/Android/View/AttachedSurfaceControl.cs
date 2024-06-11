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

namespace Android.View
{
    #region IAttachedSurfaceControl
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttachedSurfaceControl
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AttachedSurfaceControl
    public partial class AttachedSurfaceControl : Android.View.IAttachedSurfaceControl
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
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#buildReparentTransaction(android.view.SurfaceControl)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceControl"/></param>
        /// <returns><see cref="Android.View.SurfaceControl.Transaction"/></returns>
        public Android.View.SurfaceControl.Transaction BuildReparentTransaction(Android.View.SurfaceControl arg0)
        {
            return IExecuteWithSignature<Android.View.SurfaceControl.Transaction>("buildReparentTransaction", "(Landroid/view/SurfaceControl;)Landroid/view/SurfaceControl$Transaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#applyTransactionOnDraw(android.view.SurfaceControl.Transaction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceControl.Transaction"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ApplyTransactionOnDraw(Android.View.SurfaceControl.Transaction arg0)
        {
            return IExecuteWithSignature<bool>("applyTransactionOnDraw", "(Landroid/view/SurfaceControl$Transaction;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#getBufferTransformHint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBufferTransformHint()
        {
            return IExecuteWithSignature<int>("getBufferTransformHint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#addOnBufferTransformHintChangedListener(android.view.AttachedSurfaceControl.OnBufferTransformHintChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.AttachedSurfaceControl.OnBufferTransformHintChangedListener"/></param>
        public void AddOnBufferTransformHintChangedListener(Android.View.AttachedSurfaceControl.OnBufferTransformHintChangedListener arg0)
        {
            IExecuteWithSignature("addOnBufferTransformHintChangedListener", "(Landroid/view/AttachedSurfaceControl$OnBufferTransformHintChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#removeOnBufferTransformHintChangedListener(android.view.AttachedSurfaceControl.OnBufferTransformHintChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.AttachedSurfaceControl.OnBufferTransformHintChangedListener"/></param>
        public void RemoveOnBufferTransformHintChangedListener(Android.View.AttachedSurfaceControl.OnBufferTransformHintChangedListener arg0)
        {
            IExecuteWithSignature("removeOnBufferTransformHintChangedListener", "(Landroid/view/AttachedSurfaceControl$OnBufferTransformHintChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#setChildBoundingInsets(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetChildBoundingInsets(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setChildBoundingInsets", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.html#setTouchableRegion(android.graphics.Region)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Region"/></param>
        public void SetTouchableRegion(Android.Graphics.Region arg0)
        {
            IExecuteWithSignature("setTouchableRegion", "(Landroid/graphics/Region;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnBufferTransformHintChangedListener
        public partial class OnBufferTransformHintChangedListener
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
            /// Handlers initializer for <see cref="OnBufferTransformHintChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onBufferTransformHintChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnBufferTransformHintChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.OnBufferTransformHintChangedListener.html#onBufferTransformHintChanged(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnBufferTransformHintChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnBufferTransformHintChanged { get; set; } = null;

            void OnBufferTransformHintChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnBufferTransformHintChanged != null) ? OnOnBufferTransformHintChanged : OnBufferTransformHintChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.OnBufferTransformHintChangedListener.html#onBufferTransformHintChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnBufferTransformHintChanged(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnBufferTransformHintChangedListenerDirect
        public partial class OnBufferTransformHintChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/AttachedSurfaceControl.OnBufferTransformHintChangedListener.html#onBufferTransformHintChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnBufferTransformHintChanged(int arg0)
            {
                IExecuteWithSignature("onBufferTransformHintChanged", "(I)V", arg0);
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