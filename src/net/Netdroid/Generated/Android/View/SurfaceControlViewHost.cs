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

namespace Android.View
{
    #region SurfaceControlViewHost
    public partial class SurfaceControlViewHost
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#%3Cinit%3E(android.content.Context,android.view.Display,android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Display"/></param>
        /// <param name="arg2"><see cref="Android.Os.IBinder"/></param>
        public SurfaceControlViewHost(Android.Content.Context arg0, Android.View.Display arg1, Android.Os.IBinder arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#getSurfacePackage()"/> 
        /// </summary>
        public Android.View.SurfaceControlViewHost.SurfacePackage GetSurfacePackage
        {
            get { return IExecuteWithSignature<Android.View.SurfaceControlViewHost.SurfacePackage>("getSurfacePackage", "()Landroid/view/SurfaceControlViewHost$SurfacePackage;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#getView()"/> 
        /// </summary>
        public Android.View.View View
        {
            get { return IExecuteWithSignature<Android.View.View>("getView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#transferTouchGestureToHost()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TransferTouchGestureToHost()
        {
            return IExecuteWithSignature<bool>("transferTouchGestureToHost", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#relayout(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Relayout(int arg0, int arg1)
        {
            IExecute("relayout", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.html#setView(android.view.View,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetView(Android.View.View arg0, int arg1, int arg2)
        {
            IExecute("setView", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region SurfacePackage
        public partial class SurfacePackage
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#%3Cinit%3E(android.view.SurfaceControlViewHost.SurfacePackage)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceControlViewHost.SurfacePackage"/></param>
            public SurfacePackage(Android.View.SurfaceControlViewHost.SurfacePackage arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#getSurfaceControl()"/> 
            /// </summary>
            public Android.View.SurfaceControl SurfaceControl
            {
                get { return IExecuteWithSignature<Android.View.SurfaceControl>("getSurfaceControl", "()Landroid/view/SurfaceControl;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#notifyConfigurationChanged(android.content.res.Configuration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Configuration"/></param>
            public void NotifyConfigurationChanged(Android.Content.Res.Configuration arg0)
            {
                IExecuteWithSignature("notifyConfigurationChanged", "(Landroid/content/res/Configuration;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#notifyDetachedFromWindow()"/>
            /// </summary>
            public void NotifyDetachedFromWindow()
            {
                IExecuteWithSignature("notifyDetachedFromWindow", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#release()"/>
            /// </summary>
            public void Release()
            {
                IExecuteWithSignature("release", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceControlViewHost.SurfacePackage.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
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