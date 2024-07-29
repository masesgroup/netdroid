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

namespace Android.App.Usage
{
    #region NetworkStatsManager
    public partial class NetworkStatsManager
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
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetails(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetails(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetails", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUid(int,java.lang.String,long,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUid(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUid", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUidTag(int,java.lang.String,long,long,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUidTag(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4, int arg5)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUidTag", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUidTagState(int,java.lang.String,long,long,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUidTagState(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4, int arg5, int arg6)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUidTagState", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummary(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QuerySummary(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats>("querySummary", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummaryForDevice(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats.Bucket"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats.Bucket QuerySummaryForDevice(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats.Bucket>("querySummaryForDevice", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummaryForUser(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats.Bucket"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats.Bucket QuerySummaryForUser(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats.Bucket>("querySummaryForUser", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#registerUsageCallback(int,java.lang.String,long,android.app.usage.NetworkStatsManager.UsageCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public void RegisterUsageCallback(int arg0, Java.Lang.String arg1, long arg2, Android.App.Usage.NetworkStatsManager.UsageCallback arg3, Android.Os.Handler arg4)
        {
            IExecute("registerUsageCallback", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#registerUsageCallback(int,java.lang.String,long,android.app.usage.NetworkStatsManager.UsageCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        public void RegisterUsageCallback(int arg0, Java.Lang.String arg1, long arg2, Android.App.Usage.NetworkStatsManager.UsageCallback arg3)
        {
            IExecute("registerUsageCallback", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#unregisterUsageCallback(android.app.usage.NetworkStatsManager.UsageCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        public void UnregisterUsageCallback(Android.App.Usage.NetworkStatsManager.UsageCallback arg0)
        {
            IExecuteWithSignature("unregisterUsageCallback", "(Landroid/app/usage/NetworkStatsManager$UsageCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region UsageCallback
        public partial class UsageCallback
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
            /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.UsageCallback.html#onThresholdReached(int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void OnThresholdReached(int arg0, Java.Lang.String arg1)
            {
                IExecute("onThresholdReached", arg0, arg1);
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