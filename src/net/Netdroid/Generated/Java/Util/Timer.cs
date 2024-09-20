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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Timer
    public partial class Timer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public Timer(bool arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Timer(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Timer(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#purge()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Purge()
        {
            return IExecuteWithSignature<int>("purge", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#schedule(java.util.TimerTask,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Schedule(Java.Util.TimerTask arg0, Java.Util.Date arg1, long arg2)
        {
            IExecute("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#schedule(java.util.TimerTask,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        public void Schedule(Java.Util.TimerTask arg0, Java.Util.Date arg1)
        {
            IExecute("schedule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#schedule(java.util.TimerTask,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Schedule(Java.Util.TimerTask arg0, long arg1, long arg2)
        {
            IExecute("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#schedule(java.util.TimerTask,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Schedule(Java.Util.TimerTask arg0, long arg1)
        {
            IExecute("schedule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#scheduleAtFixedRate(java.util.TimerTask,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ScheduleAtFixedRate(Java.Util.TimerTask arg0, Java.Util.Date arg1, long arg2)
        {
            IExecute("scheduleAtFixedRate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Timer.html#scheduleAtFixedRate(java.util.TimerTask,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimerTask"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ScheduleAtFixedRate(Java.Util.TimerTask arg0, long arg1, long arg2)
        {
            IExecute("scheduleAtFixedRate", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}