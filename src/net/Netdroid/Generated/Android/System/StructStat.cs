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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.System
{
    #region StructStat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/system/StructStat.html"/>
    /// </summary>
    public partial class StructStat : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StructStat>
    {
        const string _bridgeClassName = "android.system.StructStat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StructStat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StructStat(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region StructStat implementation
    public partial class StructStat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#%3Cinit%3E(long,long,int,long,int,int,long,long,android.system.StructTimespec,android.system.StructTimespec,android.system.StructTimespec,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="long"/></param>
        /// <param name="arg8"><see cref="Android.System.StructTimespec"/></param>
        /// <param name="arg9"><see cref="Android.System.StructTimespec"/></param>
        /// <param name="arg10"><see cref="Android.System.StructTimespec"/></param>
        /// <param name="arg11"><see cref="long"/></param>
        /// <param name="arg12"><see cref="long"/></param>
        public StructStat(long arg0, long arg1, int arg2, long arg3, int arg4, int arg5, long arg6, long arg7, Android.System.StructTimespec arg8, Android.System.StructTimespec arg9, Android.System.StructTimespec arg10, long arg11, long arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#%3Cinit%3E(long,long,int,long,int,int,long,long,long,long,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="long"/></param>
        /// <param name="arg8"><see cref="long"/></param>
        /// <param name="arg9"><see cref="long"/></param>
        /// <param name="arg10"><see cref="long"/></param>
        /// <param name="arg11"><see cref="long"/></param>
        /// <param name="arg12"><see cref="long"/></param>
        public StructStat(long arg0, long arg1, int arg2, long arg3, int arg4, int arg5, long arg6, long arg7, long arg8, long arg9, long arg10, long arg11, long arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_atim"/>
        /// </summary>
        public Android.System.StructTimespec st_atim { get { if (!_st_atimReady) { _st_atimContent = IGetField<Android.System.StructTimespec>("st_atim"); _st_atimReady = true; } return _st_atimContent; } }
        private Android.System.StructTimespec _st_atimContent = default;
        private bool _st_atimReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_ctim"/>
        /// </summary>
        public Android.System.StructTimespec st_ctim { get { if (!_st_ctimReady) { _st_ctimContent = IGetField<Android.System.StructTimespec>("st_ctim"); _st_ctimReady = true; } return _st_ctimContent; } }
        private Android.System.StructTimespec _st_ctimContent = default;
        private bool _st_ctimReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_mtim"/>
        /// </summary>
        public Android.System.StructTimespec st_mtim { get { if (!_st_mtimReady) { _st_mtimContent = IGetField<Android.System.StructTimespec>("st_mtim"); _st_mtimReady = true; } return _st_mtimContent; } }
        private Android.System.StructTimespec _st_mtimContent = default;
        private bool _st_mtimReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_gid"/>
        /// </summary>
        public int st_gid { get { if (!_st_gidReady) { _st_gidContent = IGetField<int>("st_gid"); _st_gidReady = true; } return _st_gidContent; } }
        private int _st_gidContent = default;
        private bool _st_gidReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_mode"/>
        /// </summary>
        public int st_mode { get { if (!_st_modeReady) { _st_modeContent = IGetField<int>("st_mode"); _st_modeReady = true; } return _st_modeContent; } }
        private int _st_modeContent = default;
        private bool _st_modeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_uid"/>
        /// </summary>
        public int st_uid { get { if (!_st_uidReady) { _st_uidContent = IGetField<int>("st_uid"); _st_uidReady = true; } return _st_uidContent; } }
        private int _st_uidContent = default;
        private bool _st_uidReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_atime"/>
        /// </summary>
        public long st_atime { get { if (!_st_atimeReady) { _st_atimeContent = IGetField<long>("st_atime"); _st_atimeReady = true; } return _st_atimeContent; } }
        private long _st_atimeContent = default;
        private bool _st_atimeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_blksize"/>
        /// </summary>
        public long st_blksize { get { if (!_st_blksizeReady) { _st_blksizeContent = IGetField<long>("st_blksize"); _st_blksizeReady = true; } return _st_blksizeContent; } }
        private long _st_blksizeContent = default;
        private bool _st_blksizeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_blocks"/>
        /// </summary>
        public long st_blocks { get { if (!_st_blocksReady) { _st_blocksContent = IGetField<long>("st_blocks"); _st_blocksReady = true; } return _st_blocksContent; } }
        private long _st_blocksContent = default;
        private bool _st_blocksReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_ctime"/>
        /// </summary>
        public long st_ctime { get { if (!_st_ctimeReady) { _st_ctimeContent = IGetField<long>("st_ctime"); _st_ctimeReady = true; } return _st_ctimeContent; } }
        private long _st_ctimeContent = default;
        private bool _st_ctimeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_dev"/>
        /// </summary>
        public long st_dev { get { if (!_st_devReady) { _st_devContent = IGetField<long>("st_dev"); _st_devReady = true; } return _st_devContent; } }
        private long _st_devContent = default;
        private bool _st_devReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_ino"/>
        /// </summary>
        public long st_ino { get { if (!_st_inoReady) { _st_inoContent = IGetField<long>("st_ino"); _st_inoReady = true; } return _st_inoContent; } }
        private long _st_inoContent = default;
        private bool _st_inoReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_mtime"/>
        /// </summary>
        public long st_mtime { get { if (!_st_mtimeReady) { _st_mtimeContent = IGetField<long>("st_mtime"); _st_mtimeReady = true; } return _st_mtimeContent; } }
        private long _st_mtimeContent = default;
        private bool _st_mtimeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_nlink"/>
        /// </summary>
        public long st_nlink { get { if (!_st_nlinkReady) { _st_nlinkContent = IGetField<long>("st_nlink"); _st_nlinkReady = true; } return _st_nlinkContent; } }
        private long _st_nlinkContent = default;
        private bool _st_nlinkReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_rdev"/>
        /// </summary>
        public long st_rdev { get { if (!_st_rdevReady) { _st_rdevContent = IGetField<long>("st_rdev"); _st_rdevReady = true; } return _st_rdevContent; } }
        private long _st_rdevContent = default;
        private bool _st_rdevReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStat.html#st_size"/>
        /// </summary>
        public long st_size { get { if (!_st_sizeReady) { _st_sizeContent = IGetField<long>("st_size"); _st_sizeReady = true; } return _st_sizeContent; } }
        private long _st_sizeContent = default;
        private bool _st_sizeReady = false; // this is used because in case of generics 
    
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
}