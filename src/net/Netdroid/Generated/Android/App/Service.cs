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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App
{
    #region Service
    public partial class Service
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.App.Service"/> to <see cref="Android.Content.ComponentCallbacks2"/>
        /// </summary>
        public static implicit operator Android.Content.ComponentCallbacks2(Android.App.Service t) => t.Cast<Android.Content.ComponentCallbacks2>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_CONTINUATION_MASK"/>
        /// </summary>
        public static int START_CONTINUATION_MASK { get { if (!_START_CONTINUATION_MASKReady) { _START_CONTINUATION_MASKContent = SGetField<int>(LocalBridgeClazz, "START_CONTINUATION_MASK"); _START_CONTINUATION_MASKReady = true; } return _START_CONTINUATION_MASKContent; } }
        private static int _START_CONTINUATION_MASKContent = default;
        private static bool _START_CONTINUATION_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_FLAG_REDELIVERY"/>
        /// </summary>
        public static int START_FLAG_REDELIVERY { get { if (!_START_FLAG_REDELIVERYReady) { _START_FLAG_REDELIVERYContent = SGetField<int>(LocalBridgeClazz, "START_FLAG_REDELIVERY"); _START_FLAG_REDELIVERYReady = true; } return _START_FLAG_REDELIVERYContent; } }
        private static int _START_FLAG_REDELIVERYContent = default;
        private static bool _START_FLAG_REDELIVERYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_FLAG_RETRY"/>
        /// </summary>
        public static int START_FLAG_RETRY { get { if (!_START_FLAG_RETRYReady) { _START_FLAG_RETRYContent = SGetField<int>(LocalBridgeClazz, "START_FLAG_RETRY"); _START_FLAG_RETRYReady = true; } return _START_FLAG_RETRYContent; } }
        private static int _START_FLAG_RETRYContent = default;
        private static bool _START_FLAG_RETRYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_NOT_STICKY"/>
        /// </summary>
        public static int START_NOT_STICKY { get { if (!_START_NOT_STICKYReady) { _START_NOT_STICKYContent = SGetField<int>(LocalBridgeClazz, "START_NOT_STICKY"); _START_NOT_STICKYReady = true; } return _START_NOT_STICKYContent; } }
        private static int _START_NOT_STICKYContent = default;
        private static bool _START_NOT_STICKYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_REDELIVER_INTENT"/>
        /// </summary>
        public static int START_REDELIVER_INTENT { get { if (!_START_REDELIVER_INTENTReady) { _START_REDELIVER_INTENTContent = SGetField<int>(LocalBridgeClazz, "START_REDELIVER_INTENT"); _START_REDELIVER_INTENTReady = true; } return _START_REDELIVER_INTENTContent; } }
        private static int _START_REDELIVER_INTENTContent = default;
        private static bool _START_REDELIVER_INTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_STICKY"/>
        /// </summary>
        public static int START_STICKY { get { if (!_START_STICKYReady) { _START_STICKYContent = SGetField<int>(LocalBridgeClazz, "START_STICKY"); _START_STICKYReady = true; } return _START_STICKYContent; } }
        private static int _START_STICKYContent = default;
        private static bool _START_STICKYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#START_STICKY_COMPATIBILITY"/>
        /// </summary>
        public static int START_STICKY_COMPATIBILITY { get { if (!_START_STICKY_COMPATIBILITYReady) { _START_STICKY_COMPATIBILITYContent = SGetField<int>(LocalBridgeClazz, "START_STICKY_COMPATIBILITY"); _START_STICKY_COMPATIBILITYReady = true; } return _START_STICKY_COMPATIBILITYContent; } }
        private static int _START_STICKY_COMPATIBILITYContent = default;
        private static bool _START_STICKY_COMPATIBILITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#STOP_FOREGROUND_DETACH"/>
        /// </summary>
        public static int STOP_FOREGROUND_DETACH { get { if (!_STOP_FOREGROUND_DETACHReady) { _STOP_FOREGROUND_DETACHContent = SGetField<int>(LocalBridgeClazz, "STOP_FOREGROUND_DETACH"); _STOP_FOREGROUND_DETACHReady = true; } return _STOP_FOREGROUND_DETACHContent; } }
        private static int _STOP_FOREGROUND_DETACHContent = default;
        private static bool _STOP_FOREGROUND_DETACHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#STOP_FOREGROUND_LEGACY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STOP_FOREGROUND_LEGACY { get { if (!_STOP_FOREGROUND_LEGACYReady) { _STOP_FOREGROUND_LEGACYContent = SGetField<int>(LocalBridgeClazz, "STOP_FOREGROUND_LEGACY"); _STOP_FOREGROUND_LEGACYReady = true; } return _STOP_FOREGROUND_LEGACYContent; } }
        private static int _STOP_FOREGROUND_LEGACYContent = default;
        private static bool _STOP_FOREGROUND_LEGACYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#STOP_FOREGROUND_REMOVE"/>
        /// </summary>
        public static int STOP_FOREGROUND_REMOVE { get { if (!_STOP_FOREGROUND_REMOVEReady) { _STOP_FOREGROUND_REMOVEContent = SGetField<int>(LocalBridgeClazz, "STOP_FOREGROUND_REMOVE"); _STOP_FOREGROUND_REMOVEReady = true; } return _STOP_FOREGROUND_REMOVEContent; } }
        private static int _STOP_FOREGROUND_REMOVEContent = default;
        private static bool _STOP_FOREGROUND_REMOVEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onBind(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder OnBind(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Os.IBinder>("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onUnbind(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnUnbind(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<bool>("onUnbind", "(Landroid/content/Intent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#getApplication()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Application"/></returns>
        public Android.App.Application GetApplication()
        {
            return IExecuteWithSignature<Android.App.Application>("getApplication", "()Landroid/app/Application;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#stopSelfResult(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StopSelfResult(int arg0)
        {
            return IExecuteWithSignature<bool>("stopSelfResult", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#getForegroundServiceType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetForegroundServiceType()
        {
            return IExecuteWithSignature<int>("getForegroundServiceType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#startForeground(int,android.app.Notification,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Notification"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void StartForeground(int arg0, Android.App.Notification arg1, int arg2)
        {
            IExecute("startForeground", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#startForeground(int,android.app.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Notification"/></param>
        public void StartForeground(int arg0, Android.App.Notification arg1)
        {
            IExecute("startForeground", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#stopForeground(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void StopForeground(bool arg0)
        {
            IExecuteWithSignature("stopForeground", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#stopForeground(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void StopForeground(int arg0)
        {
            IExecuteWithSignature("stopForeground", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#stopSelf()"/>
        /// </summary>
        public void StopSelf()
        {
            IExecuteWithSignature("stopSelf", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#stopSelf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void StopSelf(int arg0)
        {
            IExecuteWithSignature("stopSelf", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onStartCommand(android.content.Intent,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int OnStartCommand(Android.Content.Intent arg0, int arg1, int arg2)
        {
            return IExecute<int>("onStartCommand", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onConfigurationChanged(android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Configuration"/></param>
        public void OnConfigurationChanged(Android.Content.Res.Configuration arg0)
        {
            IExecuteWithSignature("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onCreate()"/>
        /// </summary>
        public void OnCreate()
        {
            IExecuteWithSignature("onCreate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onDestroy()"/>
        /// </summary>
        public void OnDestroy()
        {
            IExecuteWithSignature("onDestroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onLowMemory()"/>
        /// </summary>
        public void OnLowMemory()
        {
            IExecuteWithSignature("onLowMemory", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onRebind(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void OnRebind(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("onRebind", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onStart(android.content.Intent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnStart(Android.Content.Intent arg0, int arg1)
        {
            IExecute("onStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onTaskRemoved(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void OnTaskRemoved(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("onTaskRemoved", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onTimeout(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnTimeout(int arg0, int arg1)
        {
            IExecute("onTimeout", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnTimeout(int arg0)
        {
            IExecuteWithSignature("onTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Service.html#onTrimMemory(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnTrimMemory(int arg0)
        {
            IExecuteWithSignature("onTrimMemory", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}